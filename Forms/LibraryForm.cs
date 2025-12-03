using GamesView.Models;
using GamesView.Utilits;
using GamesView.Data;
using GamesView.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace GamesView.Forms
{
    public partial class LibraryForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;

        private readonly AppDbContext _context;
        private readonly FavoritesService _favoritesService;
        public LibraryForm(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;

            _context = new AppDbContext();
            _favoritesService = new FavoritesService(_context);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }
        private async Task AddGameToFavorites(string gameTitle)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == gameTitle);

                if (game == null)
                {
                    MessageBox.Show($"Гру \"{gameTitle}\" не знайдено у базі.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(
                    result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void BtnAddToFav_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            string gameTitle = btn.Tag.ToString();

            await AddGameToFavorites(gameTitle);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Знаходимо гру по назві з бібліотеки
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Marvel's Spider-Man 2");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"Marvel's Spider-Man 2\" не знайдено в базі даних.",
                        "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return;
                }

                // 2. Додаємо в улюблені
                var result = await _favoritesService.AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(
                    result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Сталася помилка при додаванні у \"Улюблені\": {ex.Message}",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void btnNews_Click(object sender, EventArgs e)
        {
            var news = new FormNews(_userService, _currentUser);
            FormNavigator.Switch(this, news);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profile = new ProfileForm(_userService, _currentUser);
            FormNavigator.Switch(this, profile);
        }

        private void btnLibrary_Click(object sender, EventArgs e)
        {
            var library = new LibraryForm(_userService, _currentUser);
            FormNavigator.Switch(this, library);
        }

        private void btnFavorite_Click(object sender, EventArgs e)
        {
            var favourite = new FavouitesForm(_userService, _currentUser);
            FormNavigator.Switch(this, favourite);
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var review = new ReviewForm(_userService, _currentUser);
            FormNavigator.Switch(this, review);
        }

        private void panel23_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void button2_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Hogwarts Legacy");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"Hogwarts Legacy\" не знайдено в базі даних.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button3_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Cyberpunk 2077");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"Cyberpunk 2077\" не знайдено в базі даних.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button4_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Red Dead Redemption 2");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"Red Dead Redemption 2\" не знайдено в базі даних.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button5_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "The Last of Us Part I");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"The Last of Us Part I\" не знайдено в базі.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button6_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Hollow Knight");

                if (game == null)
                {
                    MessageBox.Show(
                        "Гру \"Hollow Knight\" не знайдено в базі.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService.AddToFavoritesAsync(
                    _currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button7_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Silent Hill 2");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Silent Hill 2\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button8_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "The Outlast Trials");

                if (game == null)
                {
                    MessageBox.Show("Гру \"The Outlast Trials\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button9_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Phasmophobia");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Phasmophobia\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button10_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Little Nightmares II");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Little Nightmares II\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button11_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Метро 2033");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Метро 2033\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button12_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Alien: Isolation");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Alien: Isolation\" не знайдено.", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button13_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Detroit: Become Human");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Detroit: Become Human\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button14_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "No, I’m not a Human");

                if (game == null)
                {
                    MessageBox.Show("Гру \"No, I'm not a Human\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private async void button15_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Heavy Rain");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Heavy Rain\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button16_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Life is Strange");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Life is Strange\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button17_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "Beyond: Two Souls");

                if (game == null)
                {
                    MessageBox.Show("Гру \"Beyond: Two Souls\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }
        private async void button18_Click(object sender, EventArgs e)
        {
            try
            {
                var game = await _context.Games
                    .FirstOrDefaultAsync(g => g.Title == "The Quarry");

                if (game == null)
                {
                    MessageBox.Show("Гру \"The Quarry\" не знайдено.",
                        "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var result = await _favoritesService
                    .AddToFavoritesAsync(_currentUser.UserId, game.GameId);

                MessageBox.Show(result.message,
                    result.success ? "Успіх" : "Помилка",
                    MessageBoxButtons.OK,
                    result.success ? MessageBoxIcon.Information : MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}");
            }
        }

        private void panel16_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
