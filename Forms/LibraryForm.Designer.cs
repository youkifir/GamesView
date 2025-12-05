namespace GamesView.Forms
{
    partial class LibraryForm
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
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnFavorite = new Button();
            btnProfile = new Button();
            btnNews = new Button();
            btnReview = new Button();
            btnLibrary = new Button();
            panel2 = new Panel();
            flowInteractiveFilm = new FlowLayoutPanel();
            panelInteractiveFilm = new Panel();
            lbInteractiveFilm = new Label();
            flowHorrorGame = new FlowLayoutPanel();
            panelHorrorGame = new Panel();
            lbHorrorGame = new Label();
            flowSingleGame = new FlowLayoutPanel();
            panelSingleGame = new Panel();
            lbSingleGame = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panelInteractiveFilm.SuspendLayout();
            panelHorrorGame.SuspendLayout();
            panelSingleGame.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1418, 45);
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
            tableLayoutPanel1.Controls.Add(btnFavorite, 1, 0);
            tableLayoutPanel1.Controls.Add(btnProfile, 4, 0);
            tableLayoutPanel1.Controls.Add(btnNews, 3, 0);
            tableLayoutPanel1.Controls.Add(btnReview, 2, 0);
            tableLayoutPanel1.Controls.Add(btnLibrary, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1418, 45);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnFavorite
            // 
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnFavorite.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFavorite.ForeColor = Color.WhiteSmoke;
            btnFavorite.Location = new Point(286, 2);
            btnFavorite.Margin = new Padding(3, 2, 3, 2);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(277, 41);
            btnFavorite.TabIndex = 11;
            btnFavorite.Text = "Улюблені ігри";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.WhiteSmoke;
            btnProfile.Location = new Point(1135, 2);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(280, 41);
            btnProfile.TabIndex = 10;
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
            btnNews.Location = new Point(852, 2);
            btnNews.Margin = new Padding(3, 2, 3, 2);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(277, 41);
            btnNews.TabIndex = 9;
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
            btnReview.Location = new Point(569, 2);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(277, 41);
            btnReview.TabIndex = 8;
            btnReview.Text = "Відгуки";
            btnReview.UseVisualStyleBackColor = true;
            btnReview.Click += btnReview_Click;
            // 
            // btnLibrary
            // 
            btnLibrary.Dock = DockStyle.Fill;
            btnLibrary.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnLibrary.FlatAppearance.MouseOverBackColor = Color.Red;
            btnLibrary.FlatStyle = FlatStyle.Flat;
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnLibrary.ForeColor = SystemColors.HotTrack;
            btnLibrary.Location = new Point(3, 2);
            btnLibrary.Margin = new Padding(3, 2, 3, 2);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(277, 41);
            btnLibrary.TabIndex = 2;
            btnLibrary.Text = "Бібліотека";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowInteractiveFilm);
            panel2.Controls.Add(panelInteractiveFilm);
            panel2.Controls.Add(flowHorrorGame);
            panel2.Controls.Add(panelHorrorGame);
            panel2.Controls.Add(flowSingleGame);
            panel2.Controls.Add(panelSingleGame);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Margin = new Padding(0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(9, 8, 9, 8);
            panel2.Size = new Size(1418, 746);
            panel2.TabIndex = 2;
            // 
            // flowInteractiveFilm
            // 
            flowInteractiveFilm.AutoScroll = true;
            flowInteractiveFilm.Dock = DockStyle.Top;
            flowInteractiveFilm.FlowDirection = FlowDirection.TopDown;
            flowInteractiveFilm.Location = new Point(9, 1070);
            flowInteractiveFilm.Margin = new Padding(9, 8, 9, 8);
            flowInteractiveFilm.Name = "flowInteractiveFilm";
            flowInteractiveFilm.Padding = new Padding(9, 8, 9, 8);
            flowInteractiveFilm.Size = new Size(1383, 430);
            flowInteractiveFilm.TabIndex = 5;
            // 
            // panelInteractiveFilm
            // 
            panelInteractiveFilm.AutoSize = true;
            panelInteractiveFilm.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelInteractiveFilm.Controls.Add(lbInteractiveFilm);
            panelInteractiveFilm.Dock = DockStyle.Top;
            panelInteractiveFilm.Location = new Point(9, 995);
            panelInteractiveFilm.Margin = new Padding(0);
            panelInteractiveFilm.Name = "panelInteractiveFilm";
            panelInteractiveFilm.Padding = new Padding(0, 8, 0, 8);
            panelInteractiveFilm.Size = new Size(1383, 75);
            panelInteractiveFilm.TabIndex = 4;
            // 
            // lbInteractiveFilm
            // 
            lbInteractiveFilm.AutoSize = true;
            lbInteractiveFilm.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbInteractiveFilm.ForeColor = Color.White;
            lbInteractiveFilm.Location = new Point(3, 37);
            lbInteractiveFilm.Name = "lbInteractiveFilm";
            lbInteractiveFilm.Size = new Size(215, 30);
            lbInteractiveFilm.TabIndex = 0;
            lbInteractiveFilm.Text = "Інтерактивне кіно";
            // 
            // flowHorrorGame
            // 
            flowHorrorGame.AutoScroll = true;
            flowHorrorGame.Dock = DockStyle.Top;
            flowHorrorGame.FlowDirection = FlowDirection.TopDown;
            flowHorrorGame.Location = new Point(9, 565);
            flowHorrorGame.Margin = new Padding(9, 8, 9, 8);
            flowHorrorGame.Name = "flowHorrorGame";
            flowHorrorGame.Padding = new Padding(9, 8, 9, 8);
            flowHorrorGame.Size = new Size(1383, 430);
            flowHorrorGame.TabIndex = 3;
            // 
            // panelHorrorGame
            // 
            panelHorrorGame.AutoSize = true;
            panelHorrorGame.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelHorrorGame.Controls.Add(lbHorrorGame);
            panelHorrorGame.Dock = DockStyle.Top;
            panelHorrorGame.Location = new Point(9, 498);
            panelHorrorGame.Margin = new Padding(0);
            panelHorrorGame.Name = "panelHorrorGame";
            panelHorrorGame.Padding = new Padding(0, 8, 0, 8);
            panelHorrorGame.Size = new Size(1383, 67);
            panelHorrorGame.TabIndex = 2;
            // 
            // lbHorrorGame
            // 
            lbHorrorGame.AutoSize = true;
            lbHorrorGame.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbHorrorGame.ForeColor = Color.White;
            lbHorrorGame.Location = new Point(3, 29);
            lbHorrorGame.Name = "lbHorrorGame";
            lbHorrorGame.Size = new Size(148, 30);
            lbHorrorGame.TabIndex = 0;
            lbHorrorGame.Text = "Хоррор ігри";
            // 
            // flowSingleGame
            // 
            flowSingleGame.AutoScroll = true;
            flowSingleGame.Dock = DockStyle.Top;
            flowSingleGame.FlowDirection = FlowDirection.TopDown;
            flowSingleGame.Location = new Point(9, 68);
            flowSingleGame.Margin = new Padding(9, 8, 9, 8);
            flowSingleGame.Name = "flowSingleGame";
            flowSingleGame.Padding = new Padding(9, 8, 9, 8);
            flowSingleGame.Size = new Size(1383, 430);
            flowSingleGame.TabIndex = 1;
            // 
            // panelSingleGame
            // 
            panelSingleGame.AutoSize = true;
            panelSingleGame.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            panelSingleGame.Controls.Add(lbSingleGame);
            panelSingleGame.Dock = DockStyle.Top;
            panelSingleGame.Location = new Point(9, 8);
            panelSingleGame.Margin = new Padding(0);
            panelSingleGame.Name = "panelSingleGame";
            panelSingleGame.Padding = new Padding(0, 8, 0, 8);
            panelSingleGame.Size = new Size(1383, 60);
            panelSingleGame.TabIndex = 0;
            // 
            // lbSingleGame
            // 
            lbSingleGame.AutoSize = true;
            lbSingleGame.Font = new Font("Segoe UI Black", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbSingleGame.ForeColor = Color.White;
            lbSingleGame.Location = new Point(3, 22);
            lbSingleGame.Name = "lbSingleGame";
            lbSingleGame.Size = new Size(168, 30);
            lbSingleGame.TabIndex = 0;
            lbSingleGame.Text = "Одиночна гра";
            // 
            // LibraryForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1418, 791);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "LibraryForm";
            Text = "Library";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelInteractiveFilm.ResumeLayout(false);
            panelInteractiveFilm.PerformLayout();
            panelHorrorGame.ResumeLayout(false);
            panelHorrorGame.PerformLayout();
            panelSingleGame.ResumeLayout(false);
            panelSingleGame.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnFavorite;
        private Button btnProfile;
        private Button btnNews;
        private Button btnReview;
        private Button btnLibrary;
        private Panel panel2;
        private FlowLayoutPanel flowInteractiveFilm;
        private Panel panelInteractiveFilm;
        private Label lbInteractiveFilm;
        private FlowLayoutPanel flowHorrorGame;
        private Panel panelHorrorGame;
        private Label lbHorrorGame;
        private FlowLayoutPanel flowSingleGame;
        private Panel panelSingleGame;
        private Label lbSingleGame;
    }
}