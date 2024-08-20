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
    public partial class ForeignList : UserControl
    {
        private Song[] songArray;
        public ForeignList()
        {
            InitializeComponent();
            songArray = new Song[31];
            LoadListSong();
            foreignPanel.BackColor = ColorTranslator.FromHtml("#121212");
        }

        public void LoadListSong()
        {
            for (int i = 16; i <= 30; i++)
            {
                Song song = new Song();
                song.readDataSong(i);
                song.SongClicked += Song_SongClicked;
                songArray[i] = song;
                listSong.Controls.Add(song);
            }
        }

        private void Song_SongClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Song được bấm
            if (sender is Song clickedSong)
            {
                // Bạn có thể sử dụng songIndex theo cách bạn muốn
                infoTab.setSong(clickedSong);
                infoTab.Visible = true;
                infoTab.resetInforTab();
            }
        }
    }
}
