using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BTTH02.Elements
{
    public partial class PlayList : UserControl
    {
        private string playlistName;
        public PlayList()
        {
            InitializeComponent();
            bgPanel.BackColor = ColorTranslator.FromHtml("#523a9e");
            playlistIcon.BackColor = ColorTranslator.FromHtml("#523a9e");
            bgPanel.BackColor = ColorTranslator.FromHtml("#523a9e");
            play.BackColor = ColorTranslator.FromHtml("#523a9e");
            favoritePanel.BackColor = ColorTranslator.FromHtml("#121212");
            list.BackColor = ColorTranslator.FromHtml("#121212");

        }

        public void setPlayListName(string name)
        {
            playlistName = name;
        }
        public void ReadFileAndAssignToVariable()
        {
            try
            {

                string filePath = Path.Combine("C:\\C#\\Spotify\\Database\\playList", playlistName + ".txt");

                list.Controls.Clear();

                // Kiểm tra xem tệp tin có tồn tại không
                if (File.Exists(filePath))
                {
                    myPlaylist.Text = playlistName;
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
                            song.SongClicked += Song_SongClicked;
                            list.Controls.Add(song);
                            // Để lưu trữ nhiều giá trị, bạn có thể sử dụng List<string> hoặc mảng
                            // Ví dụ: List<string> lines = new List<string>();
                            //        lines.Add(tmp);
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

        //Phương thức để đếm số dòng trong file
        private static int CountLines(string filePath)
        {
            return File.ReadLines(filePath).Count();
        }


    }
}
