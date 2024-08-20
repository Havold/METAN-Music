namespace BTTH02.Elements
{
    partial class Comment
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            contentCmt = new TextBox();
            picGender = new PictureBox();
            star1 = new PictureBox();
            star2 = new PictureBox();
            star3 = new PictureBox();
            star4 = new PictureBox();
            star5 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)picGender).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)star5).BeginInit();
            SuspendLayout();
            // 
            // contentCmt
            // 
            contentCmt.AllowDrop = true;
            contentCmt.BackColor = Color.Ivory;
            contentCmt.BorderStyle = BorderStyle.None;
            contentCmt.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold);
            contentCmt.Location = new Point(142, 16);
            contentCmt.Multiline = true;
            contentCmt.Name = "contentCmt";
            contentCmt.Size = new Size(549, 100);
            contentCmt.TabIndex = 0;
            // 
            // picGender
            // 
            picGender.BackColor = Color.Ivory;
            picGender.Image = Properties.Resources.boy;
            picGender.Location = new Point(15, 16);
            picGender.Name = "picGender";
            picGender.Size = new Size(100, 100);
            picGender.SizeMode = PictureBoxSizeMode.StretchImage;
            picGender.TabIndex = 1;
            picGender.TabStop = false;
            // 
            // star1
            // 
            star1.Image = Properties.Resources.star_empty;
            star1.Location = new Point(148, 131);
            star1.Name = "star1";
            star1.Size = new Size(50, 50);
            star1.SizeMode = PictureBoxSizeMode.StretchImage;
            star1.TabIndex = 2;
            star1.TabStop = false;
            // 
            // star2
            // 
            star2.Image = Properties.Resources.star_empty;
            star2.Location = new Point(223, 131);
            star2.Name = "star2";
            star2.Size = new Size(50, 50);
            star2.SizeMode = PictureBoxSizeMode.StretchImage;
            star2.TabIndex = 2;
            star2.TabStop = false;
            // 
            // star3
            // 
            star3.Image = Properties.Resources.star_empty;
            star3.Location = new Point(300, 131);
            star3.Name = "star3";
            star3.Size = new Size(50, 50);
            star3.SizeMode = PictureBoxSizeMode.StretchImage;
            star3.TabIndex = 2;
            star3.TabStop = false;
            // 
            // star4
            // 
            star4.Image = Properties.Resources.star_empty;
            star4.Location = new Point(374, 131);
            star4.Name = "star4";
            star4.Size = new Size(50, 50);
            star4.SizeMode = PictureBoxSizeMode.StretchImage;
            star4.TabIndex = 2;
            star4.TabStop = false;
            // 
            // star5
            // 
            star5.Image = Properties.Resources.star_empty;
            star5.Location = new Point(451, 131);
            star5.Name = "star5";
            star5.Size = new Size(50, 50);
            star5.SizeMode = PictureBoxSizeMode.StretchImage;
            star5.TabIndex = 2;
            star5.TabStop = false;
            // 
            // Comment
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            BorderStyle = BorderStyle.Fixed3D;
            Controls.Add(star5);
            Controls.Add(star4);
            Controls.Add(contentCmt);
            Controls.Add(star3);
            Controls.Add(picGender);
            Controls.Add(star2);
            Controls.Add(star1);
            Name = "Comment";
            Size = new Size(709, 199);
            ((System.ComponentModel.ISupportInitialize)picGender).EndInit();
            ((System.ComponentModel.ISupportInitialize)star1).EndInit();
            ((System.ComponentModel.ISupportInitialize)star2).EndInit();
            ((System.ComponentModel.ISupportInitialize)star3).EndInit();
            ((System.ComponentModel.ISupportInitialize)star4).EndInit();
            ((System.ComponentModel.ISupportInitialize)star5).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox contentCmt;
        private PictureBox picGender;
        private PictureBox star1;
        private PictureBox star2;
        private PictureBox star3;
        private PictureBox star4;
        private PictureBox star5;
    }
}
