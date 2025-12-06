namespace GamesView.Forms
{
    partial class FormAddNews
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
            btnAddGame = new Button();
            panel2 = new Panel();
            panel4 = new Panel();
            flowPreviewNews = new FlowLayoutPanel();
            button2 = new Button();
            txtContent = new TextBox();
            label4 = new Label();
            txtTitle = new TextBox();
            label2 = new Label();
            button1 = new Button();
            pictureBoxPreview = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1445, 60);
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
            tableLayoutPanel1.Controls.Add(btnAddGame, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1445, 60);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // btnProfile
            // 
            btnProfile.Dock = DockStyle.Fill;
            btnProfile.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnProfile.FlatAppearance.MouseOverBackColor = Color.Red;
            btnProfile.FlatStyle = FlatStyle.Flat;
            btnProfile.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnProfile.ForeColor = Color.WhiteSmoke;
            btnProfile.Location = new Point(1159, 3);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(283, 54);
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
            btnNews.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnNews.ForeColor = SystemColors.Highlight;
            btnNews.Location = new Point(870, 3);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(283, 54);
            btnNews.TabIndex = 3;
            btnNews.Text = "Додати новини";
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
            btnReview.Location = new Point(581, 3);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(283, 54);
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
            btnFavorite.Location = new Point(292, 3);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(283, 54);
            btnFavorite.TabIndex = 1;
            btnFavorite.Text = "Улюблені ігри";
            btnFavorite.UseVisualStyleBackColor = true;
            btnFavorite.Click += btnFavorite_Click;
            // 
            // btnAddGame
            // 
            btnAddGame.Dock = DockStyle.Fill;
            btnAddGame.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnAddGame.FlatAppearance.MouseOverBackColor = Color.Red;
            btnAddGame.FlatStyle = FlatStyle.Flat;
            btnAddGame.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnAddGame.ForeColor = Color.WhiteSmoke;
            btnAddGame.Location = new Point(3, 3);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(283, 54);
            btnAddGame.TabIndex = 0;
            btnAddGame.Text = "Додати Гру";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += btnAddGame_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 60);
            panel2.Margin = new Padding(10, 11, 10, 11);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(16);
            panel2.Size = new Size(1445, 727);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.Controls.Add(flowPreviewNews);
            panel4.Controls.Add(button2);
            panel4.Controls.Add(txtContent);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(txtTitle);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(pictureBoxPreview);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(16, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(1413, 644);
            panel4.TabIndex = 2;
            panel4.Paint += panel4_Paint;
            // 
            // flowPreviewNews
            // 
            flowPreviewNews.AutoScroll = true;
            flowPreviewNews.BackColor = Color.FromArgb(40, 40, 40);
            flowPreviewNews.Dock = DockStyle.Bottom;
            flowPreviewNews.Location = new Point(0, 404);
            flowPreviewNews.Name = "flowPreviewNews";
            flowPreviewNews.Size = new Size(1413, 240);
            flowPreviewNews.TabIndex = 12;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.Lime;
            button2.Cursor = Cursors.Hand;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(1127, 160);
            button2.Name = "button2";
            button2.Size = new Size(284, 39);
            button2.TabIndex = 11;
            button2.Text = "Додати новину";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnAddNews_Click;
            // 
            // txtContent
            // 
            txtContent.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtContent.Location = new Point(571, 112);
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(839, 27);
            txtContent.TabIndex = 7;
            txtContent.TextChanged += textBox2_TextChanged;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(427, 111);
            label4.Name = "label4";
            label4.Size = new Size(137, 25);
            label4.TabIndex = 6;
            label4.Text = "Опис новини :";
            // 
            // txtTitle
            // 
            txtTitle.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtTitle.Location = new Point(547, 53);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(863, 27);
            txtTitle.TabIndex = 3;
            txtTitle.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(427, 53);
            label2.Name = "label2";
            label2.Size = new Size(113, 25);
            label2.TabIndex = 2;
            label2.Text = "Заголовок :";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(3, 5);
            button1.Name = "button1";
            button1.Size = new Size(403, 35);
            button1.TabIndex = 1;
            button1.Text = "Обрати фото";
            button1.UseVisualStyleBackColor = true;
            button1.Click += btnSelectPhoto_Click;
            // 
            // pictureBoxPreview
            // 
            pictureBoxPreview.BackColor = Color.FromArgb(50, 50, 50);
            pictureBoxPreview.Location = new Point(3, 53);
            pictureBoxPreview.Name = "pictureBoxPreview";
            pictureBoxPreview.Size = new Size(403, 449);
            pictureBoxPreview.TabIndex = 0;
            pictureBoxPreview.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(16, 16);
            panel3.Name = "panel3";
            panel3.Size = new Size(1413, 51);
            panel3.TabIndex = 1;
            panel3.Paint += panel3_Paint;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(715, 0);
            label1.Name = "label1";
            label1.Size = new Size(241, 41);
            label1.TabIndex = 0;
            label1.Text = "Додати новину";
            // 
            // FormAddNews
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1445, 787);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormAddNews";
            Text = "FormAddNews";
            Load += FormAddNews_Load;
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPreview).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnProfile;
        private Button btnNews;
        private Button btnReview;
        private Button btnFavorite;
        private Button btnAddGame;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private TextBox txtContent;
        private Label label4;
        private TextBox txtTitle;
        private Label label2;
        private Button button1;
        private PictureBox pictureBoxPreview;
        private Button button2;
        private FlowLayoutPanel flowPreviewNews;
    }
}