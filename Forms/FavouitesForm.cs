using GamesView.Models;
using GamesView.Utilits;
using GamesView.Data;
using GamesView.Services;
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
        protected override async void OnFormClosing(FormClosingEventArgs e)
        {
            using (var ctx = new AppDbContext())
            {
                var fav = ctx.Favorites.Where(f => f.UserId == _currentUser.UserId);
                ctx.Favorites.RemoveRange(fav);
                await ctx.SaveChangesAsync();
            }

            base.OnFormClosing(e);
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
                BackColor = Color.FromArgb(45, 45, 45),
                BorderStyle = BorderStyle.FixedSingle,
                Size = new Size(300, 400),
                Margin = new Padding(10, 10, 5, 10)
            };

            var picture = new PictureBox
            {
                BorderStyle = BorderStyle.FixedSingle,
                Location = new Point(0, 0),
                Size = new Size(298, 250),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (!string.IsNullOrEmpty(game.CoverPath) && File.Exists(game.CoverPath))
            {
                picture.Image = Image.FromFile(game.CoverPath);
            }

            var titleLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 12F, FontStyle.Bold),
                ForeColor = Color.WhiteSmoke,
                Location = new Point(3, 253),
                Text = game.Title
            };

            var descLabel = new Label
            {
                AutoSize = true,
                Font = new Font("Segoe UI", 10F),
                ForeColor = Color.Gray,
                Location = new Point(1, 281),
                MaximumSize = new Size(280, 0),
                Text = string.IsNullOrWhiteSpace(game.Description)
                        ? "Опис відсутній."
                        : game.Description
            };

            panel.Controls.Add(descLabel);
            panel.Controls.Add(titleLabel);
            panel.Controls.Add(picture);

            return panel;
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
