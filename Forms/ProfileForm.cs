using GamesView.Models;
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
    public partial class ProfileForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;
        public ProfileForm(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;

            this.Load += ProfileForm_Load;
        }

        private void pictureAvatar_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Panel p in flowLayoutPanel1.Controls)
                p.Width = flowLayoutPanel1.Width - 20;
        }

        private void btnSetting_Click(object sender, EventArgs e)
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

        private void panelProfileHeader_Paint(object sender, PaintEventArgs e)
        {

        }

        private void labelUsername_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }
        private void ProfileForm_Load(object sender, EventArgs e)
        {
            labelUsername.Text = _currentUser.Login;
            labelEmail.Text = _currentUser.Email;
        }

    }
}
