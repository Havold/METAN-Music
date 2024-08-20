using BTTH02.Elements;
using System.Windows.Forms;

namespace BTTH02
{
    public partial class Main : Form
    {
        bool inHome = false;
        bool inSearch = false;
        bool inVN = false;
        bool inForeign = false;
        bool inRecent = false;
        bool inFavorite = false;
        bool inPlaylist = false;
        string filePath = "C:\\C#\\Spotify\\Database\\recent\\recent.txt";
        string playlistPath = "C:\\C#\\Spotify\\Database\\playList";
        public Main()
        {
            InitializeComponent();
            ResetFile(filePath);
            inHome = true;
            homePanel.BackColor = ColorTranslator.FromHtml("#121212");
            libraryPanel.BackColor = ColorTranslator.FromHtml("#121212");
            nextPanel.BackColor = ColorTranslator.FromHtml("#121212");
            LoadPlayList();
        }

        private static void ResetFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }
        private void ResetAll()
        {
            Home.ForeColor = Color.Silver;
            homeIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Home_none.png");
            Search.ForeColor = Color.Silver;
            searchIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\find_none.png");
            VNList.ForeColor = Color.Silver;
            vnIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Vietnamese_none.png");
            ForeignList.ForeColor = Color.Silver;
            foreignIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\note_none.png");
            recentSong.ForeColor = Color.Silver;
            recentIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\recently_none.png");
            likedSong.ForeColor = Color.Silver;
            inHome = false;
            inSearch = false;
            inVN = false;
            inRecent = false;
            inForeign = false;
            inFavorite = false;
            inPlaylist = false;

            homeTab.Visible = false;
            searchTab.Visible = false;
            vnTab.Visible = false;
            foreignTab.Visible = false;
            recentTab.Visible = false;
            favoriteTab.Visible = false;
            playlistTab.Visible = false;
        }
        private void LoadListSong()
        {
            for (int i = 1; i <= 30; i++)
            {
                Song song = new Song();
                song.readDataSong(i);

            }
        }

        private void closeBtn_MouseEnter(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Black;
        }
        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Home_Click(object sender, EventArgs e)
        {
            ResetAll();
            inHome = true;
            homeTab.Visible = true;
            Home.ForeColor = Color.White;
            homeIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Home_full.png");
        }

        private void Home_MouseEnter(Object sender, EventArgs e)
        {
            if (!inHome)
            {
                Home.ForeColor = Color.White;
                homeIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Home.png");
            }
        }

        private void Home_MouseLeave(Object sender, EventArgs e)
        {
            if (!inHome)
            {
                Home.ForeColor = Color.Silver;
                homeIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Home_none.png");
            }
        }

        private void Search_Click(object sender, EventArgs e)
        {
            ResetAll();
            inSearch = true;
            searchTab.Visible = true;
            Search.ForeColor = Color.White;
            searchIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\find_show.png");
        }

        private void Search_MouseEnter(Object sender, EventArgs e)
        {
            if (!inSearch)
            {
                Search.ForeColor = Color.White;
                searchIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\find.png");
            }
        }

        private void Search_MouseLeave(Object sender, EventArgs e)
        {
            if (!inSearch)
            {
                Search.ForeColor = Color.Silver;
                searchIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\find_none.png");
            }
        }

        private void VNList_Click(object sender, EventArgs e)
        {
            ResetAll();
            inVN = true;
            vnTab.Visible = true;
            VNList.ForeColor = Color.White;
            vnIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Vietnamese.png");
        }

        private void VNList_MouseEnter(object sender, EventArgs e)
        {
            if (!inVN)
            {
                VNList.ForeColor = Color.White;
                vnIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Vietnamese.png");
            }
        }

        private void VNList_MouseLeave(object sender, EventArgs e)
        {
            if (!inVN)
            {
                VNList.ForeColor = Color.Silver;
                vnIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\Vietnamese_none.png");
            }
        }
        private void ForeignList_Click(object sender, EventArgs e)
        {
            ResetAll();
            inForeign = true;
            foreignTab.Visible = true;
            ForeignList.ForeColor = Color.White;
            foreignIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\note_show.png");
        }

        private void ForeignList_MouseEnter(object sender, EventArgs e)
        {
            if (!inForeign)
            {
                ForeignList.ForeColor = Color.White;
                foreignIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\note.png");
            }
        }

        private void ForeignList_MouseLeave(object sender, EventArgs e)
        {
            if (!inForeign)
            {
                ForeignList.ForeColor = Color.Silver;
                foreignIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\note_none.png");
            }
        }

