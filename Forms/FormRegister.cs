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
    public partial class FormRegister : Form
    {
        private readonly UserService _userService;

        public FormRegister(UserService userService)
        {
            InitializeComponent();
            _userService = userService;
        }


        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxRePass_TextChanged(object sender, EventArgs e)
        {

        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text.Trim();
            string email = textBoxMail.Text.Trim();
            string pass = textBoxPass.Text;
            string repass = textBoxRePass.Text;

            // === ВАЛИДАЦИЯ ЧЕРЕЗ Validator ===
            string error = Validator.ValidateRegistration(login, email, pass, repass);

            if (error != null)
            {
                MessageBox.Show(error, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // === РЕГИСТРАЦИЯ ЧЕРЕЗ UserService ===
            var result = await _userService.RegisterAsync(login, email, pass, repass);

            if (!result.success)
            {
                MessageBox.Show(result.message, "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Акаунт створено!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Переход на логин форму
            var loginForm = new FormLogin(_userService);
            loginForm.Show();
            this.Close();
        }

        private void linkLabelLog_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var loginForm = new FormLogin(_userService);
            loginForm.Show();
            this.Close();
        }

    }
}