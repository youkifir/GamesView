namespace GamesView.Forms
{
    partial class FormNews
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
            flowNews = new FlowLayoutPanel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1253, 60);
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
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1253, 60);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnFavorite
            // 
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnFavorite.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnFavorite.ForeColor = Color.WhiteSmoke;
            btnFavorite.Location = new Point(253, 3);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(244, 54);
            btnFavorite.TabIndex = 6;
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
            btnProfile.Location = new Point(1003, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(247, 54);
            btnProfile.TabIndex = 5;
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
            btnNews.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnNews.ForeColor = SystemColors.Highlight;
            btnNews.Location = new Point(753, 3);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(244, 54);
            btnNews.TabIndex = 4;
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
            btnReview.Location = new Point(503, 3);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(244, 54);
            btnReview.TabIndex = 3;
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
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLibrary.ForeColor = Color.WhiteSmoke;
            btnLibrary.Location = new Point(3, 3);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(244, 54);
            btnLibrary.TabIndex = 1;
            btnLibrary.Text = "Бібліотека";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // flowNews
            // 
            flowNews.AutoScroll = true;
            flowNews.BackColor = Color.FromArgb(30, 30, 30);
            flowNews.Dock = DockStyle.Fill;
            flowNews.FlowDirection = FlowDirection.TopDown;
            flowNews.Location = new Point(10, 10);
            flowNews.Margin = new Padding(0);
            flowNews.Name = "flowNews";
            flowNews.Size = new Size(1233, 938);
            flowNews.TabIndex = 3;
            flowNews.WrapContents = false;
            this.flowNews.SizeChanged += new System.EventHandler(this.flowNews_SizeChanged);
            // 
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowNews);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1253, 958);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // FormNews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1253, 1018);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormNews";
            Text = "FormNews";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnLibrary;
        private Button btnReview;
        private Button btnNews;
        private Button btnProfile;
        private Button btnFavorite;

        private FlowLayoutPanel flowNews;
        private Panel panel2;
    }
}