        private void recentSong_Click(object sender, EventArgs e)
        {
            if (!inRecent)
            {
                ResetAll();
                inRecent = true;
                recentTab.Visible = true;
                recentSong.ForeColor = Color.White;
                recentIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\recently.png");
                recentTab.ReadFileAndAssignToVariable();
            }
        }

        private void recentSong_MouseEnter(object sender, EventArgs e)
        {
            if (!inRecent)
            {
                recentSong.ForeColor = Color.White;
                recentIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\recently.png");

            }

        }

        private void recentSong_MouseLeave(object sender, EventArgs e)
        {
            if (!inRecent)
            {
                recentSong.ForeColor = Color.Silver;
                recentIcon.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\recently_none.png");

            }
        }

        private void favorite_MouseEnter(object sender, EventArgs e)
        {
            if (!inFavorite)
            {
                likedSong.ForeColor = Color.White;
            }

        }

        private void favorite_MouseLeave(object sender, EventArgs e)
        {
            if (!inFavorite)
            {
                likedSong.ForeColor = Color.Silver;
            }
        }

        private void likedSong_Click(object sender, EventArgs e)
        {
            if (!inFavorite)
            {
                ResetAll();
                inFavorite = true;
                favoriteTab.Visible = true;
                likedSong.ForeColor = Color.White;
                favoriteTab.LoadListSong();
            }
        }



        private void buttonCreatePlaylist_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại nhập tên Playlist
            playlistItem item = new playlistItem();
            string playlistName = Microsoft.VisualBasic.Interaction.InputBox("Enter the Playlist name:", "Create Playlist");

            // Kiểm tra xem người dùng đã nhập tên Playlist hay chưa
            if (!string.IsNullOrEmpty(playlistName))
            {
                // Tạo đường dẫn đầy đủ của file .txt
                string filePath = Path.Combine(playlistPath, $"{playlistName}.txt");

                // Kiểm tra xem file đã tồn tại chưa
                if (!File.Exists(filePath))
                {
                    // Nếu chưa tồn tại, tạo file và ghi thông tin vào đó
                    File.WriteAllText(filePath, "");
                    item.getNameList(playlistName);
                    // Xử lý tên Playlist ở đây (ví dụ: thêm vào danh sách Playlist)
                    item.ItemClicked += Item_ItemClicked;
                    item.MinusClicked += Minus_MinusClicked;

                    playlist.Controls.Add(item);

                    //listBoxPlaylists.Items.Add(playlistName);
                }
                else
                {
                    MessageBox.Show("This playlist already exists!");
                }
            }
        }



        private void LoadPlayList()
        {

            // Lấy tất cả các file .txt trong thư mục
            string[] txtFiles = Directory.GetFiles(playlistPath, "*.txt");

            // Lấy tên file (không bao gồm đường dẫn đầy đủ)
            //string[] txtFileNames = txtFiles.Select(Path.GetFileName).ToArray();
            if (txtFiles.Length!=0)
            {
                foreach (string txtFile in txtFiles)
                {
                    playlistItem item = new playlistItem();
                    string fileName = Path.GetFileNameWithoutExtension(txtFile);
                    item.getNameList(fileName);
                    item.ItemClicked += Item_ItemClicked;
                    item.MinusClicked += Minus_MinusClicked;
                    playlist.Controls.Add(item);
                }
            }



        }

        private void Item_ItemClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Item được bấm
            if (sender is playlistItem clickedItem)
            {
                ResetAll();
                clickedItem.setInPlayList(true);
                // Bạn có thể sử dụng songIndex theo cách bạn muốn
                playlistTab.setPlayListName(clickedItem.playlistName);
                playlistTab.Visible = true;
                playlistTab.ReadFileAndAssignToVariable();
                //playlistTab.resetInforTab();
            }
        }

        private void Minus_MinusClicked(object? sender, EventArgs e)
        {
            // Xử lý khi một UserControl Item được bấm
            if (sender is playlistItem clickedItem)
            {
                // Hiển thị hộp thoại xác nhận
                DialogResult result = MessageBox.Show($"Are you sure you want to delete playlist {clickedItem.playlistName}?", "Confirmation",MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Nếu tồn tại, xóa UserControl
                    playlist.Controls.Remove(clickedItem);
                    string deletePath = Path.Combine(playlistPath, clickedItem.playlistName+".txt");
                    File.Delete(deletePath);
                    MessageBox.Show("Playlist has been deleted!","Notification");
                }

            }
            else
            {
                MessageBox.Show("UserControl does not exist in FlowLayoutPanel.");
            }
        }
    }
}

