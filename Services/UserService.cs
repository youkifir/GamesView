using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography;
using System.Text;

public class UserService
{
    private readonly AppDbContext _context;

    public UserService(AppDbContext context)
    {
        _context = context;
    }

    // Регистрация пользователя
    public async Task<(bool success, string message)> RegisterAsync(string login, string email, string password, string confirmPassword)
    {
        try
        {
            // Проверка паролей
            if (password != confirmPassword)
                return (false, "Паролі не співпадають");

            // Проверка уникальности логина
            if (await _context.Users.AnyAsync(u => u.Login == login))
                return (false, "Користувач з таким логіном вже існує");

            // Проверка уникальности email
            if (await _context.Users.AnyAsync(u => u.Email == email))
                return (false, "Користувач з такою поштою вже існує");

            // Создание пользователя (RoleId = 1 для обычного пользователя)
            var user = new User
            {
                Login = login,
                Email = email,
                PasswordHash = HashPassword(password),
                RoleId = 1, // 1 = User, 2 = Admin
                DateCreated = DateTime.Now
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return (true, "Користувач успішно зареєстрований");
        }
        catch (Exception ex)
        {
            return (false, $"Помилка реєстрації: {ex.Message}");
        }
    }

    // Вход пользователя
    public async Task<(bool success, User user, string message)> LoginAsync(string login, string password)
    {
        try
        {
            // Поиск пользователя с включением роли
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Login == login);

            if (user == null)
                return (false, null, "Невірний логін або пароль");

            // Проверка пароля
            if (!VerifyPassword(password, user.PasswordHash))
                return (false, null, "Невірний логін або пароль");

            return (true, user, "Вхід успішний");
        }
        catch (Exception ex)
        {
            return (false, null, $"Помилка входу: {ex.Message}");
        }
    }

    // Получение пользователя по ID с включением связанных данных
    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await _context.Users
            .Include(u => u.Role)
            .Include(u => u.Favorites)
            .Include(u => u.Reviews)
            .FirstOrDefaultAsync(u => u.UserId == userId);
    }

    // Получение пользователя по логину
    public async Task<User> GetUserByLoginAsync(string login)
    {
        return await _context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.Login == login);
    }

    // Проверка уникальности логина
    public async Task<bool> IsLoginUniqueAsync(string login)
    {
        return !await _context.Users.AnyAsync(u => u.Login == login);
    }

    // Проверка уникальности email
    public async Task<bool> IsEmailUniqueAsync(string email)
    {
        return !await _context.Users.AnyAsync(u => u.Email == email);
    }

    // Получение всех пользователей (для админа)
    public async Task<List<User>> GetAllUsersAsync()
    {
        return await _context.Users
            .Include(u => u.Role)
            .Include(u => u.Reviews)
            .ToListAsync();
    }

    // Удаление пользователя
    public async Task<bool> DeleteUserAsync(int userId)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Смена пароля
    public async Task<bool> ChangePasswordAsync(int userId, string currentPassword, string newPassword)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null || !VerifyPassword(currentPassword, user.PasswordHash))
                return false;

            user.PasswordHash = HashPassword(newPassword);
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Обновление email
    public async Task<bool> UpdateEmailAsync(int userId, string newEmail)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            // Проверка уникальности нового email
            if (await _context.Users.AnyAsync(u => u.Email == newEmail && u.UserId != userId))
                return false;

            user.Email = newEmail;
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Обновление логина
    public async Task<bool> UpdateLoginAsync(int userId, string newLogin)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            // Проверка уникальности нового логина
            if (await _context.Users.AnyAsync(u => u.Login == newLogin && u.UserId != userId))
                return false;

            user.Login = newLogin;
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Получить количество пользователей
    public async Task<int> GetUsersCountAsync()
    {
        return await _context.Users.CountAsync();
    }

    // Проверить, является ли пользователь админом
    public async Task<bool> IsUserAdminAsync(int userId)
    {
        var user = await _context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.UserId == userId);
        return user?.Role?.Name == "Admin";
    }

    // Сделать пользователя админом
    public async Task<bool> MakeUserAdminAsync(int userId)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

            // RoleId = 2 для Admin
            user.RoleId = 2;
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }

    // Получить статистику пользователя
    public async Task<(int favoritesCount, int reviewsCount)> GetUserStatsAsync(int userId)
    {
        var user = await _context.Users
            .Include(u => u.Favorites)
            .Include(u => u.Reviews)
            .FirstOrDefaultAsync(u => u.UserId == userId);

        if (user == null)
            return (0, 0);

        return (user.Favorites?.Count ?? 0, user.Reviews?.Count ?? 0);
    }

    // Вспомогательные методы для хеширования пароля
    private string HashPassword(string password)
    {
        using var sha256 = SHA256.Create();
        var bytes = Encoding.UTF8.GetBytes(password);
        var hash = sha256.ComputeHash(bytes);
        return Convert.ToBase64String(hash);
    }

    private bool VerifyPassword(string password, string passwordHash)
    {
        return HashPassword(password) == passwordHash;
    }
}