namespace BTTH02.Elements
{
    partial class Recently
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
            recentlyPanel = new Panel();
            infoTab = new SongInfo();
            songName = new Label();
            recentList = new FlowLayoutPanel();
            recentlyPanel.SuspendLayout();
            SuspendLayout();
            // 
            // recentlyPanel
            // 
            recentlyPanel.BackColor = Color.FromArgb(64, 64, 64);
            recentlyPanel.Controls.Add(infoTab);
            recentlyPanel.Controls.Add(songName);
            recentlyPanel.Controls.Add(recentList);
            recentlyPanel.Location = new Point(0, 0);
            recentlyPanel.Name = "recentlyPanel";
            recentlyPanel.Size = new Size(1489, 845);
            recentlyPanel.TabIndex = 0;
            // 
            // infoTab
            // 
            infoTab.Location = new Point(0, -3);
            infoTab.Name = "infoTab";
            infoTab.Size = new Size(1851, 846);
            infoTab.TabIndex = 1;
            infoTab.Visible = false;
            // 
            // songName
            // 
            songName.AutoSize = true;
            songName.Font = new Font("Sublima ExtraBold", 30F, FontStyle.Bold);
            songName.ForeColor = Color.White;
            songName.Location = new Point(16, 14);
            songName.Name = "songName";
            songName.Size = new Size(379, 84);
            songName.TabIndex = 3;
            songName.Text = "Recent Songs";
            // 
            // recentList
            // 
            recentList.AutoScroll = true;
            recentList.Location = new Point(32, 116);
            recentList.Name = "recentList";
            recentList.Size = new Size(1753, 727);
            recentList.TabIndex = 3;
            // 
            // Recently
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(recentlyPanel);
            Name = "Recently";
            Size = new Size(1828, 1071);
            recentlyPanel.ResumeLayout(false);
            recentlyPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel recentlyPanel;
        private FlowLayoutPanel recentList;
        private Label songName;
        private SongInfo infoTab;
    }
}
