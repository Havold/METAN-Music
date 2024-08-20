namespace BTTH02.Elements
{
    partial class LikedSong
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
            bgPanel = new Panel();
            favoriteIcon = new PictureBox();
            likedSongs = new Label();
            Playlist = new Label();
            favoritePanel = new Panel();
            likeList = new FlowLayoutPanel();
            infoTab = new SongInfo();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)favoriteIcon).BeginInit();
            SuspendLayout();
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(128, 128, 255);
            bgPanel.Controls.Add(favoriteIcon);
            bgPanel.Controls.Add(likedSongs);
            bgPanel.Controls.Add(Playlist);
            bgPanel.Location = new Point(0, 3);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1828, 328);
            bgPanel.TabIndex = 8;
            // 
            // favoriteIcon
            // 
            favoriteIcon.BackColor = Color.FromArgb(128, 128, 255);
            favoriteIcon.Image = Properties.Resources.favorite3;
            favoriteIcon.Location = new Point(26, 13);
            favoriteIcon.Name = "favoriteIcon";
            favoriteIcon.Size = new Size(300, 300);
            favoriteIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            favoriteIcon.TabIndex = 7;
            favoriteIcon.TabStop = false;
            // 
            // likedSongs
            // 
            likedSongs.AutoSize = true;
            likedSongs.Font = new Font("Sublima ExtraBold", 60F, FontStyle.Bold);
            likedSongs.ForeColor = Color.White;
            likedSongs.Location = new Point(327, 80);
            likedSongs.Name = "likedSongs";
            likedSongs.Size = new Size(677, 168);
            likedSongs.TabIndex = 2;
            likedSongs.Text = "Liked Songs";
            // 
            // Playlist
            // 
            Playlist.AutoSize = true;
            Playlist.BackColor = Color.FromArgb(128, 128, 255);
            Playlist.Font = new Font("Sublima ExtraBold", 16F);
            Playlist.ForeColor = Color.White;
            Playlist.Location = new Point(353, 37);
            Playlist.Name = "Playlist";
            Playlist.Size = new Size(119, 45);
            Playlist.TabIndex = 6;
            Playlist.Text = "Playlist";
            // 
            // favoritePanel
            // 
            favoritePanel.Location = new Point(0, 6);
            favoritePanel.Name = "favoritePanel";
            favoritePanel.Size = new Size(1825, 1062);
            favoritePanel.TabIndex = 10;
            // 
            // likeList
            // 
            likeList.Location = new Point(28, 354);
            likeList.Name = "likeList";
            likeList.Size = new Size(1771, 697);
            likeList.TabIndex = 9;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(3, 3);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1851, 1071);
            infoTab.TabIndex = 11;
            infoTab.Visible = false;
            // 
            // LikedSong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(infoTab);
            Controls.Add(likeList);
            Controls.Add(bgPanel);
            Controls.Add(favoritePanel);
            Name = "LikedSong";
            Size = new Size(1828, 1071);
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)favoriteIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel bgPanel;
        private PictureBox favoriteIcon;
        private Label likedSongs;
        private Label Playlist;
        private Panel favoritePanel;
        private FlowLayoutPanel likeList;
        private SongInfo infoTab;
    }
}
