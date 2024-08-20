namespace BTTH02.Elements
{
    partial class ForeignList
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
            foreignPanel = new Panel();
            infoTab = new SongInfo();
            listSong = new FlowLayoutPanel();
            Title = new Panel();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            foreignPanel.SuspendLayout();
            Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // foreignPanel
            // 
            foreignPanel.BackColor = Color.FromArgb(64, 64, 64);
            foreignPanel.Controls.Add(infoTab);
            foreignPanel.Controls.Add(listSong);
            foreignPanel.Controls.Add(Title);
            foreignPanel.Location = new Point(0, 0);
            foreignPanel.Name = "foreignPanel";
            foreignPanel.Size = new Size(1490, 803);
            foreignPanel.TabIndex = 0;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(2, 1);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1828, 1071);
            infoTab.TabIndex = 0;
            infoTab.Visible = false;
            // 
            // listSong
            // 
            listSong.AutoScroll = true;
            listSong.BackColor = Color.FromArgb(255, 192, 192);
            listSong.Location = new Point(19, 317);
            listSong.Name = "listSong";
            listSong.Size = new Size(1442, 469);
            listSong.TabIndex = 2;
            // 
            // Title
            // 
            Title.BackColor = Color.FromArgb(255, 192, 192);
            Title.Controls.Add(label2);
            Title.Controls.Add(label6);
            Title.Controls.Add(label1);
            Title.Controls.Add(pictureBox1);
            Title.Location = new Point(19, 21);
            Title.Name = "Title";
            Title.Size = new Size(1443, 271);
            Title.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sublima ExtraBold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.Firebrick;
            label2.Location = new Point(301, 186);
            label2.Name = "label2";
            label2.Size = new Size(314, 40);
            label2.TabIndex = 3;
            label2.Text = "EDM, Dynamic, Unique,...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sublima ExtraBold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(298, 52);
            label6.Name = "label6";
            label6.Size = new Size(173, 40);
            label6.TabIndex = 3;
            label6.Text = "Let's explore";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sublima ExtraBold", 40F, FontStyle.Bold);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(290, 74);
            label1.Name = "label1";
            label1.Size = new Size(511, 112);
            label1.TabIndex = 3;
            label1.Text = "Foreign Music";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._19;
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // ForeignList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(foreignPanel);
            Name = "ForeignList";
            Size = new Size(1490, 803);
            foreignPanel.ResumeLayout(false);
            Title.ResumeLayout(false);
            Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel foreignPanel;
        private Panel Title;
        private Label label2;
        private Label label6;
        private Label label1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel listSong;
        private SongInfo infoTab;
    }
}
