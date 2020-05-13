namespace ALibrary
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_HomePage = new System.Windows.Forms.TabPage();
            this.button4 = new System.Windows.Forms.Button();
            this.ımageList3 = new System.Windows.Forms.ImageList(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage_AboutUs = new System.Windows.Forms.TabPage();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage_OurServices = new System.Windows.Forms.TabPage();
            this.tabPage_OurActivities = new System.Windows.Forms.TabPage();
            this.tabPage_Contact = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage_HomePage.SuspendLayout();
            this.tabPage_AboutUs.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MV Boli", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Maroon;
            this.label1.Location = new System.Drawing.Point(399, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(635, 167);
            this.label1.TabIndex = 2;
            this.label1.Text = "A-Library";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_HomePage);
            this.tabControl1.Controls.Add(this.tabPage_AboutUs);
            this.tabControl1.Controls.Add(this.tabPage_OurServices);
            this.tabControl1.Controls.Add(this.tabPage_OurActivities);
            this.tabControl1.Controls.Add(this.tabPage_Contact);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 315);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1494, 1351);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage_HomePage
            // 
            this.tabPage_HomePage.BackColor = System.Drawing.Color.Transparent;
            this.tabPage_HomePage.BackgroundImage = global::ALibrary.Properties.Resources.misir_uygarligi1;
            this.tabPage_HomePage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage_HomePage.Controls.Add(this.button4);
            this.tabPage_HomePage.Controls.Add(this.label10);
            this.tabPage_HomePage.Controls.Add(this.label9);
            this.tabPage_HomePage.Controls.Add(this.label8);
            this.tabPage_HomePage.Controls.Add(this.button3);
            this.tabPage_HomePage.Controls.Add(this.label7);
            this.tabPage_HomePage.Controls.Add(this.label6);
            this.tabPage_HomePage.Controls.Add(this.label5);
            this.tabPage_HomePage.Controls.Add(this.label4);
            this.tabPage_HomePage.Controls.Add(this.label3);
            this.tabPage_HomePage.Controls.Add(this.label2);
            this.tabPage_HomePage.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.tabPage_HomePage.Location = new System.Drawing.Point(8, 39);
            this.tabPage_HomePage.Name = "tabPage_HomePage";
            this.tabPage_HomePage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_HomePage.Size = new System.Drawing.Size(1478, 1304);
            this.tabPage_HomePage.TabIndex = 0;
            this.tabPage_HomePage.Text = "Home Page";
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ALibrary.Properties.Resources.admin_privilege_icon;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.ForeColor = System.Drawing.Color.Firebrick;
            this.button4.ImageKey = "(none)";
            this.button4.ImageList = this.ımageList3;
            this.button4.Location = new System.Drawing.Point(24, 800);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(162, 156);
            this.button4.TabIndex = 15;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // ımageList3
            // 
            this.ımageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList3.ImageStream")));
            this.ımageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList3.Images.SetKeyName(0, "Actions-user-group-new-icon.png");
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe Script", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label10.Location = new System.Drawing.Point(517, 1163);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(386, 71);
            this.label10.TabIndex = 13;
            this.label10.Text = "Albert Einstein";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe Script", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.label9.Location = new System.Drawing.Point(369, 1047);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(644, 71);
            this.label9.TabIndex = 12;
            this.label9.Text = "important than knowledge";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe Script", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(448, 932);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(517, 71);
            this.label8.TabIndex = 11;
            this.label8.Text = "imagination is more ";
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ALibrary.Properties.Resources.Actions_user_group_new_icon;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.ForeColor = System.Drawing.Color.Firebrick;
            this.button3.ImageKey = "(none)";
            this.button3.ImageList = this.ımageList3;
            this.button3.Location = new System.Drawing.Point(1239, 776);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(162, 156);
            this.button3.TabIndex = 10;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("MV Boli", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Yellow;
            this.label7.Location = new System.Drawing.Point(1226, 710);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 63);
            this.label7.TabIndex = 8;
            this.label7.Text = "Sign up";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("MV Boli", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(13, 710);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 63);
            this.label6.TabIndex = 7;
            this.label6.Text = "Sign in";
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Chocolate;
            this.label5.Location = new System.Drawing.Point(926, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(493, 61);
            this.label5.TabIndex = 6;
            this.label5.Text = "Everythink is here...";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Chocolate;
            this.label4.Location = new System.Drawing.Point(49, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(1260, 61);
            this.label4.TabIndex = 5;
            this.label4.Text = "Need to search for books, articles, or other materials?";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Orange;
            this.label3.Location = new System.Drawing.Point(240, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(914, 45);
            this.label3.TabIndex = 3;
            this.label3.Text = "Need to search for books, articles, or other materials? ";
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "Start-Menu-Search-icon.png");
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.125F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.DarkOrange;
            this.label2.Location = new System.Drawing.Point(370, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(652, 61);
            this.label2.TabIndex = 1;
            this.label2.Text = "Welcome to LIBRARY.AYNUR";
            // 
            // tabPage_AboutUs
            // 
            this.tabPage_AboutUs.Controls.Add(this.label12);
            this.tabPage_AboutUs.Controls.Add(this.label11);
            this.tabPage_AboutUs.Controls.Add(this.pictureBox4);
            this.tabPage_AboutUs.Location = new System.Drawing.Point(8, 39);
            this.tabPage_AboutUs.Name = "tabPage_AboutUs";
            this.tabPage_AboutUs.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_AboutUs.Size = new System.Drawing.Size(1478, 1304);
            this.tabPage_AboutUs.TabIndex = 1;
            this.tabPage_AboutUs.Text = "About Us";
            this.tabPage_AboutUs.UseVisualStyleBackColor = true;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(488, 119);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(861, 25);
            this.label12.TabIndex = 2;
            this.label12.Text = "Born on january 16,2001 Balci Completed primary,secondary and high school in Ista" +
    "nbul.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Trebuchet MS", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(621, 33);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(567, 61);
            this.label11.TabIndex = 1;
            this.label11.Text = "Our founder Aynur Balci";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(456, 436);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage_OurServices
            // 
            this.tabPage_OurServices.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OurServices.Name = "tabPage_OurServices";
            this.tabPage_OurServices.Size = new System.Drawing.Size(1478, 1304);
            this.tabPage_OurServices.TabIndex = 2;
            this.tabPage_OurServices.Text = "Our Services";
            this.tabPage_OurServices.UseVisualStyleBackColor = true;
            // 
            // tabPage_OurActivities
            // 
            this.tabPage_OurActivities.Location = new System.Drawing.Point(8, 39);
            this.tabPage_OurActivities.Name = "tabPage_OurActivities";
            this.tabPage_OurActivities.Size = new System.Drawing.Size(1478, 1304);
            this.tabPage_OurActivities.TabIndex = 3;
            this.tabPage_OurActivities.Text = "Our Activities";
            this.tabPage_OurActivities.UseVisualStyleBackColor = true;
            // 
            // tabPage_Contact
            // 
            this.tabPage_Contact.Location = new System.Drawing.Point(8, 39);
            this.tabPage_Contact.Name = "tabPage_Contact";
            this.tabPage_Contact.Size = new System.Drawing.Size(1478, 1304);
            this.tabPage_Contact.TabIndex = 4;
            this.tabPage_Contact.Text = "Contact";
            this.tabPage_Contact.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1494, 295);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(8, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(279, 297);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1163, -4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(319, 313);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1494, 1666);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1520, 1737);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIBRARY.AYNUR";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage_HomePage.ResumeLayout(false);
            this.tabPage_HomePage.PerformLayout();
            this.tabPage_AboutUs.ResumeLayout(false);
            this.tabPage_AboutUs.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_HomePage;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPage_AboutUs;
        private System.Windows.Forms.TabPage tabPage_OurServices;
        private System.Windows.Forms.TabPage tabPage_OurActivities;
        private System.Windows.Forms.TabPage tabPage_Contact;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ImageList ımageList3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button4;
    }
}

