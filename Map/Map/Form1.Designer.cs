namespace Map
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.header = new System.Windows.Forms.Label();
            this.start2 = new System.Windows.Forms.PictureBox();
            this.pictureEnergyBars = new System.Windows.Forms.PictureBox();
            this.pictureToilets = new System.Windows.Forms.PictureBox();
            this.pictureInformation = new System.Windows.Forms.PictureBox();
            this.pictureMedical = new System.Windows.Forms.PictureBox();
            this.pictureDrinks = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.start3 = new System.Windows.Forms.PictureBox();
            this.Toilets = new System.Windows.Forms.Label();
            this.Medical = new System.Windows.Forms.Label();
            this.Information = new System.Windows.Forms.Label();
            this.EnergyBars = new System.Windows.Forms.Label();
            this.Drinks = new System.Windows.Forms.Label();
            this.checkpoint1 = new System.Windows.Forms.Label();
            this.checkpoint2 = new System.Windows.Forms.Label();
            this.checkpoint3 = new System.Windows.Forms.Label();
            this.checkpoint4 = new System.Windows.Forms.Label();
            this.checkpoint5 = new System.Windows.Forms.Label();
            this.checkpoint6 = new System.Windows.Forms.Label();
            this.checkpoint7 = new System.Windows.Forms.Label();
            this.checkpoint8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.start2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnergyBars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToilets)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInformation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedical)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrinks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.start3)).BeginInit();
            this.SuspendLayout();
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.header.Location = new System.Drawing.Point(824, 35);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(153, 24);
            this.header.TabIndex = 6;
            this.header.Text = "Название точки";
            // 
            // start2
            // 
            this.start2.Image = global::Map.Properties.Resources.map_icon_start;
            this.start2.Location = new System.Drawing.Point(402, 542);
            this.start2.Name = "start2";
            this.start2.Size = new System.Drawing.Size(46, 45);
            this.start2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start2.TabIndex = 7;
            this.start2.TabStop = false;
            this.start2.Click += new System.EventHandler(this.start2_Click);
            // 
            // pictureEnergyBars
            // 
            this.pictureEnergyBars.Image = global::Map.Properties.Resources.map_icon_energy_bars;
            this.pictureEnergyBars.Location = new System.Drawing.Point(688, 211);
            this.pictureEnergyBars.Name = "pictureEnergyBars";
            this.pictureEnergyBars.Size = new System.Drawing.Size(119, 94);
            this.pictureEnergyBars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureEnergyBars.TabIndex = 5;
            this.pictureEnergyBars.TabStop = false;
            // 
            // pictureToilets
            // 
            this.pictureToilets.Image = global::Map.Properties.Resources.map_icon_toilets;
            this.pictureToilets.Location = new System.Drawing.Point(688, 327);
            this.pictureToilets.Name = "pictureToilets";
            this.pictureToilets.Size = new System.Drawing.Size(119, 90);
            this.pictureToilets.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureToilets.TabIndex = 4;
            this.pictureToilets.TabStop = false;
            // 
            // pictureInformation
            // 
            this.pictureInformation.Image = global::Map.Properties.Resources.map_icon_information;
            this.pictureInformation.Location = new System.Drawing.Point(688, 580);
            this.pictureInformation.Name = "pictureInformation";
            this.pictureInformation.Size = new System.Drawing.Size(119, 104);
            this.pictureInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureInformation.TabIndex = 3;
            this.pictureInformation.TabStop = false;
            // 
            // pictureMedical
            // 
            this.pictureMedical.Image = global::Map.Properties.Resources.map_icon_medical;
            this.pictureMedical.Location = new System.Drawing.Point(688, 459);
            this.pictureMedical.Name = "pictureMedical";
            this.pictureMedical.Size = new System.Drawing.Size(119, 100);
            this.pictureMedical.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureMedical.TabIndex = 2;
            this.pictureMedical.TabStop = false;
            // 
            // pictureDrinks
            // 
            this.pictureDrinks.Image = global::Map.Properties.Resources.map_icon_drinks;
            this.pictureDrinks.Location = new System.Drawing.Point(688, 89);
            this.pictureDrinks.Name = "pictureDrinks";
            this.pictureDrinks.Size = new System.Drawing.Size(119, 95);
            this.pictureDrinks.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureDrinks.TabIndex = 1;
            this.pictureDrinks.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pictureBox1.Image = global::Map.Properties.Resources.map1;
            this.pictureBox1.Location = new System.Drawing.Point(103, 89);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(464, 498);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.Image = global::Map.Properties.Resources.map_icon_start;
            this.pictureBox9.Location = new System.Drawing.Point(286, 128);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(43, 41);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 9;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Click += new System.EventHandler(this.pictureBox9_Click);
            // 
            // start3
            // 
            this.start3.Image = global::Map.Properties.Resources.map_icon_start;
            this.start3.Location = new System.Drawing.Point(162, 298);
            this.start3.Name = "start3";
            this.start3.Size = new System.Drawing.Size(42, 42);
            this.start3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.start3.TabIndex = 10;
            this.start3.TabStop = false;
            this.start3.Click += new System.EventHandler(this.start3_Click);
            // 
            // Toilets
            // 
            this.Toilets.AutoSize = true;
            this.Toilets.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Toilets.Location = new System.Drawing.Point(862, 347);
            this.Toilets.Name = "Toilets";
            this.Toilets.Size = new System.Drawing.Size(72, 24);
            this.Toilets.TabIndex = 11;
            this.Toilets.Text = "Туалет";
            // 
            // Medical
            // 
            this.Medical.AutoSize = true;
            this.Medical.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Medical.Location = new System.Drawing.Point(862, 495);
            this.Medical.Name = "Medical";
            this.Medical.Size = new System.Drawing.Size(99, 24);
            this.Medical.TabIndex = 12;
            this.Medical.Text = "Медпункт";
            // 
            // Information
            // 
            this.Information.AutoSize = true;
            this.Information.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Information.Location = new System.Drawing.Point(862, 611);
            this.Information.Name = "Information";
            this.Information.Size = new System.Drawing.Size(231, 24);
            this.Information.TabIndex = 13;
            this.Information.Text = "Информационный стенд";
            // 
            // EnergyBars
            // 
            this.EnergyBars.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnergyBars.Location = new System.Drawing.Point(862, 226);
            this.EnergyBars.Name = "EnergyBars";
            this.EnergyBars.Size = new System.Drawing.Size(278, 38);
            this.EnergyBars.TabIndex = 14;
            this.EnergyBars.Text = "Энергитические батончики";
            // 
            // Drinks
            // 
            this.Drinks.AutoSize = true;
            this.Drinks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Drinks.Location = new System.Drawing.Point(862, 111);
            this.Drinks.Name = "Drinks";
            this.Drinks.Size = new System.Drawing.Size(125, 24);
            this.Drinks.TabIndex = 15;
            this.Drinks.Text = "Стенд питья";
            // 
            // checkpoint1
            // 
            this.checkpoint1.AutoSize = true;
            this.checkpoint1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint1.Location = new System.Drawing.Point(379, 120);
            this.checkpoint1.Name = "checkpoint1";
            this.checkpoint1.Size = new System.Drawing.Size(20, 24);
            this.checkpoint1.TabIndex = 20;
            this.checkpoint1.Text = "1";
            this.checkpoint1.Click += new System.EventHandler(this.checkpoint1_Click_1);
            // 
            // checkpoint2
            // 
            this.checkpoint2.AutoSize = true;
            this.checkpoint2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint2.Location = new System.Drawing.Point(429, 264);
            this.checkpoint2.Name = "checkpoint2";
            this.checkpoint2.Size = new System.Drawing.Size(20, 24);
            this.checkpoint2.TabIndex = 21;
            this.checkpoint2.Text = "2";
            this.checkpoint2.Click += new System.EventHandler(this.checkpoint2_Click);
            // 
            // checkpoint3
            // 
            this.checkpoint3.AutoSize = true;
            this.checkpoint3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint3.Location = new System.Drawing.Point(418, 365);
            this.checkpoint3.Name = "checkpoint3";
            this.checkpoint3.Size = new System.Drawing.Size(20, 24);
            this.checkpoint3.TabIndex = 22;
            this.checkpoint3.Text = "3";
            this.checkpoint3.Click += new System.EventHandler(this.checkpoint3_Click);
            // 
            // checkpoint4
            // 
            this.checkpoint4.AutoSize = true;
            this.checkpoint4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint4.Location = new System.Drawing.Point(528, 476);
            this.checkpoint4.Name = "checkpoint4";
            this.checkpoint4.Size = new System.Drawing.Size(20, 24);
            this.checkpoint4.TabIndex = 23;
            this.checkpoint4.Text = "4";
            this.checkpoint4.Click += new System.EventHandler(this.checkpoint4_Click);
            // 
            // checkpoint5
            // 
            this.checkpoint5.AutoSize = true;
            this.checkpoint5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint5.Location = new System.Drawing.Point(356, 550);
            this.checkpoint5.Name = "checkpoint5";
            this.checkpoint5.Size = new System.Drawing.Size(20, 24);
            this.checkpoint5.TabIndex = 24;
            this.checkpoint5.Text = "5";
            this.checkpoint5.Click += new System.EventHandler(this.checkpoint5_Click);
            // 
            // checkpoint6
            // 
            this.checkpoint6.AutoSize = true;
            this.checkpoint6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint6.Location = new System.Drawing.Point(217, 495);
            this.checkpoint6.Name = "checkpoint6";
            this.checkpoint6.Size = new System.Drawing.Size(20, 24);
            this.checkpoint6.TabIndex = 25;
            this.checkpoint6.Text = "6";
            this.checkpoint6.Click += new System.EventHandler(this.checkpoint6_Click);
            // 
            // checkpoint7
            // 
            this.checkpoint7.AutoSize = true;
            this.checkpoint7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint7.Location = new System.Drawing.Point(176, 408);
            this.checkpoint7.Name = "checkpoint7";
            this.checkpoint7.Size = new System.Drawing.Size(20, 24);
            this.checkpoint7.TabIndex = 26;
            this.checkpoint7.Text = "7";
            this.checkpoint7.Click += new System.EventHandler(this.checkpoint7_Click);
            // 
            // checkpoint8
            // 
            this.checkpoint8.AutoSize = true;
            this.checkpoint8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.checkpoint8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkpoint8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.checkpoint8.Location = new System.Drawing.Point(163, 259);
            this.checkpoint8.Name = "checkpoint8";
            this.checkpoint8.Size = new System.Drawing.Size(20, 24);
            this.checkpoint8.TabIndex = 27;
            this.checkpoint8.Text = "8";
            this.checkpoint8.Click += new System.EventHandler(this.checkpoint8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1311, 726);
            this.Controls.Add(this.checkpoint8);
            this.Controls.Add(this.checkpoint7);
            this.Controls.Add(this.checkpoint6);
            this.Controls.Add(this.checkpoint5);
            this.Controls.Add(this.checkpoint4);
            this.Controls.Add(this.checkpoint3);
            this.Controls.Add(this.checkpoint2);
            this.Controls.Add(this.checkpoint1);
            this.Controls.Add(this.Drinks);
            this.Controls.Add(this.EnergyBars);
            this.Controls.Add(this.Information);
            this.Controls.Add(this.Medical);
            this.Controls.Add(this.Toilets);
            this.Controls.Add(this.start3);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.start2);
            this.Controls.Add(this.header);
            this.Controls.Add(this.pictureEnergyBars);
            this.Controls.Add(this.pictureToilets);
            this.Controls.Add(this.pictureInformation);
            this.Controls.Add(this.pictureMedical);
            this.Controls.Add(this.pictureDrinks);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Карта";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.start2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEnergyBars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureToilets)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureInformation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureMedical)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureDrinks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.start3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureDrinks;
        private System.Windows.Forms.PictureBox pictureMedical;
        private System.Windows.Forms.PictureBox pictureInformation;
        private System.Windows.Forms.PictureBox pictureToilets;
        private System.Windows.Forms.PictureBox pictureEnergyBars;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.PictureBox start2;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox start3;
        private System.Windows.Forms.Label Toilets;
        private System.Windows.Forms.Label Medical;
        private System.Windows.Forms.Label Information;
        private System.Windows.Forms.Label EnergyBars;
        private System.Windows.Forms.Label Drinks;
        private System.Windows.Forms.Label checkpoint1;
        private System.Windows.Forms.Label checkpoint2;
        private System.Windows.Forms.Label checkpoint3;
        private System.Windows.Forms.Label checkpoint4;
        private System.Windows.Forms.Label checkpoint5;
        private System.Windows.Forms.Label checkpoint6;
        private System.Windows.Forms.Label checkpoint7;
        private System.Windows.Forms.Label checkpoint8;
    }
}

