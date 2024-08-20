namespace BTTH02.Elements
{
    partial class Search
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
            SearchBox = new TextBox();
            listSong = new FlowLayoutPanel();
            searchBar = new PictureBox();
            pictureBox2 = new PictureBox();
            SearchPanel = new Panel();
            artistSearch = new RadioButton();
            songSearch = new RadioButton();
            infoTab = new SongInfo();
            ((System.ComponentModel.ISupportInitialize)searchBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SearchPanel.SuspendLayout();
            SuspendLayout();
            // 
            // SearchBox
            // 
            SearchBox.BackColor = Color.FromArgb(32, 32, 32);
            SearchBox.BorderStyle = BorderStyle.None;
            SearchBox.Cursor = Cursors.IBeam;
            SearchBox.Font = new Font("Roboto Condensed", 10F, FontStyle.Bold);
            SearchBox.ForeColor = Color.White;
            SearchBox.Location = new Point(94, 35);
            SearchBox.Name = "SearchBox";
            SearchBox.Size = new Size(368, 21);
            SearchBox.TabIndex = 0;
            SearchBox.Click += searchBarActive;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // listSong
            // 
            listSong.AutoScroll = true;
            listSong.Location = new Point(23, 87);
            listSong.Name = "listSong";
            listSong.Size = new Size(1434, 722);
            listSong.TabIndex = 1;
            // 
            // searchBar
            // 
            searchBar.Image = Properties.Resources.Asset_2;
            searchBar.Location = new Point(23, 18);
            searchBar.Name = "searchBar";
            searchBar.Size = new Size(469, 55);
            searchBar.SizeMode = PictureBoxSizeMode.StretchImage;
            searchBar.TabIndex = 2;
            searchBar.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(32, 32, 32);
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Image = Properties.Resources.find_none;
            pictureBox2.Location = new Point(44, 28);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // SearchPanel
            // 
            SearchPanel.Controls.Add(artistSearch);
            SearchPanel.Controls.Add(songSearch);
            SearchPanel.Location = new Point(3, 3);
            SearchPanel.Name = "SearchPanel";
            SearchPanel.Size = new Size(1473, 857);
            SearchPanel.TabIndex = 4;
            // 
            // artistSearch
            // 
            artistSearch.AutoSize = true;
            artistSearch.Cursor = Cursors.Hand;
            artistSearch.Font = new Font("Sublima ExtraBold", 16F, FontStyle.Bold);
            artistSearch.ForeColor = Color.White;
            artistSearch.Location = new Point(1146, 20);
            artistSearch.Name = "artistSearch";
            artistSearch.Size = new Size(118, 49);
            artistSearch.TabIndex = 0;
            artistSearch.Text = "Artist";
            artistSearch.UseVisualStyleBackColor = true;
            artistSearch.Click += artistSearch_Click;
            // 
            // songSearch
            // 
            songSearch.AutoSize = true;
            songSearch.Checked = true;
            songSearch.Cursor = Cursors.Hand;
            songSearch.Font = new Font("Sublima ExtraBold", 16F, FontStyle.Bold);
            songSearch.ForeColor = Color.White;
            songSearch.Location = new Point(951, 21);
            songSearch.Name = "songSearch";
            songSearch.Size = new Size(110, 49);
            songSearch.TabIndex = 0;
            songSearch.TabStop = true;
            songSearch.Text = "Song";
            songSearch.UseVisualStyleBackColor = true;
            songSearch.Click += songSearch_Click;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(0, 0);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1851, 1071);
            infoTab.TabIndex = 5;
            infoTab.Visible = false;
            // 
            // Search
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            Controls.Add(infoTab);
            Controls.Add(pictureBox2);
            Controls.Add(listSong);
            Controls.Add(SearchBox);
            Controls.Add(searchBar);
            Controls.Add(SearchPanel);
            Name = "Search";
            Size = new Size(1540, 925);
            ((System.ComponentModel.ISupportInitialize)searchBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            SearchPanel.ResumeLayout(false);
            SearchPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox SearchBox;
        private FlowLayoutPanel listSong;
        private PictureBox searchBar;
        private PictureBox pictureBox2;
        private Panel SearchPanel;
        private RadioButton songSearch;
        private RadioButton artistSearch;
        private SongInfo infoTab;
    }
}
