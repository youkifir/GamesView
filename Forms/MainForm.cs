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
    public partial class MainForm : Form
    {
        private readonly UserService _userService;
        private readonly User _currentUser;
        public MainForm(UserService userService, User user)
        {
            InitializeComponent();
            _userService = userService;
            _currentUser = user;
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

        private void PanelBanner_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void PanelNews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowNews_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FlowLayoutPanelRecommendations_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
