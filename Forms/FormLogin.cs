using GamesView.Forms;
using GamesView.Models;

namespace GamesView
{
    public partial class FormLogin : Form
    {
        private readonly UserService _userService;

        // Передавай UserService через DI/конструктор
        public FormLogin(UserService userService)
        {
            InitializeComponent();

            _userService = userService ?? throw new ArgumentNullException(nameof(userService));

            btnLog.Click += BtnLog_Click;
            linkLabelReg.Click += LinkLabelReg_Click;
            this.Load += LoginForm_Load;
        }

        private async void BtnLog_Click(object sender, EventArgs e)
        {
            btnLog.Enabled = false;
            try
            {
                string login = textBoxLogin.Text.Trim();
                string pass = textBoxPass.Text; // не тримим пароль

                if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(pass))
                {
                    MessageBox.Show("Введите логин и пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Вызов твоего UserService exactly как есть
                var result = await _userService.LoginAsync(login, pass);

                if (!result.success)
                {
                    MessageBox.Show(result.message ?? "Невозможно войти.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                User user = result.user;
                if (user == null)
                {
                    MessageBox.Show("Пользователь не найден.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Запомнить (сохраняем логин и пароль в Settings — ты уже создал ключи)
                if (checkBoxRemember.Checked)
                {
                    Properties.Settings.Default.Login = login;
                    Properties.Settings.Default.Password = pass;
                    Properties.Settings.Default.Remember = true;
                    Properties.Settings.Default.Save();
                }
                else
                {
                    Properties.Settings.Default.Login = string.Empty;
                    Properties.Settings.Default.Password = string.Empty;
                    Properties.Settings.Default.Remember = false;
                    Properties.Settings.Default.Save();
                }

                // Успешный вход — открываем основную форму и прячем логин
                var main = new MainForm(_userService, user); // предполагается конструктор, принимающий User
                main.Show();
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при входе: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnLog.Enabled = true;
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            // Автозаполнение, если ранее запомнили
            if (Properties.Settings.Default.Remember)
            {
                textBoxLogin.Text = Properties.Settings.Default.Login ?? string.Empty;
                textBoxPass.Text = Properties.Settings.Default.Password ?? string.Empty;
                checkBoxRemember.Checked = true;
            }
        }

        private void LinkLabelReg_Click(object sender, EventArgs e)
        {
            // Открыть форму регистрации, передав тот же UserService
            var regForm = new FormRegister(_userService);
            regForm.Show();
            this.Hide();
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLog_Click(object sender, EventArgs e)
        {

        }

        private void linkLabelReg_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void checkBoxRemember_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
