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
    }
}