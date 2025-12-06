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
        private readonly GameService _gameService;
        public LibraryForm(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;


            _context = new AppDbContext();
            _favoritesService = new FavoritesService(_context);
            _gameService = new GameService(_context);
            LoadGamesFromDatabase();
        }

        private async void LoadGamesFromDatabase()
        {
            try
            {
                var allGames = await _gameService.GetGamesAsync();

                // Якщо ігор нема — прибираємо всі жанри
                if (allGames == null || allGames.Count == 0)
                {
                    panelSingleGame.Visible = false;
                    panelHorrorGame.Visible = false;
                    panelInteractiveFilm.Visible = false;
                    return;
                }

                // Групуємо ігри за жанрами
                var singleGames = allGames.Where(g => (g.Genre ?? "") == "Одиночна гра").ToList();
                var horrorGames = allGames.Where(g => (g.Genre ?? "") == "Хоррор").ToList();
                var interactiveGames = allGames.Where(g => (g.Genre ?? "") == "Інтерактивне кіно").ToList();

                // Очищаємо попередній контент
                flowSingleGame.Controls.Clear();
                flowHorrorGame.Controls.Clear();
                flowInteractiveFilm.Controls.Clear();

                // Додаємо ігри
                AddGamesToCategory(singleGames, flowSingleGame, panelSingleGame);
                AddGamesToCategory(horrorGames, flowHorrorGame, panelHorrorGame);
                AddGamesToCategory(interactiveGames, flowInteractiveFilm, panelInteractiveFilm);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка завантаження ігор: {ex.Message}");
            }
        }
        private void AddGamesToCategory(List<Game> games, FlowLayoutPanel panel, Panel header)
        {
            if (games == null || games.Count == 0)
            {
                header.Visible = false;
                panel.Visible = false;
                return;
            }

            header.Visible = true;
            panel.Visible = true;

            foreach (var game in games)
            {
                var gamePanel = CreateGamePanel(game);
                panel.Controls.Add(gamePanel);
            }
        }

        private void AddDatabaseGamesToFlowPanel(List<Game> games, FlowLayoutPanel flowPanel)
        {
            foreach (var game in games)
            {
                // Проверяем, нет ли уже этой игры среди заглушек
                if (!IsGameAlreadyInFlowPanel(flowPanel, game.Title))
                {
                    // Создаем панель для игры с ТВОИМИ размерами
                    var gamePanel = CreateGamePanel(game);
                    flowPanel.Controls.Add(gamePanel);
                }
            }
        }

        private bool IsGameAlreadyInFlowPanel(FlowLayoutPanel flowPanel, string gameTitle)
        {
            foreach (Control control in flowPanel.Controls)
            {
                if (control is Panel panel)
                {
                    foreach (Control child in panel.Controls)
                    {
                        if (child is Label label && label.Text == gameTitle)
                        {
                            return true; // Игра уже есть
                        }
                    }
                }
            }
            return false;
        }
        private Panel CreateGamePanel(Game game)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(35, 35, 35),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(260, 400),
                Margin = new Padding(15),
                Tag = game.GameId
            };

            // ===== КАРТИНКА =====
            var picture = new PictureBox
            {
                Size = new Size(258, 250),
                Location = new Point(1, 1),
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.FixedSingle
            };

            try
            {
                if (!string.IsNullOrEmpty(game.CoverPath))
                {
                    string fullPath = Path.Combine(Application.StartupPath, "GameImages", game.CoverPath);

                    if (File.Exists(fullPath))
                        picture.Image = Image.FromFile(fullPath);
                }
            }
            catch
            {
                picture.BackColor = Color.Gray;
            }

            // ===== НАЗВА =====
            var titleLabel = new Label
            {
                AutoSize = false,
                Text = game.Title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(10, 260),
                Width = 230,
                Height = 30
            };

            // ===== ОПИС =====
            var descLabel = new Label
            {
                AutoSize = false,
                Text = string.IsNullOrWhiteSpace(game.Description) ? "Опис відсутній." : game.Description,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.Silver,
                Location = new Point(10, 290),
                Width = 240,
                Height = 60
            };

            // ===== КНОПКА "+" =====
            var favButton = new Button
            {
                Text = "+",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(40, 40),
                BackColor = Color.FromArgb(63, 81, 181),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = game.GameId,
                TextAlign = ContentAlignment.MiddleCenter,
                Padding = new Padding(0)
            };

            favButton.FlatAppearance.BorderSize = 0;

            // позиція справа знизу (в панелі)
            favButton.Location = new Point(
                panel.Width - favButton.Width - 10,
                panel.Height - favButton.Height - 10
            );

            favButton.MouseEnter += (s, e) =>
            {
                favButton.BackColor = Color.FromArgb(90, 110, 230);
            };
            favButton.MouseLeave += (s, e) =>
            {
                favButton.BackColor = Color.FromArgb(63, 81, 181);
            };

            favButton.Click += async (s, e) =>
            {
                var btn = s as Button;
                int gameId = (int)btn.Tag;

                var result = await _favoritesService.AddToFavoritesAsync(_currentUser.UserId, gameId);

                if (result.success)
                {
                    btn.Text = "✓";
                    btn.BackColor = Color.Green;
                    btn.Enabled = false;
                }
                else
                {
                    MessageBox.Show(result.message);
                }
            };

            // Додаємо на панель
            panel.Controls.Add(picture);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(descLabel);
            panel.Controls.Add(favButton);

            panel.Controls.SetChildIndex(favButton, 0);

            return panel;
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

        private void flowSingleGame_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelSingleGame_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}