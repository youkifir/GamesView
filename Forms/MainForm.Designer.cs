namespace GamesView.Forms
{
    partial class MainForm
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
            btnProfile = new Button();
            btnNews = new Button();
            btnReview = new Button();
            btnFavorite = new Button();
            btnLibrary = new Button();
            panel2 = new Panel();
            FlowLayoutPanelRecommendations = new FlowLayoutPanel();
            PanelNews = new Panel();
            flowNews = new FlowLayoutPanel();
            PanelBanner = new Panel();
            PictureBox = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            PanelNews.SuspendLayout();
            PanelBanner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(875, 45);
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(875, 45);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.WhiteSmoke;
            btnProfile.Location = new Point(703, 2);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(169, 41);
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
            btnNews.Location = new Point(528, 2);
            btnNews.Margin = new Padding(3, 2, 3, 2);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(169, 41);
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
            btnReview.Location = new Point(353, 2);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(169, 41);
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
            btnFavorite.Location = new Point(178, 2);
            btnFavorite.Margin = new Padding(3, 2, 3, 2);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(169, 41);
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
            btnLibrary.Location = new Point(3, 2);
            btnLibrary.Margin = new Padding(3, 2, 3, 2);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(169, 41);
            btnLibrary.TabIndex = 0;
            btnLibrary.Text = "Бібліотека";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(FlowLayoutPanelRecommendations);
            panel2.Controls.Add(PanelNews);
            panel2.Controls.Add(PanelBanner);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 45);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(875, 663);
            panel2.TabIndex = 1;
            // 
            // FlowLayoutPanelRecommendations
            // 
            FlowLayoutPanelRecommendations.AutoScroll = true;
            FlowLayoutPanelRecommendations.Dock = DockStyle.Fill;
            FlowLayoutPanelRecommendations.FlowDirection = FlowDirection.TopDown;
            FlowLayoutPanelRecommendations.Location = new Point(0, 413);
            FlowLayoutPanelRecommendations.Margin = new Padding(3, 2, 3, 2);
            FlowLayoutPanelRecommendations.Name = "FlowLayoutPanelRecommendations";
            FlowLayoutPanelRecommendations.Padding = new Padding(9, 8, 9, 8);
            FlowLayoutPanelRecommendations.Size = new Size(875, 250);
            FlowLayoutPanelRecommendations.TabIndex = 2;
            FlowLayoutPanelRecommendations.Paint += FlowLayoutPanelRecommendations_Paint;
            // 
            // PanelNews
            // 
            PanelNews.Controls.Add(flowNews);
            PanelNews.Dock = DockStyle.Top;
            PanelNews.Location = new Point(0, 188);
            PanelNews.Margin = new Padding(3, 2, 3, 2);
            PanelNews.Name = "PanelNews";
            PanelNews.Padding = new Padding(9, 8, 9, 8);
            PanelNews.Size = new Size(875, 225);
            PanelNews.TabIndex = 1;
            PanelNews.Paint += PanelNews_Paint;
            // 
            // flowNews
            // 
            flowNews.AutoScroll = true;
            flowNews.Dock = DockStyle.Fill;
            flowNews.FlowDirection = FlowDirection.TopDown;
            flowNews.Location = new Point(9, 8);
            flowNews.Margin = new Padding(3, 2, 3, 2);
            flowNews.Name = "flowNews";
            flowNews.Size = new Size(857, 209);
            flowNews.TabIndex = 0;
            flowNews.WrapContents = false;
            flowNews.Paint += flowNews_Paint;
            // 
            // PanelBanner
            // 
            PanelBanner.BackColor = Color.FromArgb(39, 39, 39);
            PanelBanner.BackgroundImageLayout = ImageLayout.Stretch;
            PanelBanner.Controls.Add(PictureBox);
            PanelBanner.Dock = DockStyle.Top;
            PanelBanner.Location = new Point(0, 0);
            PanelBanner.Margin = new Padding(3, 2, 3, 2);
            PanelBanner.Name = "PanelBanner";
            PanelBanner.Size = new Size(875, 188);
            PanelBanner.TabIndex = 0;
            PanelBanner.Paint += PanelBanner_Paint;
            // 
            // PictureBox
            // 
            PictureBox.Dock = DockStyle.Fill;
            PictureBox.Location = new Point(0, 0);
            PictureBox.Margin = new Padding(3, 2, 3, 2);
            PictureBox.Name = "PictureBox";
            PictureBox.Size = new Size(875, 188);
            PictureBox.TabIndex = 0;
            PictureBox.TabStop = false;
            PictureBox.Click += PictureBox_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(875, 708);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "MainForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            PanelNews.ResumeLayout(false);
            PanelBanner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)PictureBox).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLibrary;
        private Button btnProfile;
        private Button btnNews;
        private Button btnReview;
        private Button btnFavorite;
        private Panel panel2;
        private Panel PanelBanner;
        private PictureBox PictureBox;
        private Panel PanelNews;
        private FlowLayoutPanel flowNews;
        private FlowLayoutPanel FlowLayoutPanelRecommendations;
    }
}