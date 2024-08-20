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
    public partial class Recently : UserControl
    {
        string filePath = "C:\\C#\\Spotify\\Database\\recent\\recent.txt"; // Thay đổi đường dẫn tới tệp tin của bạn
        int linesReadBefore;

        private List<Song> recentlyPlayedSongs = new List<Song>();
        public Recently()
        {
            ResetFile(filePath);
            linesReadBefore = CountLines(filePath);
            InitializeComponent();
            ReadFileAndAssignToVariable();
            recentlyPanel.BackColor = ColorTranslator.FromHtml("#121212");
        }
        private static void ResetFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }

        public void ReadFileAndAssignToVariable()
        {
            try
            {
                // Đường dẫn của tệp tin txt chứa index

                // Kiểm tra xem tệp tin có tồn tại không
                if (File.Exists(filePath))
                {
                    // Sử dụng StreamReader để đọc từng dòng trong tệp tin
                    using (StreamReader reader = new StreamReader(filePath))
                    {
                        recentList.Controls.Clear();

                        foreach (string line in File.ReadLines(filePath))
                        {
                            Song song = new Song();
                            int.TryParse(line, out int intValue);
                            song.readDataSong(intValue);
                            song.SongClicked += Song_SongClicked;

                            recentList.Controls.Add(song);
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

        // Phương thức để đếm số dòng trong file
        private static int CountLines(string filePath)
        {
            return File.ReadLines(filePath).Count();
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
