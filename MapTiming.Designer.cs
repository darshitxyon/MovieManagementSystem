namespace MovieManagementSystem
{
    partial class MapTiming
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.theatrebox = new System.Windows.Forms.TextBox();
            this.screenbox = new System.Windows.Forms.TextBox();
            this.moviebox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.timebox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.citybox = new System.Windows.Forms.TextBox();
            this.ViewCinema = new System.Windows.Forms.Button();
            this.ViewMovie = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "TheatreID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Screen";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(54, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "MovieID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 281);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = " Time";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // theatrebox
            // 
            this.theatrebox.Location = new System.Drawing.Point(158, 106);
            this.theatrebox.Name = "theatrebox";
            this.theatrebox.Size = new System.Drawing.Size(168, 20);
            this.theatrebox.TabIndex = 6;
            // 
            // screenbox
            // 
            this.screenbox.Location = new System.Drawing.Point(158, 164);
            this.screenbox.Name = "screenbox";
            this.screenbox.Size = new System.Drawing.Size(168, 20);
            this.screenbox.TabIndex = 7;
            // 
            // moviebox
            // 
            this.moviebox.Location = new System.Drawing.Point(158, 222);
            this.moviebox.Name = "moviebox";
            this.moviebox.Size = new System.Drawing.Size(168, 20);
            this.moviebox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(147, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Map";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(269, 396);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timebox
            // 
            this.timebox.Location = new System.Drawing.Point(158, 274);
            this.timebox.Name = "timebox";
            this.timebox.Size = new System.Drawing.Size(168, 20);
            this.timebox.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "City";
            // 
            // citybox
            // 
            this.citybox.Location = new System.Drawing.Point(158, 59);
            this.citybox.Name = "citybox";
            this.citybox.Size = new System.Drawing.Size(168, 20);
            this.citybox.TabIndex = 14;
            // 
            // ViewCinema
            // 
            this.ViewCinema.Location = new System.Drawing.Point(455, 104);
            this.ViewCinema.Name = "ViewCinema";
            this.ViewCinema.Size = new System.Drawing.Size(75, 23);
            this.ViewCinema.TabIndex = 15;
            this.ViewCinema.Text = "ViewTheatre";
            this.ViewCinema.UseVisualStyleBackColor = true;
            this.ViewCinema.Click += new System.EventHandler(this.ViewCinema_Click);
            // 
            // ViewMovie
            // 
            this.ViewMovie.Location = new System.Drawing.Point(455, 222);
            this.ViewMovie.Name = "ViewMovie";
            this.ViewMovie.Size = new System.Drawing.Size(75, 23);
            this.ViewMovie.TabIndex = 16;
            this.ViewMovie.Text = "ViewMovie";
            this.ViewMovie.UseVisualStyleBackColor = true;
            this.ViewMovie.Click += new System.EventHandler(this.ViewMovie_Click);
            // 
            // MapTiming
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 444);
            this.Controls.Add(this.ViewMovie);
            this.Controls.Add(this.ViewCinema);
            this.Controls.Add(this.citybox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timebox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.moviebox);
            this.Controls.Add(this.screenbox);
            this.Controls.Add(this.theatrebox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "MapTiming";
            this.Text = "MapTiming";
            this.Load += new System.EventHandler(this.MapTiming_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox theatrebox;
        private System.Windows.Forms.TextBox screenbox;
        private System.Windows.Forms.TextBox moviebox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox timebox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox citybox;
        private System.Windows.Forms.Button ViewCinema;
        private System.Windows.Forms.Button ViewMovie;
    }
}