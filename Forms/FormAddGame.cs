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
    public partial class FormAddGame : Form
    {
        private readonly User _currentUser;
        private readonly UserService _userService;
        public FormAddGame(UserService userService, User user)
        {
            _userService = userService;
            _currentUser = user;
            InitializeComponent();
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

    }
}
