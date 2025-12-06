using GamesView.Models;
using GamesView.Services;
using GamesView.Utilits;
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
    public partial class FormAddGame : Form
    {

        private readonly User _currentUser;
        private readonly UserService _userService;
        private readonly GameService _gameService;
        private string _selectedImagePath;
        public FormAddGame(UserService userService, User user)
        {
            _userService = userService;
            _currentUser = user;
            _gameService = new GameService(new Data.AppDbContext());
            InitializeComponent();
            LoadGames();
        }
        private async void LoadGames()
        {
            flowGames.Controls.Clear();

            var games = await _gameService.GetGamesAsync();
            foreach (var game in games)
            {
                flowGames.Controls.Add(CreateGamePanel(game));
            }
        }
        private Panel CreateGamePanel(Game game)
        {
            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(40, 40, 40),
                Size = new Size(flowGames.Width - 30, 150),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Картинка
            PictureBox img = new PictureBox
            {
                Size = new Size(120, 120),
                Location = new Point(10, 15),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            string fullPath = Path.Combine(Application.StartupPath, "GameImages", game.CoverPath ?? "");
            if (File.Exists(fullPath))
                img.Image = Image.FromFile(fullPath);
            else
                img.BackColor = Color.Gray;

            panel.Controls.Add(img);

            // Назва
            Label title = new Label
            {
                Text = game.Title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(150, 20),
                Width = 400
            };
            panel.Controls.Add(title);

            // Жанр
            Label genre = new Label
            {
                Text = $"Жанр: {game.Genre}",
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Silver,
                Location = new Point(150, 55),
                Width = 400
            };
            panel.Controls.Add(genre);

            // Кнопка видалення
            Button btnDelete = new Button
            {
                Text = "Видалити",
                BackColor = Color.FromArgb(200, 50, 50),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                Size = new Size(120, 40),
                Location = new Point(panel.Width - 150, 55),
                Tag = game.GameId
            };

            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.Click += DeleteGame_Click;

            panel.Controls.Add(btnDelete);

            return panel;
        }
        private async void DeleteGame_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            int gameId = (int)btn.Tag;

            var confirm = MessageBox.Show(
                "Ви впевнені, що хочете видалити гру?",
                "Підтвердження",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (confirm == DialogResult.No) return;

            // Знайти гру
            var game = await _gameService.GetGameByIdAsync(gameId);
            if (game == null)
            {
                MessageBox.Show("Гра не знайдена");
                return;
            }

            // Видалити картинку
            try
            {
                string path = Path.Combine(Application.StartupPath, "GameImages", game.CoverPath ?? "");
                if (File.Exists(path))
                    File.Delete(path);
            }
            catch { }

            // Видалити з БД
            var result = await _gameService.DeleteGameAsync(gameId);
            if (result.success)
                MessageBox.Show("Гру видалено!");
            else
                MessageBox.Show(result.message);

            LoadGames(); // оновити список
        }
        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Виберіть зображення гри";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;
                    pbImage.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }
        private async void btnAdd_Click(object sender, EventArgs e)
        {
            btnAdd.Enabled = false;
            try
            {
                // Валидация
                if (string.IsNullOrWhiteSpace(tbGameName.Text))
                {
                    MessageBox.Show("Введіть назву гри", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (cbCategory.SelectedItem == null)
                {
                    MessageBox.Show("Виберіть жанр", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(tbDescribe.Text))
                {
                    MessageBox.Show("Введіть опис гри", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Создание объекта игры
                var game = new Game
                {
                    Title = tbGameName.Text.Trim(),
                    Genre = cbCategory.SelectedItem.ToString(),
                    Description = tbDescribe.Text.Trim(),
                    CoverPath = SaveGameImage(),
                    Developer = "Невідомий розробник",
                    ReleaseYear = DateTime.Now.Year,
                    Rating = null
                };

                // Добавление в БД
                var result = await _gameService.AddGameAsync(game);

                if (result.success)
                {
                    MessageBox.Show(result.message, "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearForm();
                }
                else
                {
                    MessageBox.Show(result.message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnAdd.Enabled = true;
            }
        }
        private void ClearForm()
        {
            tbGameName.Clear();
            cbCategory.SelectedIndex = -1;
            tbDescribe.Clear();
            pbImage.Image = null;
            _selectedImagePath = null;
        }
        private string SaveGameImage()
        {
            if (string.IsNullOrEmpty(_selectedImagePath) || !File.Exists(_selectedImagePath))
                return null;

            try
            {
                string imagesFolder = Path.Combine(Application.StartupPath, "GameImages");
                if (!Directory.Exists(imagesFolder))
                    Directory.CreateDirectory(imagesFolder);

                // Сохраняем ТОЛЬКО ИМЯ ФАЙЛА, а не полный путь
                string fileName = Path.GetFileName(_selectedImagePath); // ← ТОЛЬКО ИМЯ ФАЙЛА
                string destinationPath = Path.Combine(imagesFolder, fileName);

                // Не перезаписываем если файл уже существует
                if (!File.Exists(destinationPath))
                {
                    File.Copy(_selectedImagePath, destinationPath);
                }

                return fileName; // ← Возвращаем только имя файла
            }
            catch
            {
                return null;
            }
        }
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            var addgame = new FormAddGame(_userService, _currentUser);
            FormNavigator.Switch(this, addgame);
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
            var addNews = new FormAddNews(_userService, _currentUser);
            FormNavigator.Switch(this, addNews);
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profile = new ProfileForm(_userService, _currentUser);
            FormNavigator.Switch(this, profile);
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}