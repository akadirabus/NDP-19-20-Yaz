namespace NDPProject
{
    partial class Level3
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pbArrow = new System.Windows.Forms.PictureBox();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.pbBalloon2 = new System.Windows.Forms.PictureBox();
            this.pbBalloon3 = new System.Windows.Forms.PictureBox();
            this.pbBalloon1 = new System.Windows.Forms.PictureBox();
            this.lblScore = new System.Windows.Forms.Label();
            this.lblRowCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 60;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // pbArrow
            // 
            this.pbArrow.Location = new System.Drawing.Point(134, 234);
            this.pbArrow.Name = "pbArrow";
            this.pbArrow.Size = new System.Drawing.Size(82, 15);
            this.pbArrow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArrow.TabIndex = 7;
            this.pbArrow.TabStop = false;
            this.pbArrow.Visible = false;
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(12, 180);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(116, 132);
            this.pbPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayer.TabIndex = 6;
            this.pbPlayer.TabStop = false;
            // 
            // pbBalloon2
            // 
            this.pbBalloon2.Location = new System.Drawing.Point(475, 14);
            this.pbBalloon2.Name = "pbBalloon2";
            this.pbBalloon2.Size = new System.Drawing.Size(46, 52);
            this.pbBalloon2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBalloon2.TabIndex = 10;
            this.pbBalloon2.TabStop = false;
            this.pbBalloon2.Visible = false;
            // 
            // pbBalloon3
            // 
            this.pbBalloon3.Location = new System.Drawing.Point(338, 14);
            this.pbBalloon3.Name = "pbBalloon3";
            this.pbBalloon3.Size = new System.Drawing.Size(46, 52);
            this.pbBalloon3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBalloon3.TabIndex = 9;
            this.pbBalloon3.TabStop = false;
            this.pbBalloon3.Visible = false;
            // 
            // pbBalloon1
            // 
            this.pbBalloon1.Location = new System.Drawing.Point(403, 14);
            this.pbBalloon1.Name = "pbBalloon1";
            this.pbBalloon1.Size = new System.Drawing.Size(46, 52);
            this.pbBalloon1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBalloon1.TabIndex = 8;
            this.pbBalloon1.TabStop = false;
            this.pbBalloon1.Visible = false;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblScore.ForeColor = System.Drawing.Color.White;
            this.lblScore.Location = new System.Drawing.Point(26, 26);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(54, 20);
            this.lblScore.TabIndex = 12;
            this.lblScore.Text = "Puan: ";
            // 
            // lblRowCount
            // 
            this.lblRowCount.AutoSize = true;
            this.lblRowCount.Location = new System.Drawing.Point(55, 164);
            this.lblRowCount.Name = "lblRowCount";
            this.lblRowCount.Size = new System.Drawing.Size(35, 13);
            this.lblRowCount.TabIndex = 13;
            this.lblRowCount.Text = "label1";
            this.lblRowCount.Click += new System.EventHandler(this.lblRowCount_Click);
            // 
            // Level3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.lblRowCount);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.pbArrow);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.pbBalloon2);
            this.Controls.Add(this.pbBalloon3);
            this.Controls.Add(this.pbBalloon1);
            this.Name = "Level3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Level3";
            this.Load += new System.EventHandler(this.Level3_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Level3_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pbArrow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBalloon1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pbArrow;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.PictureBox pbBalloon2;
        private System.Windows.Forms.PictureBox pbBalloon3;
        private System.Windows.Forms.PictureBox pbBalloon1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblRowCount;
    }
}