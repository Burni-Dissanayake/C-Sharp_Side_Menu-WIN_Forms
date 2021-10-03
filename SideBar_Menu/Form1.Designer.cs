
namespace SideBar_Menu
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
            this.menu = new System.Windows.Forms.Panel();
            this.indicator = new FontAwesome.Sharp.IconPictureBox();
            this.food = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.home = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.topbar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.beverages = new FontAwesome.Sharp.IconButton();
            this.menu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).BeginInit();
            this.topbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.BackColor = System.Drawing.Color.OrangeRed;
            this.menu.Controls.Add(this.indicator);
            this.menu.Controls.Add(this.beverages);
            this.menu.Controls.Add(this.panel3);
            this.menu.Controls.Add(this.food);
            this.menu.Controls.Add(this.panel2);
            this.menu.Controls.Add(this.home);
            this.menu.Controls.Add(this.panel1);
            this.menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(79, 490);
            this.menu.TabIndex = 0;
            // 
            // indicator
            // 
            this.indicator.BackColor = System.Drawing.Color.Orange;
            this.indicator.ForeColor = System.Drawing.SystemColors.ControlText;
            this.indicator.IconChar = FontAwesome.Sharp.IconChar.None;
            this.indicator.IconColor = System.Drawing.SystemColors.ControlText;
            this.indicator.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.indicator.IconSize = 10;
            this.indicator.Location = new System.Drawing.Point(0, 71);
            this.indicator.Name = "indicator";
            this.indicator.Size = new System.Drawing.Size(10, 56);
            this.indicator.TabIndex = 4;
            this.indicator.TabStop = false;
            // 
            // food
            // 
            this.food.Dock = System.Windows.Forms.DockStyle.Top;
            this.food.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.food.ForeColor = System.Drawing.Color.OrangeRed;
            this.food.IconChar = FontAwesome.Sharp.IconChar.CookieBite;
            this.food.IconColor = System.Drawing.Color.White;
            this.food.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.food.Location = new System.Drawing.Point(0, 174);
            this.food.Name = "food";
            this.food.Size = new System.Drawing.Size(79, 56);
            this.food.TabIndex = 3;
            this.food.UseVisualStyleBackColor = true;
            this.food.Click += new System.EventHandler(this.food_Click);
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 127);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(79, 47);
            this.panel2.TabIndex = 2;
            // 
            // home
            // 
            this.home.Dock = System.Windows.Forms.DockStyle.Top;
            this.home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home.ForeColor = System.Drawing.Color.OrangeRed;
            this.home.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.home.IconColor = System.Drawing.Color.White;
            this.home.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.home.Location = new System.Drawing.Point(0, 71);
            this.home.Name = "home";
            this.home.Size = new System.Drawing.Size(79, 56);
            this.home.TabIndex = 1;
            this.home.UseVisualStyleBackColor = true;
            this.home.Click += new System.EventHandler(this.home_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(79, 71);
            this.panel1.TabIndex = 0;
            // 
            // topbar
            // 
            this.topbar.Controls.Add(this.pictureBox1);
            this.topbar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topbar.Location = new System.Drawing.Point(79, 0);
            this.topbar.Name = "topbar";
            this.topbar.Size = new System.Drawing.Size(721, 38);
            this.topbar.TabIndex = 1;
            this.topbar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Red;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::SideBar_Menu.Properties.Resources.Group;
            this.pictureBox1.Location = new System.Drawing.Point(671, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(79, 38);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(721, 452);
            this.mainpanel.TabIndex = 2;
            this.mainpanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove);
            this.mainpanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 230);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(79, 47);
            this.panel3.TabIndex = 5;
            // 
            // beverages
            // 
            this.beverages.Dock = System.Windows.Forms.DockStyle.Top;
            this.beverages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.beverages.ForeColor = System.Drawing.Color.OrangeRed;
            this.beverages.IconChar = FontAwesome.Sharp.IconChar.Cocktail;
            this.beverages.IconColor = System.Drawing.Color.White;
            this.beverages.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.beverages.Location = new System.Drawing.Point(0, 277);
            this.beverages.Name = "beverages";
            this.beverages.Size = new System.Drawing.Size(79, 56);
            this.beverages.TabIndex = 6;
            this.beverages.UseVisualStyleBackColor = true;
            this.beverages.Click += new System.EventHandler(this.beverages_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 490);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.topbar);
            this.Controls.Add(this.menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.indicator)).EndInit();
            this.topbar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel topbar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton food;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton home;
        private System.Windows.Forms.Panel mainpanel;
        private FontAwesome.Sharp.IconPictureBox indicator;
        private FontAwesome.Sharp.IconButton beverages;
        private System.Windows.Forms.Panel panel3;
    }
}

