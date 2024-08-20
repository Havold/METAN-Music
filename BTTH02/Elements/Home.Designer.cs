namespace BTTH02.Elements
{
    partial class Home
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
            label7 = new Label();
            panel4 = new Panel();
            pictureBox8 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            label4 = new Label();
            homePanel = new Panel();
            infoTab = new SongInfo();
            listSong = new FlowLayoutPanel();
            pictureBox1 = new PictureBox();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            homePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Sublima ExtraBold", 20F, FontStyle.Bold);
            label7.ForeColor = Color.White;
            label7.Location = new Point(30, 306);
            label7.Name = "label7";
            label7.Size = new Size(440, 57);
            label7.TabIndex = 2;
            label7.Text = "Recommended for today";
            // 
            // panel4
            // 
            panel4.BackColor = Color.Black;
            panel4.Controls.Add(pictureBox8);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label6);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(30, 28);
            panel4.Name = "panel4";
            panel4.Size = new Size(1427, 275);
            panel4.TabIndex = 3;
            // 
            // pictureBox8
            // 
            pictureBox8.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox8.Image = Properties.Resources.Untitled_2;
            pictureBox8.Location = new Point(1105, 40);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(290, 204);
            pictureBox8.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox8.TabIndex = 3;
            pictureBox8.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("VALORANT", 50F, FontStyle.Bold);
            label5.ForeColor = Color.IndianRed;
            label5.Location = new Point(547, 72);
            label5.Name = "label5";
            label5.Size = new Size(374, 84);
            label5.TabIndex = 2;
            label5.Text = "METAN";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sublima ExtraBold", 20F, FontStyle.Bold);
            label6.ForeColor = Color.White;
            label6.Location = new Point(38, 177);
            label6.Name = "label6";
            label6.Size = new Size(518, 57);
            label6.TabIndex = 2;
            label6.Text = "Let's listen the song you love";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sublima ExtraBold", 50F, FontStyle.Bold);
            label4.ForeColor = Color.White;
            label4.Location = new Point(17, 25);
            label4.Name = "label4";
            label4.Size = new Size(553, 141);
            label4.TabIndex = 2;
            label4.Text = "Welcome to";
            // 
            // homePanel
            // 
            homePanel.AutoScroll = true;
            homePanel.BackColor = Color.FromArgb(64, 64, 64);
            homePanel.BackgroundImageLayout = ImageLayout.Stretch;
            homePanel.Controls.Add(infoTab);
            homePanel.Controls.Add(listSong);
            homePanel.Controls.Add(panel4);
            homePanel.Controls.Add(label7);
            homePanel.Location = new Point(0, 0);
            homePanel.Name = "homePanel";
            homePanel.Size = new Size(1480, 925);
            homePanel.TabIndex = 3;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(1, 3);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1490, 1071);
            infoTab.TabIndex = 0;
            infoTab.Visible = false;
            // 
            // listSong
            // 
            listSong.AutoScroll = true;
            listSong.Location = new Point(30, 381);
            listSong.Name = "listSong";
            listSong.Size = new Size(1427, 442);
            listSong.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(1879, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(31, 24);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox1);
            Controls.Add(homePanel);
            Name = "Home";
            Size = new Size(1480, 925);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            homePanel.ResumeLayout(false);
            homePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label label7;
        private Panel panel4;
        private PictureBox pictureBox8;
        private Label label5;
        private Label label6;
        private Label label4;
        private Panel panel3;
        private PictureBox pictureBox1;
        private FlowLayoutPanel listSong;
        private Panel homePanel;
        private SongInfo infoTab;
    }
}
