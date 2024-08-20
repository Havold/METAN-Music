namespace BTTH02.Elements
{
    partial class VNList
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
            vnPanel = new Panel();
            listSong = new FlowLayoutPanel();
            Title = new Panel();
            label2 = new Label();
            label6 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            infoTab = new SongInfo();
            vnPanel.SuspendLayout();
            Title.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // vnPanel
            // 
            vnPanel.BackColor = Color.FromArgb(64, 64, 64);
            vnPanel.Controls.Add(listSong);
            vnPanel.Controls.Add(Title);
            vnPanel.Location = new Point(0, 0);
            vnPanel.Name = "vnPanel";
            vnPanel.Size = new Size(1490, 803);
            vnPanel.TabIndex = 0;
            // 
            // listSong
            // 
            listSong.AutoScroll = true;
            listSong.BackColor = Color.Lavender;
            listSong.Location = new Point(19, 311);
            listSong.Name = "listSong";
            listSong.Size = new Size(1443, 469);
            listSong.TabIndex = 1;
            // 
            // Title
            // 
            Title.BackColor = Color.Lavender;
            Title.Controls.Add(label2);
            Title.Controls.Add(label6);
            Title.Controls.Add(label1);
            Title.Controls.Add(pictureBox1);
            Title.Location = new Point(19, 21);
            Title.Name = "Title";
            Title.Size = new Size(1443, 271);
            Title.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sublima ExtraBold", 14F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(0, 0, 64);
            label2.Location = new Point(301, 186);
            label2.Name = "label2";
            label2.Size = new Size(402, 40);
            label2.TabIndex = 3;
            label2.Text = "Hip Hop, Romantic, Depostion,...";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Sublima ExtraBold", 14F, FontStyle.Bold);
            label6.ForeColor = Color.FromArgb(0, 0, 192);
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
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(290, 74);
            label1.Name = "label1";
            label1.Size = new Size(654, 112);
            label1.TabIndex = 3;
            label1.Text = "Vietnamese Music";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._04;
            pictureBox1.Location = new Point(21, 22);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(250, 227);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(0, 0);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1828, 1071);
            infoTab.TabIndex = 0;
            infoTab.Visible = false;
            // 
            // VNList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(infoTab);
            Controls.Add(vnPanel);
            Name = "VNList";
            Size = new Size(1540, 814);
            vnPanel.ResumeLayout(false);
            Title.ResumeLayout(false);
            Title.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel vnPanel;
        private Panel Title;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label6;
        private Label label1;
        private FlowLayoutPanel listSong;
        private SongInfo infoTab;
    }
}
