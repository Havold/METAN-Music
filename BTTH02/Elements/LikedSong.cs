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
    public partial class LikedSong : UserControl
    {
        string filePath = "C:\\C#\\Spotify\\Database\\favorite\\favorite.txt";
        private List<Song> LikedSongs = new List<Song>();
        private Song[] songArray;

        public LikedSong()
        {
            InitializeComponent();
            songArray = new Song[31];
            Playlist.BackColor = ColorTranslator.FromHtml("#523a9e");
            likedSongs.BackColor = ColorTranslator.FromHtml("#523a9e");
            favoriteIcon.BackColor = ColorTranslator.FromHtml("#523a9e");
            bgPanel.BackColor = ColorTranslator.FromHtml("#523a9e");
            favoritePanel.BackColor = ColorTranslator.FromHtml("#121212");
            likeList.BackColor = ColorTranslator.FromHtml("#121212");
            //ReadFileAndAssignToVariable();
        }

        public void LoadListSong()
        {
            likeList.Controls.Clear();
            for (int i = 1; i <= 30; i++)
            {
                Song song = new Song();
                song.readDataSong(i);
                song.SongClicked += Song_SongClicked;
                songArray[i] = song;
                if (song.favorite)
                {
                likeList.Controls.Add(song);
                }
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

        /*public void ReadFileAndAssignToVariable()
        {
            try
            {
                likeList.Controls.Clear();

                // Kiểm tra xem tệp tin có tồn tại không
                if (File.Exists(filePath))
                {
                    if (CountLines(filePath) == 0)
                    {

                    }
                    else
                    {
                        // Sử dụng StreamReader để đọc từng dòng trong tệp tin
                        using (StreamReader reader = new StreamReader(filePath))
                        {
                            string tmp;

                            foreach (string line in File.ReadLines(filePath))
                            {
                                Song song = new Song();

                                int.TryParse(line, out int intValue);
                                // Lưu trạng thái số dòng đã đọc trước đó
                                song.readDataSong(intValue);
                                // Đọc những dòng mới được thêm vào file

                                likeList.Controls.Add(song);
                                // Để lưu trữ nhiều giá trị, bạn có thể sử dụng List<string> hoặc mảng
                                // Ví dụ: List<string> lines = new List<string>();
                                //        lines.Add(tmp);
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy tệp tin.");
                }
            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi khi đọc tệp tin
                MessageBox.Show("Đã xảy ra lỗi khi đọc tệp tin: " + ex.Message);
            }
        }
        */


        // Phương thức để đếm số dòng trong file
        /*private static int CountLines(string filePath)
        {
            return File.ReadLines(filePath).Count();
        }/*/


    }
}
