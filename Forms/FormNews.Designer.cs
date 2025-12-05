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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormNews));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnFavorite = new Button();
            btnProfile = new Button();
            btnNews = new Button();
            btnReview = new Button();
            btnLibrary = new Button();
            panel2 = new Panel();
            flowNews = new FlowLayoutPanel();
            panel5 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel4 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            // panel2
            // 
            panel2.AutoScroll = true;
            panel2.Controls.Add(flowNews);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Margin = new Padding(10);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(1253, 958);
            panel2.TabIndex = 1;
            panel2.Paint += panel2_Paint;
            // 
            // flowNews
            // 
            flowNews.AutoScroll = true;
            flowNews.BackColor = Color.FromArgb(30, 30, 30);
            flowNews.Dock = DockStyle.Bottom;
            flowNews.FlowDirection = FlowDirection.TopDown;
            flowNews.Location = new Point(10, 731);
            flowNews.Margin = new Padding(0);
            flowNews.Name = "flowNews";
            flowNews.Size = new Size(1233, 217);
            flowNews.TabIndex = 3;
            flowNews.WrapContents = false;
            // 
            // panel5
            // 
            panel5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(pictureBox3);
            panel5.Location = new Point(10, 483);
            panel5.Margin = new Padding(5);
            panel5.Name = "panel5";
            panel5.Size = new Size(1233, 217);
            panel5.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(247, 53);
            label5.Name = "label5";
            label5.Size = new Size(1637, 80);
            label5.TabIndex = 2;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(247, 9);
            label6.Name = "label6";
            label6.Size = new Size(441, 28);
            label6.TabIndex = 1;
            label6.Text = "Новий сезон у PUBG — «Битва за острови»";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Left;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(241, 217);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            panel4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(pictureBox2);
            panel4.Location = new Point(10, 246);
            panel4.Margin = new Padding(5);
            panel4.Name = "panel4";
            panel4.Size = new Size(1233, 217);
            panel4.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.FromArgb(224, 224, 224);
            label3.Location = new Point(247, 53);
            label3.Name = "label3";
            label3.Size = new Size(1375, 80);
            label3.TabIndex = 2;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(247, 9);
            label4.Name = "label4";
            label4.Size = new Size(493, 28);
            label4.TabIndex = 1;
            label4.Text = "Велике оновлення для Rust — «Ера виживання»";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Left;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(241, 217);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 45);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Controls.Add(pictureBox1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(10, 10);
            panel3.Margin = new Padding(5);
            panel3.Name = "panel3";
            panel3.Size = new Size(1233, 217);
            panel3.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(247, 53);
            label2.Name = "label2";
            label2.Size = new Size(1624, 60);
            label2.TabIndex = 2;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(247, 9);
            label1.Name = "label1";
            label1.Size = new Size(693, 28);
            label1.TabIndex = 1;
            label1.Text = "Нова оновлена версія для Counter‑Strike 2 — «Операція: Нова Зоря»";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(241, 217);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
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
            Load += FormNews_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Panel panel2;
        private Panel panel3;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private Panel panel4;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel5;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private FlowLayoutPanel flowNews;
    }
}