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
    public partial class FormNews : Form
    {
        private readonly NewsService _newsService;
        private readonly AppDbContext _context;
        private readonly UserService _userService;
        private readonly User _currentUser;
        public FormNews(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;

            _context = new AppDbContext();
            _newsService = new NewsService(_context);

            LoadNewsAsync();
        }
        private List<News> GetStaticNews()
        {
            return new List<News>
    {
        new News
        {
            Title = "Нова оновлена версія для Counter-Strike 2 — «Операція: Нова Зоря»",
            Content = "Розробники Counter-Strike 2 анонсували нову операцію «Операція: Нова Зоря», яка додає гру футуристичні мапи, новий режим командного виживання, нові скіни та розширені можливості тактичного бою.",
            ImageUrl = @"C:\Users\user\Desktop\gamesw\Resources\covers\cs2.jpg"
        },

        new News
        {
            Title = "Велике оновлення для Rust — «Ера виживання»",
            Content = "Розробники Rust оголосили про вихід нового масштабного оновлення під назвою «Ера виживання», яке суттєво змінює геймплей. У грі з’являться нові біоми, нові тварини, розширені можливості будівництва та покращена система погоди.",
            ImageUrl = @"C:\Users\user\Desktop\gamesw\Resources\covers\rust.jpg"
        },

        new News
        {
            Title = "Новий сезон у PUBG — «Битва за острови»",
            Content = "PUBG отримує новий сезон із тропічними островами, новою зброєю, розширеною системою нагород та спеціальними подіями. Розробники обіцяють більше динаміки та унікальних бойових ситуацій.",
            ImageUrl = @"C:\Users\user\Desktop\gamesw\Resources\covers\pubg.jpg"
        }
    };
        }
        private async void LoadNewsAsync()
        {
            flowNews.Controls.Clear();

            var newsList = await _newsService.GetAllNewsAsync();

            if (newsList != null && newsList.Count > 0)
            {
                foreach (var n in newsList)
                    flowNews.Controls.Add(CreateNewsDisplayPanel(n));
            }
        }
        private Panel CreateNewsDisplayPanel(News news)
        {
            Panel panel = new Panel
            {
                BackColor = Color.FromArgb(45, 45, 45),
                Size = new Size(flowNews.Width - 25, 180),
                Margin = new Padding(0, 20, 0, 0)
            };

            // ===== КАРТИНКА =====
            PictureBox img = new PictureBox
            {
                Size = new Size(245, 138),        // як у твоїх статичних блоках
                Location = new Point(10, 20),
                SizeMode = PictureBoxSizeMode.Zoom
            };

            if (!string.IsNullOrEmpty(news.ImageUrl) && File.Exists(news.ImageUrl))
                img.Image = Image.FromFile(news.ImageUrl);

            panel.Controls.Add(img);

            // ===== ЗАГОЛОВОК =====
            Label title = new Label
            {
                Text = news.Title,
                Font = new Font("Segoe UI", 12, FontStyle.Bold),
                ForeColor = Color.White,
                Location = new Point(280, 20),
                MaximumSize = new Size(panel.Width - 330, 0),
                AutoSize = true
            };
            panel.Controls.Add(title);

            // ===== ОПИС =====
            Label content = new Label
            {
                Text = news.Content,
                Font = new Font("Segoe UI", 9),
                ForeColor = Color.FromArgb(210, 210, 210),
                Location = new Point(280, title.Bottom + 10),
                MaximumSize = new Size(panel.Width - 330, 0),
                AutoSize = true
            };
            panel.Controls.Add(content);

            return panel;
        }



        private void FormNews_Load(object sender, EventArgs e)
        {

        }
        private void flowNews_SizeChanged(object sender, EventArgs e)
        {
            foreach (Control ctrl in flowNews.Controls)
            {
                ctrl.Width = flowNews.Width - 40;
            }
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

        private void flowNews_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
