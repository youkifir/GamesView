namespace GamesView.Forms
{
    partial class ProfileForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProfileForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnProfile = new Button();
            btnNews = new Button();
            btnReview = new Button();
            btnFavorite = new Button();
            btnLibrary = new Button();
            panelProfileHeader = new Panel();
            button1 = new Button();
            labelEmail = new Label();
            labelUsername = new Label();
            pictureAvatar = new PictureBox();
            panelAccountInfo = new Panel();
            label11 = new Label();
            label10 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            flowLayoutPanel1 = new FlowLayoutPanel();
            panel3 = new Panel();
            label3 = new Label();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel4 = new Panel();
            label8 = new Label();
            label4 = new Label();
            label5 = new Label();
            pictureBox2 = new PictureBox();
            panel5 = new Panel();
            label9 = new Label();
            label6 = new Label();
            label7 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelProfileHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).BeginInit();
            panelAccountInfo.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1563, 60);
            panel1.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 5;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Controls.Add(btnProfile, 4, 0);
            tableLayoutPanel1.Controls.Add(btnNews, 3, 0);
            tableLayoutPanel1.Controls.Add(btnReview, 2, 0);
            tableLayoutPanel1.Controls.Add(btnFavorite, 1, 0);
            tableLayoutPanel1.Controls.Add(btnLibrary, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1563, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = SystemColors.Highlight;
            btnProfile.Location = new Point(1251, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(309, 54);
            btnProfile.TabIndex = 4;
            btnProfile.Text = "Профіль";
            btnProfile.UseVisualStyleBackColor = true;
            btnProfile.Click += btnProfile_Click;
            // 
            // btnNews
            // 
            btnNews.Dock = DockStyle.Fill;
            btnNews.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnNews.FlatAppearance.MouseOverBackColor = Color.Red;
            btnNews.FlatStyle = FlatStyle.Flat;
            btnNews.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnNews.ForeColor = Color.WhiteSmoke;
            btnNews.Location = new Point(939, 3);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(306, 54);
            btnNews.TabIndex = 3;
            btnNews.Text = "Новини";
            btnNews.UseVisualStyleBackColor = true;
            btnNews.Click += btnNews_Click;
            // 
            // btnReview
            // 
            btnReview.Dock = DockStyle.Fill;
            btnReview.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnReview.FlatAppearance.MouseOverBackColor = Color.Red;
            btnReview.FlatStyle = FlatStyle.Flat;
            btnReview.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnReview.ForeColor = Color.WhiteSmoke;
            btnReview.Location = new Point(627, 3);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(306, 54);
            btnReview.TabIndex = 2;
            btnReview.Text = "Відгуки";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += btnReview_Click;
            // 
            // btnFavorite
            // 
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnFavorite.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFavorite.ForeColor = Color.WhiteSmoke;
            btnFavorite.Location = new Point(315, 3);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(306, 54);
            btnFavorite.TabIndex = 1;
            btnFavorite.Text = "Улюблені ігри";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Dock = DockStyle.Fill;
            btnLibrary.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnLibrary.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLibrary.FlatStyle = FlatStyle.Flat;
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLibrary.ForeColor = Color.WhiteSmoke;
            btnLibrary.Location = new Point(3, 3);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(306, 54);
            btnLibrary.TabIndex = 0;
            btnLibrary.Text = "Бібліотека";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // panelProfileHeader
            // 
            panelProfileHeader.BackColor = Color.FromArgb(45, 45, 45);
            panelProfileHeader.BackgroundImageLayout = ImageLayout.Zoom;
            panelProfileHeader.Controls.Add(button1);
            panelProfileHeader.Controls.Add(labelEmail);
            panelProfileHeader.Controls.Add(labelUsername);
            panelProfileHeader.Controls.Add(pictureAvatar);
            panelProfileHeader.Dock = DockStyle.Top;
            panelProfileHeader.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panelProfileHeader.Location = new Point(0, 60);
            panelProfileHeader.Name = "panelProfileHeader";
            panelProfileHeader.Size = new Size(1563, 220);
            panelProfileHeader.TabIndex = 1;
            panelProfileHeader.Paint += panelProfileHeader_Paint;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.Pink;
            button1.Location = new Point(1392, 172);
            button1.Name = "button1";
            button1.Size = new Size(159, 43);
            button1.TabIndex = 3;
            button1.Text = "Адмін панель";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEmail.ForeColor = Color.Silver;
            labelEmail.Location = new Point(213, 89);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(176, 25);
            labelEmail.TabIndex = 2;
            labelEmail.Text = "email@example.com";
            labelEmail.Click += labelEmail_Click;
            // 
            // labelUsername
            // 
            labelUsername.AutoSize = true;
            labelUsername.Font = new Font("Segoe UI", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelUsername.ForeColor = Color.White;
            labelUsername.Location = new Point(200, 35);
            labelUsername.Name = "labelUsername";
            labelUsername.Size = new Size(259, 50);
            labelUsername.TabIndex = 1;
            labelUsername.Text = "Username123";
            labelUsername.Click += labelUsername_Click;
            // 
            // pictureAvatar
            // 
            pictureAvatar.Image = (Image)resources.GetObject("pictureAvatar.Image");
            pictureAvatar.Location = new Point(30, 35);
            pictureAvatar.Name = "pictureAvatar";
            pictureAvatar.Size = new Size(150, 149);
            pictureAvatar.SizeMode = PictureBoxSizeMode.Zoom;
            pictureAvatar.TabIndex = 0;
            pictureAvatar.TabStop = false;
            // 
            // panelAccountInfo
            // 
            panelAccountInfo.BackColor = Color.FromArgb(35, 35, 35);
            panelAccountInfo.Controls.Add(label11);
            panelAccountInfo.Controls.Add(label10);
            panelAccountInfo.Dock = DockStyle.Top;
            panelAccountInfo.Location = new Point(0, 280);
            panelAccountInfo.Name = "panelAccountInfo";
            panelAccountInfo.Size = new Size(1563, 180);
            panelAccountInfo.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Impact", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(13, 48);
            label11.Name = "label11";
            label11.Size = new Size(174, 44);
            label11.TabIndex = 1;
            label11.Text = "Ігри у бібліотеці : 6\r\n\r\n";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Impact", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(11, 13);
            label10.Name = "label10";
            label10.Size = new Size(249, 22);
            label10.TabIndex = 0;
            label10.Text = "Дата реєстрації : 05.11.2025";
            // 
            // panel2
            // 
            panel2.Controls.Add(label1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 460);
            panel2.Name = "panel2";
            panel2.Size = new Size(1563, 51);
            panel2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(11, 3);
            label1.Name = "label1";
            label1.Size = new Size(304, 41);
            label1.TabIndex = 0;
            label1.Text = "Останні додані ігри";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Controls.Add(panel3);
            flowLayoutPanel1.Controls.Add(panel4);
            flowLayoutPanel1.Controls.Add(panel5);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 511);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10, 11, 10, 11);
            flowLayoutPanel1.Size = new Size(1563, 544);
            flowLayoutPanel1.TabIndex = 4;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(35, 35, 35);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(pictureBox1);
            panel3.Location = new Point(13, 14);
            panel3.Name = "panel3";
            panel3.Size = new Size(975, 160);
            panel3.TabIndex = 0;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(799, 123);
            label3.Name = "label3";
            label3.Size = new Size(169, 20);
            label3.TabIndex = 2;
            label3.Text = "Додано 2 години тому\r\n";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(251, 13);
            label2.Name = "label2";
            label2.Size = new Size(245, 28);
            label2.TabIndex = 1;
            label2.Text = "The witcher 3 : Wild Hunt ";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(17, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(229, 129);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(35, 35, 35);
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(13, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(975, 160);
            panel4.TabIndex = 1;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(224, 224, 224);
            label8.Location = new Point(840, 123);
            label8.Name = "label8";
            label8.Size = new Size(128, 20);
            label8.TabIndex = 3;
            label8.Text = "Додано 2 Грудня";
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(1509, 117);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(251, 13);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 1;
            label5.Text = "Resident Evil 4";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(17, 13);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(229, 129);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(35, 35, 35);
            panel5.Controls.Add(label9);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label7);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(13, 346);
            panel5.Name = "panel5";
            panel5.Size = new Size(975, 160);
            panel5.TabIndex = 2;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.FromArgb(224, 224, 224);
            label9.Location = new Point(827, 123);
            label9.Name = "label9";
            label9.Size = new Size(141, 20);
            label9.TabIndex = 3;
            label9.Text = "Додано 28 Лютого";
            label9.Click += label9_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.FromArgb(224, 224, 224);
            label6.Location = new Point(1509, 117);
            label6.Name = "label6";
            label6.Size = new Size(0, 20);
            label6.TabIndex = 2;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(251, 13);
            label7.Name = "label7";
            label7.Size = new Size(108, 28);
            label7.TabIndex = 1;
            label7.Text = "The Sims 4";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(30, 30, 30);
            pictureBox3.BackgroundImageLayout = ImageLayout.None;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.ImageLocation = "";
            pictureBox3.Location = new Point(17, 13);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(229, 129);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // ProfileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1563, 1055);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panelAccountInfo);
            Controls.Add(panelProfileHeader);
            Controls.Add(panel1);
            Name = "ProfileForm";
            Text = "ProfileForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelProfileHeader.ResumeLayout(false);
            panelProfileHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureAvatar).EndInit();
            panelAccountInfo.ResumeLayout(false);
            panelAccountInfo.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            flowLayoutPanel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnProfile;
        private Button btnNews;
        private Button btnReview;
        private Button btnFavorite;
        private Button btnLibrary;
        private Panel panelProfileHeader;
        private Label labelEmail;
        private Label labelUsername;
        private PictureBox pictureAvatar;
        private Panel panelAccountInfo;
        private Panel panel2;
        private Label label1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Panel panel4;
        private Label label8;
        private Label label4;
        private Label label5;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label9;
        private Label label6;
        private Label label7;
        private PictureBox pictureBox3;
        private Label label10;
        private Label label11;
        private Button button1;
    }
}