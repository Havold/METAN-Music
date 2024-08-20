using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;


namespace BTTH02.Elements
{

    public partial class Song : UserControl
    {
        public string songName;
        public string artistName;
        public string imgPath;
        public string background;
        public int index_tmp;
        public int download;
        public string url;
        public bool favorite;
        public Song()
        {
            InitializeComponent();
            Item.BackColor = ColorTranslator.FromHtml("#181818");

        }
        

        public event EventHandler SongClicked;
        private void Song_Click(object sender, EventArgs e)
        {
            // Khi UserControl Song được bấm, gửi sự kiện để thông báo
            SongClicked?.Invoke(this, EventArgs.Empty);
        }

        private void SelectMouseEnter(object sender, EventArgs e)
        {
            Item.BackColor = ColorTranslator.FromHtml("#282828");
        }
        private void SelectMouseLeave(object sender, EventArgs e)
        {
            Item.BackColor = ColorTranslator.FromHtml("#181818");
        }

        public void readDataSong(int index)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/C#/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);

            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                //Lấy giá trị của trường "name"
                songName = (string)jsonObject["name"];
                artistName = (string)jsonObject["artist"];
                imgPath = (string)jsonObject["imgPath"];
                background = (string)jsonObject["background"];
                url = (string)jsonObject["url"];
                favorite = (bool)jsonObject["favorite"];
                download = (int)jsonObject["download"];


                index_tmp = index;

                this.SongName.Text = songName;
                this.ArtistName.Text = artistName;
                this.songImg.Image = Image.FromFile(imgPath);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public void updateFavorite(int index, bool isFavorite)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/C#/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);

            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                jsonObject["favorite"] = isFavorite;

                // Chuyển đổi đối tượng JObject thành chuỗi JSON
                string updatedJsonContent = jsonObject.ToString();

                // Ghi lại nội dung mới vào file JSON
                System.IO.File.WriteAllText(filePath, updatedJsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }

        public bool searchSong(int index, string searchTerm)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/C#/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);
            
            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                //Lấy giá trị của trường "name"
                string songName = (string)jsonObject["name"];
                if (songName.ToLower().Contains(searchTerm.ToLower()))
                {   
                    string artistName = (string)jsonObject["artist"];
                    string imgPath = (string)jsonObject["imgPath"];

                    this.SongName.Text = songName;
                    this.ArtistName.Text = artistName;
                    this.songImg.Image = Image.FromFile(imgPath);
         
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public bool searchArtist(int index, string searchTerm)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/C#/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);

            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                //Lấy giá trị của trường "name"
                string artistName = (string)jsonObject["artist"];
                if (artistName.ToLower().Contains(searchTerm.ToLower()))
                {
                    string songName = (string)jsonObject["songName"];
                    string imgPath = (string)jsonObject["imgPath"];

                    this.SongName.Text = songName;
                    this.ArtistName.Text = artistName;
                    this.songImg.Image = Image.FromFile(imgPath);

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                return false;
            }
        }

        public void updateDownNum(int index, int numberDown)
        {
            //Đường dẫn tới thư mục chứa các tệp JSON
            string dirPath = "C:/C#/Spotify/Database/songInfo";

            //Tạo tên tệp dựa trên giá trị i
            string fileName = $"{index}.json";

            //Kết hợp đường dẫn thư mục và tên tệp
            string filePath = Path.Combine(dirPath, fileName);

            try
            {
                //Độc nội dung của tệp JSON
                string jsonContent = File.ReadAllText(filePath);

                //Sử dụng JObject để truy cập giá trị cụ thể trong tệp JSON
                JObject jsonObject = JObject.Parse(jsonContent);

                jsonObject["download"] = numberDown;

                // Chuyển đổi đối tượng JObject thành chuỗi JSON
                string updatedJsonContent = jsonObject.ToString();

                // Ghi lại nội dung mới vào file JSON
                System.IO.File.WriteAllText(filePath, updatedJsonContent);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
