using GamesView.Data;
using GamesView.Models;
using GamesView.Services;
using GamesView.Utilits;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamesView.Forms
{
    public partial class FavouitesForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;

        private readonly AppDbContext _context;
        private readonly FavoritesService _favoritesService;
        public FavouitesForm(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;

            _context = new AppDbContext();
            _favoritesService = new FavoritesService(_context);

            InitAsync();
        }
        private async void InitAsync()
        {
            try
            {   
                await LoadFavoritesAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка ініціалізації: {ex.Message}");
            }
        }
        private async Task LoadFavoritesAsync()
        {
            try
            {
                // Очищаємо старі картки
                flowFavorites.Controls.Clear();

                // Беремо список ігор з улюблених
                var games = await _favoritesService.GetUserFavoritesAsync(_currentUser.UserId);

                if (games == null || games.Count == 0)
                {
                    var lbl = new Label
                    {
                        AutoSize = true,
                        ForeColor = Color.WhiteSmoke,
                        Font = new Font("Segoe UI", 14, FontStyle.Italic),
                        Text = "У вас поки немає улюблених ігор.",
                        Margin = new Padding(20)
                    };
                    flowFavorites.Controls.Add(lbl);
                    return;
                }

                foreach (var game in games)
                {
                    var panel = CreateGamePanel(game);
                    flowFavorites.Controls.Add(panel);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не вдалося завантажити улюблені ігри: {ex.Message}",
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private Panel CreateGamePanel(Game game)
        {
            var panel = new Panel
            {
                BackColor = Color.FromArgb(35, 35, 35),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(260, 400),
                Margin = new Padding(15)
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
                    {
                        picture.Image = Image.FromFile(fullPath);
                    }
                    else
                    {
                        picture.BackColor = Color.Gray;
                    }
                }
                else
                {
                    picture.BackColor = Color.Gray;
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


            // ===== КНОПКА “–” ВНИЗУ =====
            var removeButton = new Button
            {
                Text = "–",
                Font = new Font("Segoe UI", 18, FontStyle.Bold),
                Size = new Size(40, 40),
                BackColor = Color.FromArgb(200, 50, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Tag = game.GameId,
                TextAlign = ContentAlignment.MiddleCenter
            };

            removeButton.FlatAppearance.BorderSize = 0;

            // Позиція кнопки знизу справа
            removeButton.Location = new Point(
                panel.Width - removeButton.Width - 10,   // 10 px від правого краю
                panel.Height - removeButton.Height - 10  // 10 px з нижнього
            );


            // Hover ефект
            removeButton.MouseEnter += (s, e) =>
            {
                removeButton.BackColor = Color.FromArgb(255, 80, 80);
            };
            removeButton.MouseLeave += (s, e) =>
            {
                removeButton.BackColor = Color.FromArgb(200, 50, 50);
            };

            removeButton.Click += RemoveFavorite_Click;


            // Додаємо елементи
            panel.Controls.Add(picture);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(descLabel);
            panel.Controls.Add(removeButton);

            return panel;
        }
        private async void RemoveFavorite_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            int gameId = (int)btn.Tag;

            var fav = await _context.Favorites
                .FirstOrDefaultAsync(f => f.UserId == _currentUser.UserId && f.GameId == gameId);

            if (fav != null)
            {
                _context.Favorites.Remove(fav);
                await _context.SaveChangesAsync();

                MessageBox.Show("Гру видалено з улюблених.",
                    "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Перезавантажуємо список
            await LoadFavoritesAsync();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {

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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowFavorites_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
