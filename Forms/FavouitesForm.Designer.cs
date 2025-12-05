namespace GamesView.Forms
{
    partial class FavouitesForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FavouitesForm));
            panel1 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnFavorite = new Button();
            btnProfile = new Button();
            btnNews = new Button();
            btnReview = new Button();
            btnLibrary = new Button();
            flowFavorites = new FlowLayoutPanel();
            panel2 = new Panel();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            label3 = new Label();
            label4 = new Label();
            pictureBox2 = new PictureBox();
            panel4 = new Panel();
            label5 = new Label();
            label6 = new Label();
            pictureBox3 = new PictureBox();
            panel5 = new Panel();
            label7 = new Label();
            label8 = new Label();
            pictureBox4 = new PictureBox();
            panel6 = new Panel();
            label9 = new Label();
            label10 = new Label();
            pictureBox5 = new PictureBox();
            panel7 = new Panel();
            label11 = new Label();
            label12 = new Label();
            pictureBox6 = new PictureBox();
            panel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            flowFavorites.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(tableLayoutPanel1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1120, 45);
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
            tableLayoutPanel1.Size = new Size(1120, 45);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnFavorite
            // 
            btnFavorite.Dock = DockStyle.Fill;
            btnFavorite.FlatAppearance.BorderColor = Color.FromArgb(63, 81, 181);
            btnFavorite.FlatAppearance.MouseOverBackColor = Color.Red;
            btnFavorite.FlatStyle = FlatStyle.Flat;
            btnFavorite.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            btnFavorite.ForeColor = SystemColors.Highlight;
            btnFavorite.Location = new Point(227, 2);
            btnFavorite.Margin = new Padding(3, 2, 3, 2);
            btnFavorite.Name = "btnFavorite";
            btnFavorite.Size = new Size(218, 41);
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
            btnProfile.Location = new Point(899, 2);
            btnProfile.Margin = new Padding(3, 2, 3, 2);
            btnProfile.Name = "btnProfile";
            btnProfile.Size = new Size(218, 41);
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
            btnNews.Location = new Point(675, 2);
            btnNews.Margin = new Padding(3, 2, 3, 2);
            btnNews.Name = "btnNews";
            btnNews.Size = new Size(218, 41);
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
            btnReview.Location = new Point(451, 2);
            btnReview.Margin = new Padding(3, 2, 3, 2);
            btnReview.Name = "btnReview";
            btnReview.Size = new Size(218, 41);
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
            btnLibrary.Font = new Font("Segoe UI", 12F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            btnLibrary.ForeColor = Color.WhiteSmoke;
            btnLibrary.Location = new Point(3, 2);
            btnLibrary.Margin = new Padding(3, 2, 3, 2);
            btnLibrary.Name = "btnLibrary";
            btnLibrary.Size = new Size(218, 41);
            btnLibrary.TabIndex = 2;
            btnLibrary.Text = "Бібліотека";
            btnLibrary.UseVisualStyleBackColor = true;
            btnLibrary.Click += btnLibrary_Click;
            // 
            // flowFavorites
            // 
            flowFavorites.AutoScroll = true;
            flowFavorites.Controls.Add(panel2);
            flowFavorites.Controls.Add(panel3);
            flowFavorites.Controls.Add(panel4);
            flowFavorites.Controls.Add(panel5);
            flowFavorites.Controls.Add(panel6);
            flowFavorites.Controls.Add(panel7);
            flowFavorites.Dock = DockStyle.Fill;
            flowFavorites.Location = new Point(0, 45);
            flowFavorites.Margin = new Padding(3, 2, 3, 2);
            flowFavorites.Name = "flowFavorites";
            flowFavorites.Padding = new Padding(9, 8, 9, 8);
            flowFavorites.Size = new Size(1120, 557);
            flowFavorites.TabIndex = 1;
            flowFavorites.Paint += flowFavorites_Paint;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(45, 45, 45);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(18, 16);
            panel2.Margin = new Padding(9, 8, 4, 8);
            panel2.Name = "panel2";
            panel2.Size = new Size(263, 300);
            panel2.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Gray;
            label2.Location = new Point(1, 211);
            label2.Name = "label2";
            label2.Size = new Size(234, 57);
            label2.TabIndex = 2;
            label2.Text = "Minecraft — це пісочниця,\r\nде гравець досліджує світ із блоків, \r\nдобуває ресурси, будує та виживає.";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.WhiteSmoke;
            label1.Location = new Point(3, 190);
            label1.Name = "label1";
            label1.Size = new Size(84, 21);
            label1.TabIndex = 1;
            label1.Text = "Minecraft";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.Dock = DockStyle.Top;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Margin = new Padding(3, 2, 3, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 188);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(45, 45, 45);
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label3);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(pictureBox2);
            panel3.Location = new Point(294, 16);
            panel3.Margin = new Padding(9, 8, 4, 8);
            panel3.Name = "panel3";
            panel3.Size = new Size(263, 300);
            panel3.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Gray;
            label3.Location = new Point(1, 211);
            label3.Name = "label3";
            label3.Size = new Size(236, 76);
            label3.TabIndex = 2;
            label3.Text = "Terraria — це пригодницька 2D-гра,\r\nде гравець досліджує світ, добуває \r\nресурси,будує та бореться з\r\nворогами.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.WhiteSmoke;
            label4.Location = new Point(3, 190);
            label4.Name = "label4";
            label4.Size = new Size(68, 21);
            label4.TabIndex = 1;
            label4.Text = "Terraria";
            // 
            // pictureBox2
            // 
            pictureBox2.Dock = DockStyle.Top;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Margin = new Padding(3, 2, 3, 2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(261, 188);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(45, 45, 45);
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(pictureBox3);
            panel4.Location = new Point(570, 16);
            panel4.Margin = new Padding(9, 8, 4, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(263, 300);
            panel4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Gray;
            label5.Location = new Point(1, 211);
            label5.Name = "label5";
            label5.Size = new Size(242, 95);
            label5.TabIndex = 2;
            label5.Text = "Відьмак — це рольова гра, де герой \r\nҐеральт проходить пригоди,\r\nбореться з чудовиськами та\r\nробить вибір,що впливає на \r\nсюжет.";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.WhiteSmoke;
            label6.Location = new Point(3, 190);
            label6.Name = "label6";
            label6.Size = new Size(206, 21);
            label6.TabIndex = 1;
            label6.Text = "The witcher 3 : Wild Hunt ";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Top;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Margin = new Padding(3, 2, 3, 2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(261, 188);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 0;
            pictureBox3.TabStop = false;
            // 
            // panel5
            // 
            panel5.BackColor = Color.FromArgb(45, 45, 45);
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(label7);
            panel5.Controls.Add(label8);
            panel5.Controls.Add(pictureBox4);
            panel5.Location = new Point(18, 332);
            panel5.Margin = new Padding(9, 8, 4, 8);
            panel5.Name = "panel5";
            panel5.Size = new Size(263, 300);
            panel5.TabIndex = 3;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Gray;
            label7.Location = new Point(1, 211);
            label7.Name = "label7";
            label7.Size = new Size(232, 95);
            label7.TabIndex = 2;
            label7.Text = "Resident Evil 4 — це екшн-горор,\r\nде Леон Кеннеді рятує викрадену\r\nдівчину,борючись із зараженими\r\nворогами в напруженій атмосфері \r\nвиживання.";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.WhiteSmoke;
            label8.Location = new Point(3, 190);
            label8.Name = "label8";
            label8.Size = new Size(121, 21);
            label8.TabIndex = 1;
            label8.Text = "Resident Evil 4";
            // 
            // pictureBox4
            // 
            pictureBox4.Dock = DockStyle.Top;
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(0, 0);
            pictureBox4.Margin = new Padding(3, 2, 3, 2);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(261, 188);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 0;
            pictureBox4.TabStop = false;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(45, 45, 45);
            panel6.BorderStyle = BorderStyle.FixedSingle;
            panel6.Controls.Add(label9);
            panel6.Controls.Add(label10);
            panel6.Controls.Add(pictureBox5);
            panel6.Location = new Point(294, 332);
            panel6.Margin = new Padding(9, 8, 4, 8);
            panel6.Name = "panel6";
            panel6.Size = new Size(263, 300);
            panel6.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 10F);
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(1, 211);
            label9.Name = "label9";
            label9.Size = new Size(209, 95);
            label9.TabIndex = 2;
            label9.Text = "The Sims 4 — це гра-симулятор\r\nжиття,де гравець створює\r\nперсонажів,будує будинки\r\nй керує їхнім повсякденним\r\nжиттям.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.WhiteSmoke;
            label10.Location = new Point(3, 190);
            label10.Name = "label10";
            label10.Size = new Size(91, 21);
            label10.TabIndex = 1;
            label10.Text = "The Sims 4";
            // 
            // pictureBox5
            // 
            pictureBox5.Dock = DockStyle.Top;
            pictureBox5.Image = (Image)resources.GetObject("pictureBox5.Image");
            pictureBox5.Location = new Point(0, 0);
            pictureBox5.Margin = new Padding(3, 2, 3, 2);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(261, 188);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // panel7
            // 
            panel7.BackColor = Color.FromArgb(45, 45, 45);
            panel7.BorderStyle = BorderStyle.FixedSingle;
            panel7.Controls.Add(label11);
            panel7.Controls.Add(label12);
            panel7.Controls.Add(pictureBox6);
            panel7.Location = new Point(570, 332);
            panel7.Margin = new Padding(9, 8, 4, 8);
            panel7.Name = "panel7";
            panel7.Size = new Size(263, 300);
            panel7.TabIndex = 5;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 10F);
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(1, 211);
            label11.Name = "label11";
            label11.Size = new Size(229, 76);
            label11.TabIndex = 2;
            label11.Text = "God of War — це екшн-гра,\r\nде Кратос разом із сином вирушає\r\n у небезпечну подорож у світі \r\nскандинавської міфології.";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.WhiteSmoke;
            label12.Location = new Point(3, 190);
            label12.Name = "label12";
            label12.Size = new Size(95, 21);
            label12.TabIndex = 1;
            label12.Text = "God of War";
            // 
            // pictureBox6
            // 
            pictureBox6.Dock = DockStyle.Top;
            pictureBox6.Image = (Image)resources.GetObject("pictureBox6.Image");
            pictureBox6.Location = new Point(0, 0);
            pictureBox6.Margin = new Padding(3, 2, 3, 2);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(261, 188);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 0;
            pictureBox6.TabStop = false;
            // 
            // FavouitesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(30, 30, 30);
            ClientSize = new Size(1120, 602);
            Controls.Add(flowFavorites);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FavouitesForm";
            Text = "FavouitesForm";
            panel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            flowFavorites.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
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
        private FlowLayoutPanel flowFavorites;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Panel panel3;
        private Label label3;
        private Label label4;
        private PictureBox pictureBox2;
        private Panel panel4;
        private Label label5;
        private Label label6;
        private PictureBox pictureBox3;
        private Panel panel5;
        private Label label7;
        private Label label8;
        private PictureBox pictureBox4;
        private Panel panel6;
        private Label label9;
        private Label label10;
        private PictureBox pictureBox5;
        private Panel panel7;
        private Label label11;
        private Label label12;
        private PictureBox pictureBox6;
    }
}