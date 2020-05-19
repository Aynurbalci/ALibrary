namespace ALibrary
{
    partial class LibraryBook
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textBox_BookTitlee = new System.Windows.Forms.TextBox();
            this.dataGridView_GettingBooks = new System.Windows.Forms.DataGridView();
            this.button_Search = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView_MyBooks = new System.Windows.Forms.DataGridView();
            this.button_Update = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_BarkodNo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_BookTitle = new System.Windows.Forms.TextBox();
            this.button_All = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_NumberOfPages = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Piece = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox_Category = new System.Windows.Forms.ComboBox();
            this.textBox_AuthorName = new System.Windows.Forms.TextBox();
            this.comboBox_Language = new System.Windows.Forms.ComboBox();
            this.textBox_PublicationYear = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView_BooksInTheLibrary = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.comboBox_Categoryy = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.textBox_AuthorNamee = new System.Windows.Forms.TextBox();
            this.comboBox_Languagee = new System.Windows.Forms.ComboBox();
            this.label19 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GettingBooks)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyBooks)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BooksInTheLibrary)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 355);
            this.tabControl1.MinimumSize = new System.Drawing.Size(1000, 600);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1500, 945);
            this.tabControl1.TabIndex = 2;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.BackgroundImage = global::ALibrary.Properties.Resources.e0e96dd47c7b17d3e7bbb621f49d9db21;
            this.tabPage1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage1.Controls.Add(this.panel3);
            this.tabPage1.Controls.Add(this.dataGridView_GettingBooks);
            this.tabPage1.Controls.Add(this.button_Search);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1484, 898);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Getting Books";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel3.Controls.Add(this.comboBox_Categoryy);
            this.panel3.Controls.Add(this.comboBox_Languagee);
            this.panel3.Controls.Add(this.textBox_BookTitlee);
            this.panel3.Controls.Add(this.textBox_AuthorNamee);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(506, 368);
            this.panel3.TabIndex = 20;
            // 
            // textBox_BookTitlee
            // 
            this.textBox_BookTitlee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BookTitlee.Location = new System.Drawing.Point(231, 52);
            this.textBox_BookTitlee.Name = "textBox_BookTitlee";
            this.textBox_BookTitlee.Size = new System.Drawing.Size(224, 24);
            this.textBox_BookTitlee.TabIndex = 16;
            // 
            // dataGridView_GettingBooks
            // 
            this.dataGridView_GettingBooks.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView_GettingBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_GettingBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_GettingBooks.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView_GettingBooks.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView_GettingBooks.GridColor = System.Drawing.Color.Maroon;
            this.dataGridView_GettingBooks.Location = new System.Drawing.Point(3, 371);
            this.dataGridView_GettingBooks.Name = "dataGridView_GettingBooks";
            this.dataGridView_GettingBooks.RowHeadersWidth = 82;
            this.dataGridView_GettingBooks.RowTemplate.Height = 33;
            this.dataGridView_GettingBooks.Size = new System.Drawing.Size(1478, 524);
            this.dataGridView_GettingBooks.TabIndex = 1;
            // 
            // button_Search
            // 
            this.button_Search.BackgroundImage = global::ALibrary.Properties.Resources.Start_Menu_Search_icon;
            this.button_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Search.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Search.Location = new System.Drawing.Point(645, 99);
            this.button_Search.Name = "button_Search";
            this.button_Search.Size = new System.Drawing.Size(122, 112);
            this.button_Search.TabIndex = 2;
            this.button_Search.UseVisualStyleBackColor = true;
            this.button_Search.Click += new System.EventHandler(this.button_Search_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Maroon;
            this.tabPage2.BackgroundImage = global::ALibrary.Properties.Resources.yildizlarin_sesi_3_stR6_cover;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.dataGridView_MyBooks);
            this.tabPage2.Controls.Add(this.button_Update);
            this.tabPage2.Controls.Add(this.button_Delete);
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1484, 898);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "My Books";
            // 
            // dataGridView_MyBooks
            // 
            this.dataGridView_MyBooks.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.dataGridView_MyBooks.BackgroundColor = System.Drawing.Color.Maroon;
            this.dataGridView_MyBooks.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView_MyBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_MyBooks.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView_MyBooks.Location = new System.Drawing.Point(477, 3);
            this.dataGridView_MyBooks.Name = "dataGridView_MyBooks";
            this.dataGridView_MyBooks.RowHeadersWidth = 82;
            this.dataGridView_MyBooks.RowTemplate.Height = 33;
            this.dataGridView_MyBooks.Size = new System.Drawing.Size(1004, 892);
            this.dataGridView_MyBooks.TabIndex = 0;
            // 
            // button_Update
            // 
            this.button_Update.BackColor = System.Drawing.Color.Transparent;
            this.button_Update.BackgroundImage = global::ALibrary.Properties.Resources.Actions_edit_clear_history_icon;
            this.button_Update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Update.Location = new System.Drawing.Point(89, 641);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(162, 156);
            this.button_Update.TabIndex = 2;
            this.button_Update.UseVisualStyleBackColor = false;
            // 
            // button_Delete
            // 
            this.button_Delete.BackColor = System.Drawing.Color.Transparent;
            this.button_Delete.BackgroundImage = global::ALibrary.Properties.Resources.Actions_edit_clear_icon;
            this.button_Delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_Delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_Delete.Location = new System.Drawing.Point(89, 186);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(162, 156);
            this.button_Delete.TabIndex = 1;
            this.button_Delete.UseVisualStyleBackColor = false;
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::ALibrary.Properties.Resources.f_9OkjLek4Qjyy9NxIZ5XchlVF4_400x346;
            this.tabPage3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Controls.Add(this.pictureBox1);
            this.tabPage3.Location = new System.Drawing.Point(8, 39);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1484, 898);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Donate Books";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBox_BarkodNo);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.textBox_BookTitle);
            this.panel1.Controls.Add(this.button_All);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.textBox_NumberOfPages);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textBox_Piece);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.comboBox_Category);
            this.panel1.Controls.Add(this.textBox_AuthorName);
            this.panel1.Controls.Add(this.comboBox_Language);
            this.panel1.Controls.Add(this.textBox_PublicationYear);
            this.panel1.Location = new System.Drawing.Point(46, 59);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(579, 776);
            this.panel1.TabIndex = 30;
            // 
            // textBox_BarkodNo
            // 
            this.textBox_BarkodNo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BarkodNo.Location = new System.Drawing.Point(260, 484);
            this.textBox_BarkodNo.Name = "textBox_BarkodNo";
            this.textBox_BarkodNo.Size = new System.Drawing.Size(242, 24);
            this.textBox_BarkodNo.TabIndex = 31;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(30, 483);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(182, 25);
            this.label10.TabIndex = 30;
            this.label10.Text = "Number Of Pages";
            // 
            // textBox_BookTitle
            // 
            this.textBox_BookTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_BookTitle.Location = new System.Drawing.Point(260, 22);
            this.textBox_BookTitle.Name = "textBox_BookTitle";
            this.textBox_BookTitle.Size = new System.Drawing.Size(242, 24);
            this.textBox_BookTitle.TabIndex = 22;
            // 
            // button_All
            // 
            this.button_All.BackgroundImage = global::ALibrary.Properties.Resources.Folder_Add_icon;
            this.button_All.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button_All.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_All.Location = new System.Drawing.Point(222, 642);
            this.button_All.Name = "button_All";
            this.button_All.Size = new System.Drawing.Size(113, 107);
            this.button_All.TabIndex = 29;
            this.button_All.UseVisualStyleBackColor = true;
            this.button_All.Click += new System.EventHandler(this.button_All_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 15;
            this.label1.Text = "Book Title";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 415);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 25);
            this.label7.TabIndex = 21;
            this.label7.Text = "Number Of Pages";
            // 
            // textBox_NumberOfPages
            // 
            this.textBox_NumberOfPages.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_NumberOfPages.Location = new System.Drawing.Point(260, 412);
            this.textBox_NumberOfPages.Name = "textBox_NumberOfPages";
            this.textBox_NumberOfPages.Size = new System.Drawing.Size(242, 24);
            this.textBox_NumberOfPages.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(30, 356);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 20;
            this.label6.Text = "Piece";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(30, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 16;
            this.label2.Text = "Author Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(30, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 25);
            this.label5.TabIndex = 19;
            this.label5.Text = "Category";
            // 
            // textBox_Piece
            // 
            this.textBox_Piece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_Piece.Location = new System.Drawing.Point(260, 353);
            this.textBox_Piece.Name = "textBox_Piece";
            this.textBox_Piece.Size = new System.Drawing.Size(242, 24);
            this.textBox_Piece.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(30, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 25);
            this.label4.TabIndex = 18;
            this.label4.Text = "Language";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(30, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 25);
            this.label3.TabIndex = 17;
            this.label3.Text = "Publication Year";
            // 
            // comboBox_Category
            // 
            this.comboBox_Category.FormattingEnabled = true;
            this.comboBox_Category.Location = new System.Drawing.Point(260, 287);
            this.comboBox_Category.Name = "comboBox_Category";
            this.comboBox_Category.Size = new System.Drawing.Size(242, 33);
            this.comboBox_Category.TabIndex = 26;
            // 
            // textBox_AuthorName
            // 
            this.textBox_AuthorName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorName.Location = new System.Drawing.Point(260, 86);
            this.textBox_AuthorName.Name = "textBox_AuthorName";
            this.textBox_AuthorName.Size = new System.Drawing.Size(242, 24);
            this.textBox_AuthorName.TabIndex = 23;
            // 
            // comboBox_Language
            // 
            this.comboBox_Language.FormattingEnabled = true;
            this.comboBox_Language.Location = new System.Drawing.Point(260, 221);
            this.comboBox_Language.Name = "comboBox_Language";
            this.comboBox_Language.Size = new System.Drawing.Size(242, 33);
            this.comboBox_Language.TabIndex = 25;
            // 
            // textBox_PublicationYear
            // 
            this.textBox_PublicationYear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_PublicationYear.Location = new System.Drawing.Point(260, 152);
            this.textBox_PublicationYear.Name = "textBox_PublicationYear";
            this.textBox_PublicationYear.Size = new System.Drawing.Size(242, 24);
            this.textBox_PublicationYear.TabIndex = 24;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ALibrary.Properties.Resources.f_9OkjLek4Qjyy9NxIZ5XchlVF4_400x3461;
            this.pictureBox1.Location = new System.Drawing.Point(-26, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1484, 1050);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView_BooksInTheLibrary);
            this.tabPage4.Location = new System.Drawing.Point(8, 39);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1484, 898);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Books In The Library";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView_BooksInTheLibrary
            // 
            this.dataGridView_BooksInTheLibrary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_BooksInTheLibrary.Location = new System.Drawing.Point(3, 3);
            this.dataGridView_BooksInTheLibrary.Name = "dataGridView_BooksInTheLibrary";
            this.dataGridView_BooksInTheLibrary.RowHeadersWidth = 82;
            this.dataGridView_BooksInTheLibrary.RowTemplate.Height = 33;
            this.dataGridView_BooksInTheLibrary.Size = new System.Drawing.Size(1435, 1038);
            this.dataGridView_BooksInTheLibrary.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1500, 349);
            this.panel2.TabIndex = 21;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::ALibrary.Properties.Resources._62963_crossed_swords_icon1;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(1348, 66);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 90);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(285, 349);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.BackgroundImage = global::ALibrary.Properties.Resources.Peters_Sword_icon;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Location = new System.Drawing.Point(1187, 66);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 90);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(26, 58);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(108, 25);
            this.label15.TabIndex = 4;
            this.label15.Text = "Book Title";
            // 
            // comboBox_Categoryy
            // 
            this.comboBox_Categoryy.FormattingEnabled = true;
            this.comboBox_Categoryy.Location = new System.Drawing.Point(231, 169);
            this.comboBox_Categoryy.Name = "comboBox_Categoryy";
            this.comboBox_Categoryy.Size = new System.Drawing.Size(224, 33);
            this.comboBox_Categoryy.TabIndex = 17;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(26, 235);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(137, 25);
            this.label18.TabIndex = 10;
            this.label18.Text = "Author Name";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(26, 116);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(108, 25);
            this.label16.TabIndex = 6;
            this.label16.Text = "Language";
            // 
            // textBox_AuthorNamee
            // 
            this.textBox_AuthorNamee.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox_AuthorNamee.Location = new System.Drawing.Point(231, 235);
            this.textBox_AuthorNamee.Name = "textBox_AuthorNamee";
            this.textBox_AuthorNamee.Size = new System.Drawing.Size(224, 24);
            this.textBox_AuthorNamee.TabIndex = 12;
            // 
            // comboBox_Languagee
            // 
            this.comboBox_Languagee.FormattingEnabled = true;
            this.comboBox_Languagee.Location = new System.Drawing.Point(231, 108);
            this.comboBox_Languagee.Name = "comboBox_Languagee";
            this.comboBox_Languagee.Size = new System.Drawing.Size(224, 33);
            this.comboBox_Languagee.TabIndex = 0;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(26, 177);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(99, 25);
            this.label19.TabIndex = 7;
            this.label19.Text = "Category";
            // 
            // LibraryBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1500, 1300);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1500, 1300);
            this.Name = "LibraryBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LibraryBook";
            this.Load += new System.EventHandler(this.LibraryBook_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.LibraryBook_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.LibraryBook_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.LibraryBook_MouseUp);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_GettingBooks)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_MyBooks)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_BooksInTheLibrary)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView_MyBooks;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView_BooksInTheLibrary;
        private System.Windows.Forms.DataGridView dataGridView_GettingBooks;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_All;
        private System.Windows.Forms.TextBox textBox_NumberOfPages;
        private System.Windows.Forms.TextBox textBox_Piece;
        private System.Windows.Forms.ComboBox comboBox_Category;
        private System.Windows.Forms.ComboBox comboBox_Language;
        private System.Windows.Forms.TextBox textBox_PublicationYear;
        private System.Windows.Forms.TextBox textBox_AuthorName;
        private System.Windows.Forms.TextBox textBox_BookTitle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox textBox_BookTitlee;
        private System.Windows.Forms.Button button_Search;
        private System.Windows.Forms.TextBox textBox_BarkodNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox comboBox_Categoryy;
        private System.Windows.Forms.ComboBox comboBox_Languagee;
        private System.Windows.Forms.TextBox textBox_AuthorNamee;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
    }
}