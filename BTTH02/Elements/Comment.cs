using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml;

namespace BTTH02.Elements
{
    public partial class Comment : UserControl
    {
        public bool gender=false;
        public string txtCmt;


        public Comment()
        {
            InitializeComponent();
        }

        //----------------------------------------------------------------------------------------------------

        public void content(string s, bool x)
        {
            contentCmt.Text = s;
            if (x==false)
            {
                this.picGender.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\girl.png");
            }
            else
            {
                this.picGender.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\boy.png");

            }
        }

        public void setStar(int x)
        {
            if (x==1)
            {
            star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");

            }

            else if (x == 2)
            {
                star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            }

            else if (x == 3)
            {
                star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            }

            else if (x == 4)
            {
                star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star4.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            }

            else if (x == 5)
            {
                star1.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star2.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star3.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star4.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
                star5.Image = Image.FromFile("C:\\C#\\Spotify\\icon\\star.png");
            }
        }
    }
}
