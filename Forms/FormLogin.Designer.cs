namespace GamesView
{
    partial class FormLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel2 = new Panel();
            checkBoxRemember = new CheckBox();
            label4 = new Label();
            label2 = new Label();
            linkLabelReg = new LinkLabel();
            label1 = new Label();
            btnLog = new Button();
            textBoxPass = new TextBox();
            textBoxLogin = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1109, 771);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.BackColor = Color.FromArgb(37, 37, 37);
            panel2.Controls.Add(checkBoxRemember);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(linkLabelReg);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(btnLog);
            panel2.Controls.Add(textBoxPass);
            panel2.Controls.Add(textBoxLogin);
            panel2.Location = new Point(237, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(600, 651);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // checkBoxRemember
            // 
            checkBoxRemember.AutoSize = true;
            checkBoxRemember.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkBoxRemember.ForeColor = SystemColors.ButtonHighlight;
            checkBoxRemember.Location = new Point(90, 299);
            checkBoxRemember.Name = "checkBoxRemember";
            checkBoxRemember.Size = new Size(174, 27);
            checkBoxRemember.TabIndex = 10;
            checkBoxRemember.Text = "Запам'ятати мене";
            checkBoxRemember.UseVisualStyleBackColor = true;
            checkBoxRemember.CheckedChanged += checkBoxRemember_CheckedChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.ButtonHighlight;
            label4.Location = new Point(90, 223);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 9;
            label4.Text = "Пароль :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(90, 125);
            label2.Name = "label2";
            label2.Size = new Size(123, 23);
            label2.TabIndex = 7;
            label2.Text = "Введіть логін :";
            // 
            // linkLabelReg
            // 
            linkLabelReg.AutoSize = true;
            linkLabelReg.LinkColor = Color.White;
            linkLabelReg.Location = new Point(141, 607);
            linkLabelReg.Name = "linkLabelReg";
            linkLabelReg.Size = new Size(298, 20);
            linkLabelReg.TabIndex = 6;
            linkLabelReg.TabStop = true;
            linkLabelReg.Text = "Ще не маєте аккаунта?      Зареєстуватися\r\n";
            linkLabelReg.LinkClicked += linkLabelReg_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonHighlight;
            label1.Location = new Point(246, 33);
            label1.Name = "label1";
            label1.Size = new Size(92, 46);
            label1.TabIndex = 5;
            label1.Text = "Вхід";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnLog
            // 
            btnLog.BackColor = Color.FromArgb(63, 81, 181);
            btnLog.Cursor = Cursors.Hand;
            btnLog.FlatAppearance.BorderSize = 0;
            btnLog.FlatAppearance.MouseDownBackColor = Color.FromArgb(52, 66, 160);
            btnLog.FlatAppearance.MouseOverBackColor = Color.FromArgb(160, 29, 38);
            btnLog.FlatStyle = FlatStyle.Flat;
            btnLog.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLog.ForeColor = SystemColors.ButtonHighlight;
            btnLog.Location = new Point(158, 549);
            btnLog.Name = "btnLog";
            btnLog.Size = new Size(261, 45);
            btnLog.TabIndex = 4;
            btnLog.Text = "Увійти\r\n";
            btnLog.UseVisualStyleBackColor = false;
            btnLog.Click += btnLog_Click;
            // 
            // textBoxPass
            // 
            textBoxPass.Anchor = AnchorStyles.Left;
            textBoxPass.BackColor = Color.Silver;
            textBoxPass.BorderStyle = BorderStyle.FixedSingle;
            textBoxPass.Font = new Font("Segoe UI", 11F);
            textBoxPass.Location = new Point(90, 249);
            textBoxPass.Name = "textBoxPass";
            textBoxPass.Size = new Size(400, 32);
            textBoxPass.TabIndex = 2;
            textBoxPass.Text = "\r\n";
            textBoxPass.TextChanged += textBoxPass_TextChanged;
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
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1109, 771);
            Controls.Add(panel1);
            Name = "FormLogin";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label2;
        private LinkLabel linkLabelReg;
        private Label label1;
        private Button btnLog;
        private TextBox textBoxPass;
        private TextBox textBoxLogin;
        private CheckBox checkBoxRemember;
    }
}
