namespace GamesView.Forms
{
    partial class FormAddGame
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
            btnAdd = new Button();
            tbDescribe = new TextBox();
            label4 = new Label();
            cbCategory = new ComboBox();
            label3 = new Label();
            tbGameName = new TextBox();
            label2 = new Label();
            btnChooseImage = new Button();
            pbImage = new PictureBox();
            panel3 = new Panel();
            label1 = new Label();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).BeginInit();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1152, 45);
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
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(1152, 45);
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
            btnProfile.Location = new Point(923, 2);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(226, 41);
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
            btnNews.Location = new Point(693, 2);
            btnNews.Margin = new Padding(3, 2, 3, 2);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(224, 41);
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
            btnReview.Location = new Point(463, 2);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(224, 41);
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
            btnFavorite.Location = new Point(233, 2);
            btnFavorite.Margin = new Padding(3, 2, 3, 2);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(224, 41);
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
            btnAddGame.Location = new Point(3, 2);
            btnAddGame.Margin = new Padding(3, 2, 3, 2);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(224, 41);
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
            panel2.Location = new Point(0, 45);
            panel2.Margin = new Padding(9, 8, 9, 8);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(14, 12, 14, 12);
            panel2.Size = new Size(1152, 592);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.Controls.Add(btnAdd);
            panel4.Controls.Add(tbDescribe);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(cbCategory);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(tbGameName);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(btnChooseImage);
            panel4.Controls.Add(pbImage);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(14, 50);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(1124, 530);
            panel4.TabIndex = 1;
            // 
            // btnAdd
            // 
            btnAdd.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnAdd.BackColor = Color.Lime;
            btnAdd.Cursor = Cursors.Hand;
            btnAdd.FlatAppearance.BorderSize = 0;
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAdd.Location = new Point(966, 182);
            btnAdd.Margin = new Padding(3, 2, 3, 2);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(144, 29);
            btnAdd.TabIndex = 10;
            btnAdd.Text = "Додати гру";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
            // 
            // tbDescribe
            // 
            tbDescribe.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbDescribe.Location = new Point(475, 147);
            tbDescribe.Margin = new Padding(3, 2, 3, 2);
            tbDescribe.Name = "tbDescribe";
            tbDescribe.Size = new Size(635, 23);
            tbDescribe.TabIndex = 7;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(374, 146);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 6;
            label4.Text = "Опис гри :";
            // 
            // cbCategory
            // 
            cbCategory.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            cbCategory.FormattingEnabled = true;
            cbCategory.Items.AddRange(new object[] { "Хоррор", "Одиночна гра", "Інтерактивне кіно" });
            cbCategory.Location = new Point(475, 91);
            cbCategory.Margin = new Padding(3, 2, 3, 2);
            cbCategory.Name = "cbCategory";
            cbCategory.Size = new Size(635, 23);
            cbCategory.TabIndex = 5;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(374, 90);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 4;
            label3.Text = "Категорія :";
            // 
            // tbGameName
            // 
            tbGameName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbGameName.Location = new Point(475, 40);
            tbGameName.Margin = new Padding(3, 2, 3, 2);
            tbGameName.Name = "tbGameName";
            tbGameName.Size = new Size(635, 23);
            tbGameName.TabIndex = 3;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(374, 40);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 2;
            label2.Text = "Назва гри :";
            // 
            // btnChooseImage
            // 
            btnChooseImage.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChooseImage.Location = new Point(3, 4);
            btnChooseImage.Margin = new Padding(3, 2, 3, 2);
            btnChooseImage.Name = "btnChooseImage";
            btnChooseImage.Size = new Size(353, 26);
            btnChooseImage.TabIndex = 1;
            btnChooseImage.Text = "Обрати фото";
            btnChooseImage.UseVisualStyleBackColor = true;
            btnChooseImage.Click += btnChooseImage_Click;
            // 
            // pbImage
            // 
            pbImage.BackColor = Color.FromArgb(50, 50, 50);
            pbImage.Location = new Point(3, 40);
            pbImage.Margin = new Padding(3, 2, 3, 2);
            pbImage.Name = "pbImage";
            pbImage.Size = new Size(353, 337);
            pbImage.TabIndex = 0;
            pbImage.TabStop = false;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(14, 12);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(1124, 38);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(729, 0);
            label1.Name = "label1";
            label1.Size = new Size(211, 32);
            label1.TabIndex = 0;
            label1.Text = "Додати нову гру";
            // 
            // FormAddGame
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1152, 637);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FormAddGame";
            Text = "MainForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbImage).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnAddGame;
        private Button btnProfile;
        private Button btnNews;
        private Button btnReview;
        private Button btnFavorite;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel4;
        private PictureBox pbImage;
        private Button btnChooseImage;
        private Label label2;
        private TextBox tbDescribe;
        private Label label4;
        private ComboBox cbCategory;
        private Label label3;
        private TextBox tbGameName;
        private Button btnAdd;
    }
}