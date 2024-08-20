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
    public partial class Search : UserControl
    {
        private Song[] songArray;

        public Search()
        {
            InitializeComponent();
            songArray = new Song[31];
            LoadListSong();
            SearchPanel.BackColor = ColorTranslator.FromHtml("#121212");
            searchBar.BackColor = ColorTranslator.FromHtml("#121212");

        }

        private void searchBarActive(object sender, EventArgs e)
        {
            searchBar.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\searchBarActive.png");
        }

        public void LoadListSong()
        {
            for (int i = 1; i <= 30; i++)
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

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {
            // Gọi hàm thực hiện tìm kiếm khi nội dung của TextBox thay đổi
            PerformSearch(SearchBox.Text);
        }

        private void PerformSearch(string searchTerm)
        {

            // Xóa các UserControl hiện tại trong FlowLayoutPanel
            listSong.Controls.Clear();


            for (int i = 1; i <= 30; i++)
            {
                Song song = new Song();
                if (songSearch.Checked)
                {
                    if (song.searchSong(i, searchTerm))
                    {
                        song.readDataSong(i);
                        song.SongClicked += Song_SongClicked;
                        songArray[i] = song;
                        listSong.Controls.Add(song);
                    }
                }
                else
                {
                    if (song.searchArtist(i, searchTerm))
                    {
                        song.readDataSong(i);
                        song.SongClicked += Song_SongClicked;
                        songArray[i] = song;
                        listSong.Controls.Add(song);
                    }
                }
            }
        }


        private void songSearch_Click(object sender, EventArgs e)
        {
            songSearch.Checked = true;
            artistSearch.Checked = false;
        }

        private void artistSearch_Click(object sender, EventArgs e)
        {
            songSearch.Checked = false;
            artistSearch.Checked = true;
        }
    }
}
