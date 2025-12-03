using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;

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
            string cleanPassword = RemoveControlCharacters(password);
            string cleanConfirmPassword = RemoveControlCharacters(confirmPassword);

            if (cleanPassword != cleanConfirmPassword)
                return (false, "Паролі не співпадають");

            if (await _context.Users.AnyAsync(u => u.Login == login))
                return (false, "Користувач з таким логіном вже існує");

            if (await _context.Users.AnyAsync(u => u.Email == email))
                return (false, "Користувач з такою поштою вже існує");

            var user = new User
            {
                Login = login,
                Email = email,
                PasswordHash = cleanPassword,
                RoleId = 1,
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
            var user = await _context.Users
                .Include(u => u.Role)
                .FirstOrDefaultAsync(u => u.Login == login);

            if (user == null)
                return (false, null, "Невірний логін або пароль");

            // Убираем все управляющие символы из сохраненного пароля
            string storedPassword = RemoveControlCharacters(user.PasswordHash);
            string inputPassword = RemoveControlCharacters(password);

            if (inputPassword != storedPassword)
                return (false, null, "Невірний логін або пароль");

            return (true, user, "Вхід успішний");
        }
        catch (Exception ex)
        {
            return (false, null, $"Помилка входу: {ex.Message}");
        }
    }

    // Метод для удаления управляющих символов
    private string RemoveControlCharacters(string input)
    {
        if (string.IsNullOrEmpty(input))
            return input;

        return new string(input.Where(c => !char.IsControl(c)).ToArray());
    }

    public static bool IsAdmin(User user)
    {
        return user?.RoleId == 2;
    }

    public async Task<User> GetUserByIdAsync(int userId)
    {
        return await _context.Users
            .Include(u => u.Role)
            .FirstOrDefaultAsync(u => u.UserId == userId);
    }

    public async Task<bool> UpdateEmailAsync(int userId, string newEmail)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null) return false;

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

    public async Task<bool> ChangePasswordAsync(int userId, string currentPassword, string newPassword)
    {
        try
        {
            var user = await _context.Users.FindAsync(userId);
            if (user == null || currentPassword != user.PasswordHash)
                return false;

            user.PasswordHash = newPassword;
            await _context.SaveChangesAsync();
            return true;
        }
        catch
        {
            return false;
        }
    }
}