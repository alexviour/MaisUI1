﻿namespace MaisUI
{
    partial class Form5
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.UserName = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.MostBoughtProductImage = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.Settingsbtn = new System.Windows.Forms.Button();
            this.Productsbtn = new System.Windows.Forms.Button();
            this.Ordersbtn = new System.Windows.Forms.Button();
            this.DashBoardbtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MostBoughtProductImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.Location = new System.Drawing.Point(350, 38);
            this.UserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(110, 25);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Username";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(363, 62);
            this.Email.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(73, 17);
            this.Email.TabIndex = 4;
            this.Email.Text = "Username";
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(83)))));
            this.chart1.BorderlineColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(303, 169);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chart1.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(83)))))};
            this.chart1.Size = new System.Drawing.Size(365, 275);
            this.chart1.TabIndex = 7;
            this.chart1.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "Monthly Sales";
            this.chart1.Titles.Add(title1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(715, 169);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 13);
            this.label3.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(83)))));
            this.panel1.BackgroundImage = global::MaisUI.Properties.Resources.Screenshot_2024_05_27_162911_removebg_preview;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.Controls.Add(this.MostBoughtProductImage);
            this.panel1.Location = new System.Drawing.Point(700, 208);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 235);
            this.panel1.TabIndex = 8;
            // 
            // MostBoughtProductImage
            // 
            this.MostBoughtProductImage.BackColor = System.Drawing.Color.Transparent;
            this.MostBoughtProductImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MostBoughtProductImage.Location = new System.Drawing.Point(26, 23);
            this.MostBoughtProductImage.Margin = new System.Windows.Forms.Padding(2);
            this.MostBoughtProductImage.Name = "MostBoughtProductImage";
            this.MostBoughtProductImage.Size = new System.Drawing.Size(164, 184);
            this.MostBoughtProductImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MostBoughtProductImage.TabIndex = 0;
            this.MostBoughtProductImage.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(83)))));
            this.pictureBox4.Image = global::MaisUI.Properties.Resources.image_removebg_preview__14_;
            this.pictureBox4.Location = new System.Drawing.Point(661, 158);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(291, 68);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 10;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(282, 129);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(682, 347);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(258, 27);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(90, 93);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // Settingsbtn
            // 
            this.Settingsbtn.BackColor = System.Drawing.Color.Transparent;
            this.Settingsbtn.BackgroundImage = global::MaisUI.Properties.Resources.Screenshot_2024_05_27_164000_removebg_preview;
            this.Settingsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Settingsbtn.FlatAppearance.BorderSize = 0;
            this.Settingsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Settingsbtn.Location = new System.Drawing.Point(45, 349);
            this.Settingsbtn.Name = "Settingsbtn";
            this.Settingsbtn.Size = new System.Drawing.Size(159, 46);
            this.Settingsbtn.TabIndex = 1;
            this.Settingsbtn.UseVisualStyleBackColor = false;
            // 
            // Productsbtn
            // 
            this.Productsbtn.BackColor = System.Drawing.Color.Transparent;
            this.Productsbtn.BackgroundImage = global::MaisUI.Properties.Resources.Screenshot_2024_05_27_163433_removebg_preview;
            this.Productsbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Productsbtn.FlatAppearance.BorderSize = 0;
            this.Productsbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Productsbtn.Location = new System.Drawing.Point(45, 285);
            this.Productsbtn.Name = "Productsbtn";
            this.Productsbtn.Size = new System.Drawing.Size(159, 42);
            this.Productsbtn.TabIndex = 1;
            this.Productsbtn.UseVisualStyleBackColor = false;
            this.Productsbtn.Click += new System.EventHandler(this.Productsbtn_Click);
            // 
            // Ordersbtn
            // 
            this.Ordersbtn.BackColor = System.Drawing.Color.Transparent;
            this.Ordersbtn.BackgroundImage = global::MaisUI.Properties.Resources.Screenshot_2024_05_27_163842_removebg_preview;
            this.Ordersbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Ordersbtn.FlatAppearance.BorderSize = 0;
            this.Ordersbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Ordersbtn.Location = new System.Drawing.Point(45, 220);
            this.Ordersbtn.Name = "Ordersbtn";
            this.Ordersbtn.Size = new System.Drawing.Size(153, 45);
            this.Ordersbtn.TabIndex = 1;
            this.Ordersbtn.UseVisualStyleBackColor = false;
            this.Ordersbtn.Click += new System.EventHandler(this.Ordersbtn_Click);
            // 
            // DashBoardbtn
            // 
            this.DashBoardbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(192)))), ((int)(((byte)(83)))));
            this.DashBoardbtn.BackgroundImage = global::MaisUI.Properties.Resources.Screenshot_2024_05_27_164158_removebg_preview;
            this.DashBoardbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DashBoardbtn.FlatAppearance.BorderSize = 0;
            this.DashBoardbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DashBoardbtn.Location = new System.Drawing.Point(45, 169);
            this.DashBoardbtn.Name = "DashBoardbtn";
            this.DashBoardbtn.Size = new System.Drawing.Size(159, 45);
            this.DashBoardbtn.TabIndex = 1;
            this.DashBoardbtn.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MaisUI.Properties.Resources.Managing_kineme__6__removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(49, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(116, 119);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(1024, 535);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.Settingsbtn);
            this.Controls.Add(this.Productsbtn);
            this.Controls.Add(this.Ordersbtn);
            this.Controls.Add(this.DashBoardbtn);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form5";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MostBoughtProductImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button DashBoardbtn;
        private System.Windows.Forms.Button Ordersbtn;
        private System.Windows.Forms.Button Productsbtn;
        private System.Windows.Forms.Button Settingsbtn;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox MostBoughtProductImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox4;
    }
}