using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace BTTH02.Elements
{
    public partial class SongInfo : UserControl
    {
        private IWavePlayer waveOutDevice;
        private AudioFileReader audioFile;
        private bool isPlaying = false;
        private long savedPosition = 0;
        public bool isFavorite;
        public int index = -1;
        public int currentIndex;
        public int numberDown = 0;
        private string currentURL;
        bool isStar1 = false;
        bool isStar2 = false;
        bool isStar3 = false;
        bool isStar4 = false;
        string url;
        string songName_tmp;
        bool isStar5 = false;
        int indexStar = 0;
        int y = 609;
        public SongInfo()
        {
            InitializeComponent();
            inforPanel.BackColor = ColorTranslator.FromHtml("#121212");
        }

        public void resetInforTab()
        {
            if (currentIndex!=index)
            {
                
                playBtn.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\stopBtn.png");
                cmtList.Controls.Clear();
                resetAllStar();
            }
            else
            {   
                if (isPlaying)
                {
                    playBtn.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\playBtn.png");
                }
            }
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void selectMale_Click(object sender, EventArgs e)
        {
            selectFemale.Checked = false;
            selectMale.Checked = true;
        }

        private void selectFemale_Click(object sender, EventArgs e)
        {
            selectFemale.Checked = true;
            selectMale.Checked = false;
        }

        private void txtComment_KeyDown(object sender, KeyEventArgs e)
        {   
            if (e.KeyValue == 13 && txtComment.Text!=string.Empty)
            {
                Comment cmt = new Comment();
                cmt.content(txtComment.Text, selectMale.Checked);
                cmt.setStar(indexStar);
                cmtList.Controls.Add(cmt);
                txtComment.Text = string.Empty;
                // Di chuyển con trỏ về đầu dòng
                txtComment.SelectionStart = 0;
                txtComment.SelectionLength = 0;

                // Ngăn chặn xự kiện KeyDown tiếp theo (nếu không, con trỏ có thể bị dịch xuống dòng một lần nữa)
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void resetAllStar()
        {
            if (!isStar1)
            {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star_empty.png");
            }
            if (!isStar2)
            {
            star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star_empty.png");
            }
            if (!isStar3)
            {
            star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star_empty.png");
            }
            if (!isStar4)
            {
            star4.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star_empty.png");
            }
            if (!isStar5)
            {
            star5.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star_empty.png");
            }
        }

        private void star1_Click(object sender, EventArgs e)
        {
            isStar1 = true;
            isStar2 = false;
            isStar3 = false;
            isStar4 = false;
            isStar5 = false;
            indexStar = 1;
            resetAllStar();
        }

        private void star1_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
        }

        private void star1_MouseLeave(object sender, EventArgs e)
        {
            resetAllStar();
        }

        private void star2_Click(object sender, EventArgs e)
        {
            isStar1 = true;
            isStar2 = true;
            isStar3 = false;
            isStar4 = false;
            isStar5 = false;
            indexStar = 2;
            resetAllStar();
        }

        private void star2_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
        }


        private void star2_MouseLeave(object sender, EventArgs e)
        {
            resetAllStar();
        }

        private void star3_Click(object sender, EventArgs e)
        {
            isStar1 = true;
            isStar2 = true;
            isStar3 = true;
            isStar4 = false;
            isStar5 = false;
            indexStar = 3;
            resetAllStar();
        }

        private void star3_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
        }


        private void star3_MouseLeave(object sender, EventArgs e)
        {
            resetAllStar();
        }

        private void star4_Click(object sender, EventArgs e)
        {
            isStar1 = true;
            isStar2 = true;
            isStar3 = true;
            isStar4 = true;
            isStar5 = false;
            indexStar = 4;
            resetAllStar();
        }
        private void star4_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star4.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
        }


        private void star4_MouseLeave(object sender, EventArgs e)
        {
            resetAllStar();
        }

        private void star5_Click(object sender, EventArgs e)
        {
            isStar1 = true;
            isStar2 = true;
            isStar3 = true;
            isStar4 = true;
            isStar5 = true;
            indexStar = 5;
            resetAllStar();
        }
        private void star5_MouseEnter(object sender, EventArgs e)
        {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star4.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            star5.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
        }

        private void star5_MouseLeave(object sender, EventArgs e)
        {
            resetAllStar();
        }

        public void setSong(Song song)
        {
            index = song.index_tmp;
            song.readDataSong(index);
            songName.Text = song.songName;
            artistName.Text = song.artistName;
            songImg.Image = Image.FromFile(song.imgPath);
            bgPanel.BackColor = ColorTranslator.FromHtml(song.background);
            url = song.url;
            numberDown = song.download;
            downloadNum.Text = numberDown.ToString();
            songName_tmp = song.songName;
            isFavorite = song.favorite;
            if (isFavorite)
            {
                favorite.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\favorite_show.png");
            }
            else
            {
                favorite.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\favorite_empty.png");
            }
        }
        
        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            // Đặt đường dẫn của tệp nhạc MP3 bạn muốn phát
            string musicFilePath = url; // Điều chỉnh đường dẫn tới tệp MP3 của bạn

            // Kiểm tra xem tệp nhạc có tồn tại không
            if (System.IO.File.Exists(musicFilePath))
            {
                if (!isPlaying)
                {

                    // Dừng bài hát hiện tại (nếu có)
                    StopPlayback();

                    // Khởi tạo đối tượng IWavePlayer và AudioFileReader
                    waveOutDevice = new WaveOut();
                    audioFile = new AudioFileReader(musicFilePath);

                    // Gắn AudioFileReader với WaveOut
                    waveOutDevice.Init(audioFile);

                    if (url!=currentURL)
                    {
                        savedPosition = 0;
                    }
                    currentURL = url;
                    
                    // Thiết lập vị trí phát nhạc từ vị trí đã lưu
                    audioFile.Position = savedPosition;

                    // Bắt đầu phát nhạc
                    playBtn.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\playBtn.png");
                    waveOutDevice.Play();
                    isPlaying = true;
                    currentIndex = index;
                    AppendCurrentSongIndex();
                }
                else
                {
                    // Lưu lại vị trí hiện tại của bài hát
                    savedPosition = audioFile.Position;

                    // Dừng nhạc nếu đang phát
                    StopPlayback();
                    playBtn.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\stopBtn.png");
                    isPlaying = false;
                }
            }
            else
            {
                MessageBox.Show("Không tìm thấy tệp nhạc.");
            }
        }

        private void AppendCurrentSongIndex()
        {
            try
            {
                // Đường dẫn của tệp tin txt chứa index
                string filePath = "C:\\C#\\Spotify\\Database\\recent\\recent.txt"; // Thay đổi đường dẫn tới tệp tin của bạn

                // Đọc toàn bộ nội dung của tệp tin
                string[] lines = File.ReadAllLines(filePath);

                // Kiểm tra xem phần tử đã tồn tại trong tệp tin hay chưa
                if (!Array.Exists(lines, element => element == index.ToString()))
                {
                    // Nếu phần tử chưa tồn tại, thêm vào cuối tệp tin
                    AddNewLine(filePath, index);
                }
                else
                {
                    // Nếu phần tử đã tồn tại, xóa nó và thêm mới
                    lines = lines.Where(element => element != index.ToString()).ToArray();
                    File.WriteAllLines(filePath, lines);
                    AddNewLine(filePath, index);

                }

            }
            catch (Exception ex)
            {
                // Xử lý nếu có lỗi khi thêm vào tệp tin
                MessageBox.Show("Đã xảy ra lỗi khi thêm vào tệp tin: " + ex.Message);
            }
        }

        // Phương thức để thêm một dòng mới vào đầu file
        private static void AddNewLineToBeginning(string filePath, string newLine)
        {
            // Đọc toàn bộ nội dung file vào một danh sách
            List<string> lines = File.ReadAllLines(filePath).ToList();

            // Thêm dòng mới vào đầu danh sách
            lines.Insert(0, newLine);

            // Ghi lại toàn bộ danh sách vào file
            File.WriteAllLines(filePath, lines);

        }

        //Hàm thêm một dòng mới vào file .txt
        private static void AddNewLine(string filePath, int newLine)
        {
            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(newLine);
            }
 
        }

        private void StopPlayback()
        {
            // Dừng bài hát nếu đang phát
            if (waveOutDevice != null)
            {
                waveOutDevice.Stop();
                waveOutDevice.Dispose();
            }

            if (audioFile != null)
            {
                audioFile.Dispose();
            }
        }

        private void favorire_Click(object sender, EventArgs e)
        {
            if (!isFavorite)
            {
                favorite.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\favorite_show.png");
                //AppendFavoriteSongIndex();
                Song song = new Song();
                song.updateFavorite(index, true);
                isFavorite = true;
            }
            else
            {
                favorite.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\favorite_empty.png");
                //string tmp = index.ToString();
                //RemoveFavoriteSongIndex(favoritePath, tmp);
                Song song = new Song();
                song.updateFavorite(index, false);
                isFavorite = false;
            }
        }

        private void buttonDownload_Click(object sender, EventArgs e)
        {
            // Đường dẫn đến file MP3 trên máy tính của bạn
            string mp3FilePath = url;

            // Hiển thị hộp thoại SaveFileDialog để chọn nơi để lưu file
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "MP3 Files|*.mp3";
            saveFileDialog.Title = "Save MP3 File";
            saveFileDialog.FileName = $"{songName_tmp}.mp3"; // Tên mặc định khi tải xuống
            DialogResult result = saveFileDialog.ShowDialog();

            // Kiểm tra xem người dùng đã chọn nơi để lưu hay chưa
            if (result == DialogResult.OK)
            {
                string destinationPath = saveFileDialog.FileName;

                // Tải file từ đường dẫn nguồn và lưu vào đường dẫn đích
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.DownloadFile(mp3FilePath, destinationPath);
                    webClient.Dispose();

                    MessageBox.Show("File MP3 đã được tải xuống thành công!");
                    numberDown++;
                    Song song = new Song();
                    song.updateDownNum(index, numberDown);
                    downloadNum.Text = numberDown.ToString();

                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi khi tải xuống file MP3: {ex.Message}");
                }
            }
        }

        private void AddPlaylist_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập tên Playlist
            playlistItem item = new playlistItem();
            string playlistName = Microsoft.VisualBasic.Interaction.InputBox("Enter the Playlist name:", "Add the song to Playlist");
            if (!string.IsNullOrEmpty(playlistName))
            {
                // Kiểm tra xem file có tồn tại không
                string playlistPath = Path.Combine("C:\\C#\\Spotify\\Database\\playList", playlistName + ".txt");

                if (File.Exists(playlistPath))
                {
                    // Kiểm tra xem phần tử đã tồn tại trong file hay chưa
                    string[] lines = File.ReadAllLines(playlistPath);
                    if (!Array.Exists(lines, element => element == $"{index}"))
                    {
                        AddNewLine(playlistPath, index);
                        MessageBox.Show("Added sucessfully!");
                    }
                    else
                    {
                        MessageBox.Show("Playlist already contains the element!");
                    }
                }
                else
                {
                    MessageBox.Show("Playlist " + playlistName + " doesn't exist!");
                }
            }
        }
    }
}
