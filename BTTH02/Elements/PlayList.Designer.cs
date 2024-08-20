namespace BTTH02.Elements
{
    partial class PlayList
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
            panel1 = new Panel();
            bgPanel = new Panel();
            playlistIcon = new PictureBox();
            myPlaylist = new Label();
            play = new Label();
            list = new FlowLayoutPanel();
            favoritePanel = new Panel();
            infoTab = new SongInfo();
            panel1.SuspendLayout();
            bgPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playlistIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(64, 64, 64);
            panel1.Controls.Add(bgPanel);
            panel1.Controls.Add(list);
            panel1.Controls.Add(favoritePanel);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1481, 840);
            panel1.TabIndex = 0;
            // 
            // bgPanel
            // 
            bgPanel.BackColor = Color.FromArgb(128, 128, 255);
            bgPanel.Controls.Add(playlistIcon);
            bgPanel.Controls.Add(myPlaylist);
            bgPanel.Controls.Add(play);
            bgPanel.Location = new Point(3, -1);
            bgPanel.Name = "bgPanel";
            bgPanel.Size = new Size(1825, 328);
            bgPanel.TabIndex = 11;
            // 
            // playlistIcon
            // 
            playlistIcon.BackColor = Color.FromArgb(128, 128, 255);
            playlistIcon.Image = Properties.Resources.favorite3;
            playlistIcon.Location = new Point(26, 13);
            playlistIcon.Name = "playlistIcon";
            playlistIcon.Size = new Size(300, 300);
            playlistIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            playlistIcon.TabIndex = 7;
            playlistIcon.TabStop = false;
            // 
            // myPlaylist
            // 
            myPlaylist.AutoSize = true;
            myPlaylist.Font = new Font("Sublima ExtraBold", 60F, FontStyle.Bold);
            myPlaylist.ForeColor = Color.White;
            myPlaylist.Location = new Point(327, 80);
            myPlaylist.Name = "myPlaylist";
            myPlaylist.Size = new Size(610, 168);
            myPlaylist.TabIndex = 2;
            myPlaylist.Text = "My Playlist";
            // 
            // play
            // 
            play.AutoSize = true;
            play.BackColor = Color.FromArgb(128, 128, 255);
            play.Font = new Font("Sublima ExtraBold", 16F);
            play.ForeColor = Color.White;
            play.Location = new Point(353, 37);
            play.Name = "play";
            play.Size = new Size(119, 45);
            play.TabIndex = 6;
            play.Text = "Playlist";
            // 
            // list
            // 
            list.Location = new Point(28, 350);
            list.Name = "list";
            list.Size = new Size(1771, 697);
            list.TabIndex = 12;
            // 
            // favoritePanel
            // 
            favoritePanel.Location = new Point(0, 2);
            favoritePanel.Name = "favoritePanel";
            favoritePanel.Size = new Size(1825, 1062);
            favoritePanel.TabIndex = 13;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(0, 0);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1851, 1071);
            infoTab.TabIndex = 1;
            infoTab.Visible = false;
            // 
            // PlayList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(infoTab);
            Controls.Add(panel1);
            Name = "PlayList";
            Size = new Size(1481, 857);
            panel1.ResumeLayout(false);
            bgPanel.ResumeLayout(false);
            bgPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)playlistIcon).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel bgPanel;
        private PictureBox playlistIcon;
        private Label myPlaylist;
        private Label play;
        private FlowLayoutPanel list;
        private Panel favoritePanel;
        private SongInfo infoTab;
    }
}
