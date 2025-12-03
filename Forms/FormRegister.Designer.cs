namespace GamesView.Forms
{
    partial class FormRegister
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel2 = new Panel();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            linkLabelLog = new LinkLabel();
            label1 = new Label();
            btnReg = new Button();
            textBoxRePass = new TextBox();
            textBoxPass = new TextBox();
            textBoxMail = new TextBox();
            textBoxLogin = new TextBox();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(37, 37, 37);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabelLog);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnReg);
            panel2.Controls.Add(textBoxRePass);
            panel2.Controls.Add(textBoxPass);
            panel2.Controls.Add(textBoxMail);
            panel2.Controls.Add(textBoxLogin);
            panel2.Location = new Point(250, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 650);
            panel2.TabIndex = 0;
            panel2.Paint += panel2_Paint;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.ButtonHighlight;
            label5.Location = new Point(90, 441);
            label5.Name = "label5";
            label5.Size = new Size(111, 23);
            label5.TabIndex = 10;
            label5.Text = "Підтвердіть :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(90, 335);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 9;
            label4.Text = "Пароль :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonHighlight;
            label3.Location = new Point(90, 229);
            label3.Name = "label3";
            label3.Size = new Size(167, 23);
            label3.TabIndex = 8;
            label3.Text = "Введіть ваш E-mail :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(90, 126);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 7;
            label2.Text = "Введіть логін :";
            // 
            // linkLabelLog
            // 
            linkLabelLog.AutoSize = true;
            linkLabelLog.LinkColor = Color.White;
            linkLabelLog.Location = new Point(182, 603);
            linkLabelLog.Name = "linkLabelLog";
            linkLabelLog.Size = new Size(213, 20);
            linkLabelLog.TabIndex = 6;
            linkLabelLog.TabStop = true;
            linkLabelLog.Text = "Вже маєте аккаунт?      Увійти";
            linkLabelLog.LinkClicked += linkLabelLog_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(191, 38);
            label1.Name = "label1";
            label1.Size = new Size(214, 46);
            label1.TabIndex = 5;
            label1.Text = "Реєстрація";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnReg
            // 
            btnReg.BackColor = Color.FromArgb(63, 81, 181);
            btnReg.Cursor = Cursors.Hand;
            btnReg.FlatAppearance.BorderSize = 0;
            btnReg.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 66, 160);
            btnReg.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 29, 38);
            btnReg.FlatStyle = FlatStyle.Flat;
            btnReg.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReg.ForeColor = SystemColors.ButtonHighlight;
            btnReg.Location = new Point(160, 545);
            btnReg.Name = "btnReg";
            btnReg.Size = new Size(260, 45);
            btnReg.TabIndex = 4;
            btnReg.Text = "Зареєструватися";
            btnReg.UseVisualStyleBackColor = false;
            btnReg.Click += btnReg_Click;
            // 
            // textBoxRePass
            // 
            textBoxRePass.Anchor = AnchorStyles.Left;
            textBoxRePass.BackColor = Color.Silver;
            textBoxRePass.BorderStyle = BorderStyle.FixedSingle;
            textBoxRePass.Font = new Font("Segoe UI", 11F);
            textBoxRePass.Location = new Point(90, 467);
            textBoxRePass.Name = "textBoxRePass";
            textBoxRePass.Size = new Size(400, 32);
            textBoxRePass.TabIndex = 3;
            textBoxRePass.Text = "\r\n";
            textBoxRePass.TextChanged += textBoxRePass_TextChanged;
            // 
            // textBoxPass
            // 
            textBoxPass.Anchor = AnchorStyles.Left;
            textBoxPass.BackColor = Color.Silver;
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Font = new Font("Segoe UI", 11F);
            textBoxPass.Location = new Point(90, 361);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(400, 32);
            textBoxPass.TabIndex = 2;
            textBoxPass.Text = "\r\n";
            textBoxPass.TextChanged += textBoxPass_TextChanged;
            // 
            // textBoxMail
            // 
            textBoxMail.Anchor = AnchorStyles.Left;
            textBoxMail.BackColor = Color.Silver;
            textBoxMail.BorderStyle = BorderStyle.FixedSingle;
            textBoxMail.Font = new Font("Segoe UI", 11F);
            textBoxMail.Location = new Point(90, 255);
            textBoxMail.Name = "textBoxMail";
            textBoxMail.Size = new Size(400, 32);
            textBoxMail.TabIndex = 1;
            textBoxMail.Text = "\r\n";
            // 
            // textBoxLogin
            // 
            textBoxLogin.Anchor = AnchorStyles.Left;
            textBoxLogin.BackColor = Color.Silver;
            textBoxLogin.BorderStyle = BorderStyle.FixedSingle;
            textBoxLogin.Font = new Font("Segoe UI", 11F);
            textBoxLogin.Location = new Point(90, 152);
            textBoxLogin.Name = "textBoxLogin";
            textBoxLogin.Size = new Size(400, 32);
            textBoxLogin.TabIndex = 0;
            textBoxLogin.Text = "\r\n";
            textBoxLogin.TextChanged += textBoxLogin_TextChanged;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 770);
            panel1.TabIndex = 0;
            // 
            // FormRegister
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1109, 770);
            Controls.Add(panel1);
            Name = "FormRegister";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormRegister";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private TextBox textBoxLogin;
        private TextBox textBoxRePass;
        private TextBox textBoxPass;
        private TextBox textBoxMail;
        private Button btnReg;
        private Label label1;
        private LinkLabel linkLabelLog;
        private Label label2;
        private Label label5;
        private Label label4;
        private Label label3;
    }
}