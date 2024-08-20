namespace BTTH02.Elements
{
    partial class playlistItem
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
            itemPanel = new Panel();
            listName = new Label();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            itemPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // itemPanel
            // 
            itemPanel.BackColor = Color.FromArgb(64, 64, 64);
            itemPanel.Controls.Add(listName);
            itemPanel.Controls.Add(pictureBox2);
            itemPanel.Controls.Add(pictureBox1);
            itemPanel.Cursor = Cursors.Hand;
            itemPanel.Location = new Point(0, 0);
            itemPanel.Name = "itemPanel";
            itemPanel.Size = new Size(364, 75);
            itemPanel.TabIndex = 0;
            itemPanel.Click += Item_Click;
            itemPanel.MouseEnter += listName_MouseEnter;
            itemPanel.MouseLeave += listName_MouseLeave;
            // 
            // listName
            // 
            listName.AutoSize = true;
            listName.Font = new Font("Sublima ExtraBold", 12F, FontStyle.Bold);
            listName.ForeColor = Color.Silver;
            listName.Location = new Point(70, 17);
            listName.Name = "listName";
            listName.Size = new Size(153, 34);
            listName.TabIndex = 1;
            listName.Text = "My Playlist #1";
            listName.Click += Item_Click;
            listName.MouseEnter += listName_MouseEnter;
            listName.MouseLeave += listName_MouseLeave;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = Properties.Resources.minusIcon;
            pictureBox2.Location = new Point(279, 17);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 40);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 0;
            pictureBox2.TabStop = false;
            pictureBox2.Click += Minus_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.playlistImg;
            pictureBox1.Location = new Point(0, 7);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // playlistItem
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(itemPanel);
            Name = "playlistItem";
            Size = new Size(412, 73);
            itemPanel.ResumeLayout(false);
            itemPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel itemPanel;
        private Label listName;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}
