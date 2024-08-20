using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH02.Elements
{
    public partial class playlistItem : UserControl
    {
        public bool inPlaylist = false;
        public string playlistName;
        public playlistItem()
        {
            InitializeComponent();
            itemPanel.BackColor = ColorTranslator.FromHtml("#121212");
        }

        public void getNameList(string name)
        {
            listName.Text = name;
            playlistName = name;
        }

        public event EventHandler ItemClicked;
        private void Item_Click(object sender, EventArgs e)
        {
            ItemClicked?.Invoke(this, EventArgs.Empty);
            //inPlaylist = true;
        }
        public event EventHandler MinusClicked;
        private void Minus_Click(object sender, EventArgs e)
        {
            MinusClicked?.Invoke(this, EventArgs.Empty);
            //inPlaylist = true;
        }

        private void listName_MouseEnter(object sender, EventArgs e)
        {
            
            
                listName.ForeColor = Color.White;
                itemPanel.BackColor = ColorTranslator.FromHtml("#282828");
            
        }

        private void listName_MouseLeave(object sender, EventArgs e)
        {
            
            
                listName.ForeColor = Color.Silver;
                itemPanel.BackColor = ColorTranslator.FromHtml("#121212");

            
        }

        public bool getInPlayList()
        {
            return inPlaylist;
        }

        public void setInPlayList(bool state)
        {
            inPlaylist = state;
        }
    }
}
