namespace BTTH02
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            closeBtn = new PictureBox();
            homePanel = new Panel();
            Search = new Label();
            Home = new Label();
            searchIcon = new PictureBox();
            homeIcon = new PictureBox();
            YourLibrary = new Label();
            libraryPanel = new Panel();
            playlist = new FlowLayoutPanel();
            likedSong = new Label();
            recentSong = new Label();
            ForeignList = new Label();
            pictureBox1 = new PictureBox();
            VNList = new Label();
            Add = new PictureBox();
            recentIcon = new PictureBox();
            vnIcon = new PictureBox();
            foreignIcon = new PictureBox();
            playListsIcon = new PictureBox();
            yourLibraryIcon = new PictureBox();
            homeTab = new Elements.Home();
            pictureBox5 = new PictureBox();
            pictureBox7 = new PictureBox();
            nextPanel = new Panel();
            searchTab = new Elements.Search();
            vnTab = new Elements.VNList();
            foreignTab = new Elements.ForeignList();
            recentTab = new Elements.Recently();
            favoriteTab = new Elements.LikedSong();
            playlistTab = new Elements.PlayList();
            ((System.ComponentModel.ISupportInitialize)closeBtn).BeginInit();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).BeginInit();
            libraryPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Add).BeginInit();
            ((System.ComponentModel.ISupportInitialize)recentIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)vnIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)foreignIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)playListsIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)yourLibraryIcon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            nextPanel.SuspendLayout();
            SuspendLayout();
            // 
            // closeBtn
            // 
            closeBtn.BackgroundImageLayout = ImageLayout.Stretch;
            closeBtn.Cursor = Cursors.Hand;
            closeBtn.Image = Properties.Resources.close;
            closeBtn.Location = new Point(1844, 3);
            closeBtn.Name = "closeBtn";
            closeBtn.Size = new Size(30, 26);
            closeBtn.SizeMode = PictureBoxSizeMode.Zoom;
            closeBtn.TabIndex = 5;
            closeBtn.TabStop = false;
            closeBtn.Click += closeBtn_Click;
            closeBtn.MouseEnter += closeBtn_MouseEnter;
            closeBtn.MouseLeave += closeBtn_MouseLeave;
            // 
            // homePanel
            // 
            homePanel.BackColor = Color.FromArgb(64, 64, 64);
            homePanel.BackgroundImageLayout = ImageLayout.Stretch;
            homePanel.Controls.Add(Search);
            homePanel.Controls.Add(Home);
            homePanel.Controls.Add(searchIcon);
            homePanel.Controls.Add(homeIcon);
            homePanel.Location = new Point(18, 35);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(364, 177);
            homePanel.TabIndex = 3;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Cursor = Cursors.Hand;
            Search.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            Search.ForeColor = Color.Silver;
            Search.Location = new Point(77, 104);
            Search.Name = "Search";
            Search.Size = new Size(86, 34);
            Search.TabIndex = 2;
            Search.Text = "Search";
            Search.Click += Search_Click;
            Search.MouseEnter += Search_MouseEnter;
            Search.MouseLeave += Search_MouseLeave;
            // 
            // Home
            // 
            Home.AutoSize = true;
            Home.Cursor = Cursors.Hand;
            Home.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            Home.Location = new Point(77, 30);
            Home.Name = "Home";
            Home.Size = new Size(72, 34);
            Home.TabIndex = 2;
            Home.Text = "Home";
            Home.Click += Home_Click;
            Home.MouseEnter += Home_MouseEnter;
            Home.MouseLeave += Home_MouseLeave;
            // 
            // searchIcon
            // 
            searchIcon.BackgroundImageLayout = ImageLayout.Stretch;
            searchIcon.Cursor = Cursors.Hand;
            searchIcon.Image = Properties.Resources.find_none;
            searchIcon.Location = new Point(22, 107);
            searchIcon.Name = "searchIcon";
            searchIcon.Size = new Size(36, 33);
            searchIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            searchIcon.TabIndex = 0;
            searchIcon.TabStop = false;
            searchIcon.Click += Search_Click;
            searchIcon.MouseEnter += Search_MouseEnter;
            searchIcon.MouseLeave += Search_MouseLeave;
            // 
            // homeIcon
            // 
            homeIcon.BackgroundImageLayout = ImageLayout.Stretch;
            homeIcon.Cursor = Cursors.Hand;
            homeIcon.Image = Properties.Resources.Home_full;
            homeIcon.Location = new Point(22, 27);
            homeIcon.Name = "homeIcon";
            homeIcon.Size = new Size(36, 37);
            homeIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            homeIcon.TabIndex = 0;
            homeIcon.TabStop = false;
            homeIcon.Click += Home_Click;
            homeIcon.MouseEnter += Home_MouseEnter;
            homeIcon.MouseLeave += Home_MouseLeave;
            // 
            // YourLibrary
            // 
            YourLibrary.AutoSize = true;
            YourLibrary.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            YourLibrary.ForeColor = Color.White;
            YourLibrary.Location = new Point(77, 222);
            YourLibrary.Name = "YourLibrary";
            YourLibrary.Size = new Size(139, 34);
            YourLibrary.TabIndex = 2;
            YourLibrary.Text = "Your Library";
            // 
            // libraryPanel
            // 
            libraryPanel.BackColor = Color.FromArgb(64, 64, 64);
            libraryPanel.BackgroundImageLayout = ImageLayout.Stretch;
            libraryPanel.Controls.Add(playlist);
            libraryPanel.Controls.Add(likedSong);
            libraryPanel.Controls.Add(recentSong);
            libraryPanel.Controls.Add(ForeignList);
            libraryPanel.Controls.Add(pictureBox1);
            libraryPanel.Controls.Add(VNList);
            libraryPanel.Controls.Add(Add);
            libraryPanel.Controls.Add(recentIcon);
            libraryPanel.Controls.Add(vnIcon);
            libraryPanel.Controls.Add(foreignIcon);
            libraryPanel.Controls.Add(YourLibrary);
            libraryPanel.Controls.Add(playListsIcon);
            libraryPanel.Controls.Add(yourLibraryIcon);
            libraryPanel.Location = new Point(18, 228);
            libraryPanel.Name = "libraryPanel";
            libraryPanel.Size = new Size(364, 755);
            libraryPanel.TabIndex = 2;
            // 
            // playlist
            // 
            playlist.Location = new Point(17, 420);
            playlist.Name = "playlist";
            playlist.Size = new Size(331, 318);
            playlist.TabIndex = 3;
            // 
            // likedSong
            // 
            likedSong.AutoSize = true;
            likedSong.Cursor = Cursors.Hand;
            likedSong.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            likedSong.ForeColor = Color.Silver;
            likedSong.Location = new Point(91, 356);
            likedSong.Name = "likedSong";
            likedSong.Size = new Size(136, 34);
            likedSong.TabIndex = 2;
            likedSong.Text = "Liked Songs";
            likedSong.Click += likedSong_Click;
            likedSong.MouseEnter += favorite_MouseEnter;
            likedSong.MouseLeave += favorite_MouseLeave;
            // 
            // recentSong
            // 
            recentSong.AutoSize = true;
            recentSong.Cursor = Cursors.Hand;
            recentSong.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            recentSong.ForeColor = Color.Silver;
            recentSong.Location = new Point(77, 155);
            recentSong.Name = "recentSong";
            recentSong.Size = new Size(152, 34);
            recentSong.TabIndex = 2;
            recentSong.Text = "Recent Songs";
            recentSong.Click += recentSong_Click;
            recentSong.MouseEnter += recentSong_MouseEnter;
            recentSong.MouseLeave += recentSong_MouseLeave;
            // 
            // ForeignList
            // 
            ForeignList.AutoSize = true;
            ForeignList.Cursor = Cursors.Hand;
            ForeignList.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            ForeignList.ForeColor = Color.Silver;
            ForeignList.Location = new Point(77, 93);
            ForeignList.Name = "ForeignList";
            ForeignList.Size = new Size(155, 34);
            ForeignList.TabIndex = 2;
            ForeignList.Text = "Foreign Music";
            ForeignList.Click += ForeignList_Click;
            ForeignList.MouseEnter += ForeignList_MouseEnter;
            ForeignList.MouseLeave += ForeignList_MouseLeave;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.favorite1;
            pictureBox1.Location = new Point(23, 345);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += likedSong_Click;
            pictureBox1.MouseEnter += favorite_MouseEnter;
            pictureBox1.MouseLeave += favorite_MouseLeave;
            // 
            // VNList
            // 
            VNList.AutoSize = true;
            VNList.Cursor = Cursors.Hand;
            VNList.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            VNList.ForeColor = Color.Silver;
            VNList.Location = new Point(77, 25);
            VNList.Name = "VNList";
            VNList.Size = new Size(196, 34);
            VNList.TabIndex = 2;
            VNList.Text = "Vietnamese Music";
            VNList.Click += VNList_Click;
            VNList.MouseEnter += VNList_MouseEnter;
            VNList.MouseLeave += VNList_MouseLeave;
            // 
            // Add
            // 
            Add.BackgroundImageLayout = ImageLayout.Stretch;
            Add.Cursor = Cursors.Hand;
            Add.Image = Properties.Resources.plus;
            Add.Location = new Point(300, 277);
            Add.Name = "Add";
            Add.Size = new Size(40, 40);
            Add.SizeMode = PictureBoxSizeMode.StretchImage;
            Add.TabIndex = 0;
            Add.TabStop = false;
            Add.Click += buttonCreatePlaylist_Click;
            // 
            // recentIcon
            // 
            recentIcon.BackgroundImageLayout = ImageLayout.Stretch;
            recentIcon.Cursor = Cursors.Hand;
            recentIcon.Image = Properties.Resources.recently_none;
            recentIcon.Location = new Point(22, 154);
            recentIcon.Name = "recentIcon";
            recentIcon.Size = new Size(40, 40);
            recentIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            recentIcon.TabIndex = 0;
            recentIcon.TabStop = false;
            recentIcon.Click += recentSong_Click;
            recentIcon.MouseEnter += recentSong_MouseEnter;
            recentIcon.MouseLeave += recentSong_MouseLeave;
            // 
            // vnIcon
            // 
            vnIcon.BackgroundImageLayout = ImageLayout.Stretch;
            vnIcon.Cursor = Cursors.Hand;
            vnIcon.Image = Properties.Resources.Vietnamese_none;
            vnIcon.Location = new Point(16, 17);
            vnIcon.Name = "vnIcon";
            vnIcon.Size = new Size(49, 51);
            vnIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            vnIcon.TabIndex = 0;
            vnIcon.TabStop = false;
            vnIcon.Click += VNList_Click;
            vnIcon.MouseEnter += VNList_MouseEnter;
            vnIcon.MouseLeave += VNList_MouseLeave;
            // 
            // foreignIcon
            // 
            foreignIcon.BackgroundImageLayout = ImageLayout.Stretch;
            foreignIcon.Cursor = Cursors.Hand;
            foreignIcon.Image = Properties.Resources.note_none;
            foreignIcon.Location = new Point(16, 86);
            foreignIcon.Name = "foreignIcon";
            foreignIcon.Size = new Size(49, 51);
            foreignIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            foreignIcon.TabIndex = 0;
            foreignIcon.TabStop = false;
            foreignIcon.Click += ForeignList_Click;
            foreignIcon.MouseEnter += ForeignList_MouseEnter;
            foreignIcon.MouseLeave += ForeignList_MouseLeave;
            // 
            // playListsIcon
            // 
            playListsIcon.BackgroundImageLayout = ImageLayout.Stretch;
            playListsIcon.Image = Properties.Resources.playlist;
            playListsIcon.Location = new Point(22, 287);
            playListsIcon.Name = "playListsIcon";
            playListsIcon.Size = new Size(95, 37);
            playListsIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            playListsIcon.TabIndex = 0;
            playListsIcon.TabStop = false;
            // 
            // yourLibraryIcon
            // 
            yourLibraryIcon.BackgroundImageLayout = ImageLayout.Stretch;
            yourLibraryIcon.Image = Properties.Resources.Library;
            yourLibraryIcon.Location = new Point(22, 222);
            yourLibraryIcon.Name = "yourLibraryIcon";
            yourLibraryIcon.Size = new Size(36, 37);
            yourLibraryIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            yourLibraryIcon.TabIndex = 0;
            yourLibraryIcon.TabStop = false;
            // 
            // homeTab
            // 
            homeTab.Location = new Point(401, 140);
            homeTab.Name = "homeTab";
            homeTab.Size = new Size(1912, 843);
            homeTab.TabIndex = 6;
            // 
            // pictureBox5
            // 
            pictureBox5.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox5.Image = Properties.Resources.left_arrow;
            pictureBox5.Location = new Point(32, 14);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(61, 63);
            pictureBox5.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox5.TabIndex = 0;
            pictureBox5.TabStop = false;
            // 
            // pictureBox7
            // 
            pictureBox7.BackgroundImage = Properties.Resources.right_arrow;
            pictureBox7.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox7.Location = new Point(121, 14);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(61, 63);
            pictureBox7.TabIndex = 0;
            pictureBox7.TabStop = false;
            // 
            // nextPanel
            // 
            nextPanel.BackColor = Color.FromArgb(64, 64, 64);
            nextPanel.Controls.Add(pictureBox7);
            nextPanel.Controls.Add(pictureBox5);
            nextPanel.Location = new Point(401, 35);
            nextPanel.Name = "nextPanel";
            nextPanel.Size = new Size(1482, 88);
            nextPanel.TabIndex = 4;
            // 
            // searchTab
            // 
            searchTab.BackColor = Color.FromArgb(64, 64, 64);
            searchTab.Location = new Point(401, 142);
            searchTab.Name = "searchTab";
            searchTab.Size = new Size(1482, 841);
            searchTab.TabIndex = 1;
            searchTab.Visible = false;
            // 
            // vnTab
            // 
            vnTab.Location = new Point(401, 142);
            vnTab.Name = "vnTab";
            vnTab.Size = new Size(1482, 841);
            vnTab.TabIndex = 7;
            vnTab.Visible = false;
            // 
            // foreignTab
            // 
            foreignTab.Location = new Point(401, 142);
            foreignTab.Name = "foreignTab";
            foreignTab.Size = new Size(1482, 841);
            foreignTab.TabIndex = 8;
            foreignTab.Visible = false;
            // 
            // recentTab
            // 
            recentTab.Location = new Point(401, 142);
            recentTab.Name = "recentTab";
            recentTab.Size = new Size(2285, 1339);
            recentTab.TabIndex = 9;
            recentTab.Visible = false;
            // 
            // favoriteTab
            // 
            favoriteTab.BackColor = Color.FromArgb(64, 64, 64);
            favoriteTab.Location = new Point(401, 142);
            favoriteTab.Name = "favoriteTab";
            favoriteTab.Size = new Size(1480, 840);
            favoriteTab.TabIndex = 10;
            favoriteTab.Visible = false;
            // 
            // playlistTab
            // 
            playlistTab.Location = new Point(401, 139);
            playlistTab.Name = "playlistTab";
            playlistTab.Size = new Size(1851, 1071);
            playlistTab.TabIndex = 4;
            playlistTab.Visible = false;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Black;
            ClientSize = new Size(1890, 1002);
            Controls.Add(playlistTab);
            Controls.Add(favoriteTab);
            Controls.Add(recentTab);
            Controls.Add(foreignTab);
            Controls.Add(vnTab);
            Controls.Add(searchTab);
            Controls.Add(homeTab);
            Controls.Add(closeBtn);
            Controls.Add(libraryPanel);
            Controls.Add(nextPanel);
            Controls.Add(homePanel);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "Main";
            Text = " ";
            ((System.ComponentModel.ISupportInitialize)closeBtn).EndInit();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)searchIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)homeIcon).EndInit();
            libraryPanel.ResumeLayout(false);
            libraryPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)Add).EndInit();
            ((System.ComponentModel.ISupportInitialize)recentIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)vnIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)foreignIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)playListsIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)yourLibraryIcon).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            nextPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private PictureBox closeBtn;
        private Panel homePanel;
        private Label Search;
        private Label Home;
        private PictureBox searchIcon;
        private PictureBox homeIcon;
        private Label YourLibrary;
        private Panel libraryPanel;
        private PictureBox playListsIcon;
        private PictureBox yourLibraryIcon;
        private Elements.Home homeTab;
        private Label ForeignList;
        private Label VNList;
        private PictureBox pictureBox5;
        private PictureBox pictureBox7;
        private Panel nextPanel;
        private Elements.Search searchTab;
        private PictureBox foreignIcon;
        private PictureBox vnIcon;
        private Elements.VNList vnTab;
        private Elements.ForeignList foreignTab;
        private Label recentSong;
        private PictureBox recentIcon;
        private Elements.Recently recentTab;
        private Label likedSong;
        private PictureBox pictureBox1;
        private Elements.LikedSong favoriteTab;
        private PictureBox Add;
        private FlowLayoutPanel playlist;
        private Elements.PlayList playlistTab;
    }
}
