using GamesView.Data;
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
    public partial class FormAddNews : Form
    {
        private readonly AppDbContext _context;
        private readonly NewsService _newsService;
        private readonly User _currentUser;
        private readonly UserService _userService;
        public FormAddNews(UserService userService, User user)
        {
            
            InitializeComponent();
            _currentUser = user;
            _userService = userService;

            _context = new AppDbContext();
            _newsService = new NewsService(_context);

            LoadPreviewNewsAsync();
        }
        private async Task LoadPreviewNewsAsync()
        {
            flowPreviewNews.Controls.Clear();

            using (var ctx = new AppDbContext())
            {
                var service = new NewsService(ctx);
                var list = await service.GetAllNewsAsync();

                foreach (var news in list)
                {
                    var panel = CreateNewsPanel(news);
                    flowPreviewNews.Controls.Add(panel);
                }
            }
        }
        private Panel CreateNewsPanel(News news)
        {
            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(30, 30, 30),
                Size = new Size(flowPreviewNews.Width - 60, 200),
                Margin = new Padding(10),
                BorderStyle = BorderStyle.FixedSingle,
                Padding = new Padding(15)
            };

            // ===== КНОПКА ВИДАЛИТИ (ЗВЕРХУ ПРАВОРУЧ) =====
            Button removeBtn = new Button
            {
                Text = "Видалити",
                BackColor = Color.DarkRed,
                ForeColor = Color.White,
                Size = new Size(100, 35),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                Tag = news.NewsId,
                FlatStyle = FlatStyle.Flat
            };
            removeBtn.FlatAppearance.BorderSize = 0;

            panel.Controls.Add(removeBtn);
            removeBtn.Location = new Point(panel.Width - removeBtn.Width - 20, 15);

            // РОБИМО, ЩОБ КНОПКА НЕ Обрізалась
            panel.Resize += (s, e) =>
            {
                removeBtn.Location = new Point(panel.Width - removeBtn.Width - 20, 15);
            };

            // ===== ЗОБРАЖЕННЯ =====
            PictureBox img = new PictureBox
            {
                Size = new Size(150, 150),
                Location = new Point(20, 40),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (!string.IsNullOrEmpty(news.ImageUrl) && File.Exists(news.ImageUrl))
                img.Image = Image.FromFile(news.ImageUrl);

            panel.Controls.Add(img);

            // ===== ЗАГОЛОВОК =====
            Label title = new Label
            {
                Text = news.Title,
                Font = new Font("Segoe UI", 14, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(190, 40),
                AutoSize = true,
                MaximumSize = new Size(panel.Width - 250, 0)
            };
            panel.Controls.Add(title);

            // ===== ОПИС =====
            Label content = new Label
            {
                Text = news.Content,
                Font = new Font("Segoe UI", 10),
                ForeColor = Color.Silver,
                Location = new Point(190, 80),
                AutoSize = true,
                MaximumSize = new Size(panel.Width - 250, 0)  // Щоб переносив текст
            };
            panel.Controls.Add(content);


            // ===== АВТОРЕСАЙЗ (щоб текст не обрізало) =====
            panel.Resize += (s, e) =>
            {
                title.MaximumSize = new Size(panel.Width - 250, 0);
                content.MaximumSize = new Size(panel.Width - 250, 0);

                removeBtn.Location = new Point(panel.Width - removeBtn.Width - 20, 15);
                panel.Height = Math.Max(content.Bottom + 25, 200);
            };

            // ===== ЛОГІКА ВИДАЛЕННЯ =====
            removeBtn.Click += async (s, e) =>
            {
                if (await _newsService.DeleteNewsAsync(news.NewsId))
                {
                    MessageBox.Show("Новину видалено!");
                    await LoadPreviewNewsAsync();
                }
            };

            // Встановлення фінальної висоти
            panel.Height = Math.Max(content.Bottom + 25, 200);

            return panel;
        }
        private void flowPreviewNews_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control panel in flowPreviewNews.Controls)
            {
                panel.Width = flowPreviewNews.Width - 40;
            }
        }
        private void btnAddGame_Click(object sender, EventArgs e)
        {
            var addgame = new FormAddGame(_userService, _currentUser);
            FormNavigator.Switch(this, addgame);
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

        private string _selectedImagePath = null;

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Images|*.jpg;*.jpeg;*.png;*.webp";
                dlg.Title = "Виберіть зображення";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = dlg.FileName;
                    pictureBoxPreview.Image = Image.FromFile(_selectedImagePath);
                }
            }
        }
        private async void btnAddNews_Click(object sender, EventArgs e)
        {
            string title = txtTitle.Text.Trim();
            string content = txtContent.Text.Trim();

            if (string.IsNullOrWhiteSpace(title) || string.IsNullOrWhiteSpace(content))
            {
                MessageBox.Show("Заповніть всі поля!");
                return;
            }

            string imagePathDb = null;

            if (_selectedImagePath != null)
            {
                string dir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Images", "News");
                Directory.CreateDirectory(dir);

                string fileName = Guid.NewGuid() + Path.GetExtension(_selectedImagePath);
                string newPath = Path.Combine(dir, fileName);

                File.Copy(_selectedImagePath, newPath, true);

                imagePathDb = newPath;
            }

            using (var ctx = new AppDbContext())
            {
                var newsService = new NewsService(ctx);

                bool added = await newsService.AddNewsAsync(
                    title,
                    content,
                    _currentUser.Login,
                    imagePathDb
                );

                if (added)
                {
                    MessageBox.Show("Новину успішно додано!", "Успіх",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtTitle.Text = "";
                    txtContent.Text = "";
                    pictureBoxPreview.Image = null;
                    _selectedImagePath = null;
                    await LoadPreviewNewsAsync();
                }
                else
                {
                    MessageBox.Show("Помилка при збереженні новини!", "Помилка",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    await LoadPreviewNewsAsync();
                }
            }
        }

        private void btnReview_Click(object sender, EventArgs e)
        {
            var review = new ReviewForm(_userService, _currentUser);
            FormNavigator.Switch(this, review);
        }

        private void btnNews_Click(object sender, EventArgs e)
        {

        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            var profile = new ProfileForm(_userService, _currentUser);
            FormNavigator.Switch(this, profile);
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FormAddNews_Load(object sender, EventArgs e)
        {

        }
    }
}
