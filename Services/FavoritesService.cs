using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamesView.Services
{
    internal class FavoritesService
    {
        private readonly AppDbContext _context;

        public FavoritesService(AppDbContext context)
        {
            _context = context;
        }

        // Добавить игру в избранное
        public async Task<(bool success, string message)> AddToFavoritesAsync(int userId, int gameId)
        {
            try
            {
                var game = await _context.Games.FindAsync(gameId);
                if (game == null)
                    return (false, "Гру не знайдено");

                var user = await _context.Users.FindAsync(userId);
                if (user == null)
                    return (false, "Користувача не знайдено");

                bool alreadyExists = await _context.Favorites
                    .AnyAsync(f => f.UserId == userId && f.GameId == gameId);

                if (alreadyExists)
                    return (false, "Гра вже додана до улюблених");

                var favorite = new Favorite
                {
                    UserId = userId,
                    GameId = gameId
                };

                _context.Favorites.Add(favorite);
                int result = await _context.SaveChangesAsync();

                return (result > 0, result > 0 ? "Гру додано до улюблених" : "Не вдалося додати гру до улюблених");
            }
            catch (Exception ex)
            {
                return (false, $"Помилка: {ex.Message}");
            }
        }

        // Удалить игру из избранного
        public async Task<(bool success, string message)> RemoveFromFavoritesAsync(int userId, int gameId)
        {
            try
            {
                var favorite = await _context.Favorites
                    .FirstOrDefaultAsync(f => f.UserId == userId && f.GameId == gameId);

                if (favorite == null)
                    return (false, "Гра не знайдена в улюблених");

                _context.Favorites.Remove(favorite);
                int result = await _context.SaveChangesAsync();

                return (result > 0, result > 0 ? "Гру видалено з улюблених" : "Не вдалося видалити гру з улюблених");
            }
            catch (Exception ex)
            {
                return (false, $"Помилка: {ex.Message}");
            }
        }

        // Получить все избранные игры пользователя
        public async Task<List<Game>> GetUserFavoritesAsync(int userId)
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Game)
                .Select(f => f.Game)
                .OrderBy(g => g.Title)
                .ToListAsync();
        }

        // Получить избранные игры с пагинацией
        public async Task<List<Game>> GetUserFavoritesAsync(int userId, int page, int pageSize)
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Game)
                .Select(f => f.Game)
                .OrderBy(g => g.Title)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        // Проверить, есть ли игра в избранном у пользователя
        public async Task<bool> IsGameInFavoritesAsync(int userId, int gameId)
        {
            return await _context.Favorites
                .AnyAsync(f => f.UserId == userId && f.GameId == gameId);
        }

        // Получить количество избранных игр у пользователя
        public async Task<int> GetFavoritesCountAsync(int userId)
        {
            return await _context.Favorites
                .CountAsync(f => f.UserId == userId);
        }

        // Получить подробную информацию об избранных играх (с включением отзывов и т.д.)
        public async Task<List<Favorite>> GetUserFavoritesDetailedAsync(int userId)
        {
            return await _context.Favorites
                .Where(f => f.UserId == userId)
                .Include(f => f.Game)
                    .ThenInclude(g => g.Reviews)
                .Include(f => f.Game)
                    .ThenInclude(g => g.Genre)
                .OrderBy(f => f.Game.Title)
                .ToListAsync();
        }

        // Удалить все избранные игры пользователя (при удалении аккаунта)
        public async Task<bool> ClearUserFavoritesAsync(int userId)
        {
            try
            {
                var favorites = await _context.Favorites
                    .Where(f => f.UserId == userId)
                    .ToListAsync();

                if (!favorites.Any())
                    return true;

                _context.Favorites.RemoveRange(favorites);
                await _context.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
