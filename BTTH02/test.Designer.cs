namespace BTTH02
{
    partial class test
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
            likedSong1 = new Elements.LikedSong();
            SuspendLayout();
            // 
            // likedSong1
            // 
            likedSong1.BackColor = Color.FromArgb(64, 64, 64);
            likedSong1.Location = new Point(0, 0);
            likedSong1.Name = "likedSong1";
            likedSong1.Size = new Size(2285, 1339);
            likedSong1.TabIndex = 0;
            // 
            // test
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1596, 988);
            Controls.Add(likedSong1);
            Name = "test";
            Text = "test";
            ResumeLayout(false);
        }

        #endregion

        private Elements.LikedSong likedSong1;
    }
}