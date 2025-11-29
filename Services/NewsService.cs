using GamesView.Data;
using GamesView.Models;
using Microsoft.EntityFrameworkCore;

namespace GamesView.Services
{
    public class NewsService
    {
        private readonly AppDbContext _context;

        public NewsService(AppDbContext context)
        {
            _context = context;
        }

        // Получить все новости (сортировка по дате)
        public async Task<List<News>> GetAllNewsAsync()
        {
            return await _context.News
                .OrderByDescending(n => n.DatePosted)
                .ToListAsync();
        }

        // Получить новости с пагинацией
        public async Task<List<News>> GetNewsAsync(int page, int pageSize)
        {
            return await _context.News
                .OrderByDescending(n => n.DatePosted)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();
        }

        // Получить последние новости (для главной страницы)
        public async Task<List<News>> GetRecentNewsAsync(int count = 5)
        {
            return await _context.News
                .OrderByDescending(n => n.DatePosted)
                .Take(count)
                .ToListAsync();
        }

        // Получить новость по ID
        public async Task<News> GetNewsByIdAsync(int newsId)
        {
            return await _context.News
                .FirstOrDefaultAsync(n => n.NewsId == newsId);
        }

        // Добавить новость (для админа)
        public async Task<bool> AddNewsAsync(string title, string content, string author = null, string imageUrl = null)
        {
            try
            {
                var news = new News
                {
                    Title = title,
                    Content = content,
                    Author = author,
                    ImageUrl = imageUrl,
                    DatePosted = DateTime.Now
                };

                _context.News.Add(news);
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        // Обновить новость (для админа)
        public async Task<bool> UpdateNewsAsync(int newsId, string title, string content, string author = null, string imageUrl = null)
        {
            try
            {
                var news = await _context.News.FindAsync(newsId);
                if (news == null) return false;

                news.Title = title;
                news.Content = content;
                news.Author = author;
                news.ImageUrl = imageUrl;

                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        // Удалить новость (для админа)
        public async Task<bool> DeleteNewsAsync(int newsId)
        {
            try
            {
                var news = await _context.News.FindAsync(newsId);
                if (news == null) return false;

                _context.News.Remove(news);
                return await _context.SaveChangesAsync() > 0;
            }
            catch
            {
                return false;
            }
        }

        // Поиск новостей по заголовку или содержанию
        public async Task<List<News>> SearchNewsAsync(string searchTerm)
        {
            if (string.IsNullOrWhiteSpace(searchTerm))
                return await GetAllNewsAsync();

            return await _context.News
                .Where(n => n.Title.Contains(searchTerm) || n.Content.Contains(searchTerm))
                .OrderByDescending(n => n.DatePosted)
                .ToListAsync();
        }

        // Получить количество новостей
        public async Task<int> GetNewsCountAsync()
        {
            return await _context.News.CountAsync();
        }

        // Получить новости за определенный период
        public async Task<List<News>> GetNewsByDateRangeAsync(DateTime startDate, DateTime endDate)
        {
            return await _context.News
                .Where(n => n.DatePosted >= startDate && n.DatePosted <= endDate)
                .OrderByDescending(n => n.DatePosted)
                .ToListAsync();
        }
    }
}