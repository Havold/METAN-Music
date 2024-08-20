namespace BTTH02.Elements
{
    partial class Song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Song));
            Item = new Panel();
            ArtistName = new Label();
            SongName = new Label();
            songImg = new PictureBox();
            Item.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)songImg).BeginInit();
            SuspendLayout();
            // 
            // Item
            // 
            Item.BackColor = Color.FromArgb(64, 64, 64);
            Item.BorderStyle = BorderStyle.FixedSingle;
            Item.Controls.Add(ArtistName);
            Item.Controls.Add(SongName);
            Item.Controls.Add(songImg);
            Item.Cursor = Cursors.Hand;
            Item.Location = new Point(0, 0);
            Item.Margin = new Padding(24);
            Item.Name = "Item";
            Item.Size = new Size(278, 370);
            Item.TabIndex = 2;
            Item.Click += Song_Click;
            Item.MouseEnter += SelectMouseEnter;
            Item.MouseLeave += SelectMouseLeave;
            // 
            // ArtistName
            // 
            ArtistName.AutoSize = true;
            ArtistName.Font = new Font("Roboto Condensed", 10F, FontStyle.Bold);
            ArtistName.ForeColor = Color.DarkGray;
            ArtistName.Location = new Point(15, 315);
            ArtistName.Name = "ArtistName";
            ArtistName.Size = new Size(85, 22);
            ArtistName.TabIndex = 2;
            ArtistName.Text = "Obito, MCK";
            ArtistName.Click += Song_Click;
            ArtistName.MouseEnter += SelectMouseEnter;
            ArtistName.MouseLeave += SelectMouseLeave;
            // 
            // SongName
            // 
            SongName.AutoSize = true;
            SongName.Font = new Font("Roboto Condensed", 16F, FontStyle.Bold);
            SongName.ForeColor = Color.White;
            SongName.Location = new Point(10, 278);
            SongName.Name = "SongName";
            SongName.Size = new Size(112, 33);
            SongName.TabIndex = 1;
            SongName.Text = "Đánh Đổi";
            SongName.Click += Song_Click;
            SongName.MouseEnter += SelectMouseEnter;
            SongName.MouseLeave += SelectMouseLeave;
            // 
            // songImg
            // 
            songImg.BackgroundImageLayout = ImageLayout.Stretch;
            songImg.Cursor = Cursors.Hand;
            songImg.Image = (Image)resources.GetObject("songImg.Image");
            songImg.Location = new Point(15, 17);
            songImg.Name = "songImg";
            songImg.Size = new Size(247, 249);
            songImg.SizeMode = PictureBoxSizeMode.StretchImage;
            songImg.TabIndex = 0;
            songImg.TabStop = false;
            songImg.Click += Song_Click;
            songImg.MouseEnter += SelectMouseEnter;
            songImg.MouseLeave += SelectMouseLeave;
            // 
            // Song
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Item);
            Name = "Song";
            Size = new Size(275, 366);
            Item.ResumeLayout(false);
            Item.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)songImg).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Item;
        private Label ArtistName;
        private Label SongName;
        private PictureBox songImg;
    }
}
