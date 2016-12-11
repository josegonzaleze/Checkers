using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Xaml.Shapes;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CheckersUniversalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public Color color1 = SettingsPage.color1;
        public Color color2 = SettingsPage.color2;
        

        public bool eatUpRight = false;
        public bool eatUpLeft = false;
        public bool eatDownRight = false;
        public bool eatDownLeft = false;
        public bool eat = false;
        public string eatCode = "";
        public bool turnRed = true;
        public bool turnBlack = false;
        private bool redWin = false;
        private bool blackWin = false;
        public string Turn = "red";

        public MainPage()
        {
            InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;
           
        }

        public void PaintBoardTiles()
        {

            //Setting up the tables colors.
            SolidColorBrush brush1 = new SolidColorBrush(color1);
            SolidColorBrush brush2 = new SolidColorBrush(color2);

            //first row
            a1Tile.Fill = brush1;
            b1Tile.Fill = brush2;
            c1Tile.Fill = brush1;
            d1Tile.Fill = brush2;
            e1Tile.Fill = brush1;
            f1Tile.Fill = brush2;
            g1Tile.Fill = brush1;
            h1Tile.Fill = brush2;

            //second row
            a2Tile.Fill = brush2;
            b2Tile.Fill = brush1;
            c2Tile.Fill = brush2;
            d2Tile.Fill = brush1;
            e2Tile.Fill = brush2;
            f2Tile.Fill = brush1;
            g2Tile.Fill = brush2;
            h2Tile.Fill = brush1;

            //third row
            a3Tile.Fill = brush1;
            b3Tile.Fill = brush2;
            c3Tile.Fill = brush1;
            d3Tile.Fill = brush2;
            e3Tile.Fill = brush1;
            f3Tile.Fill = brush2;
            g3Tile.Fill = brush1;
            h3Tile.Fill = brush2;

            //fourth row
            a4Tile.Fill = brush2;
            b4Tile.Fill = brush1;
            c4Tile.Fill = brush2;
            d4Tile.Fill = brush1;
            e4Tile.Fill = brush2;
            f4Tile.Fill = brush1;
            g4Tile.Fill = brush2;
            h4Tile.Fill = brush1;

            //Fifth row
            a5Tile.Fill = brush1;
            b5Tile.Fill = brush2;
            c5Tile.Fill = brush1;
            d5Tile.Fill = brush2;
            e5Tile.Fill = brush1;
            f5Tile.Fill = brush2;
            g5Tile.Fill = brush1;
            h5Tile.Fill = brush2;

            //Sicth row
            a6Tile.Fill = brush2;
            b6Tile.Fill = brush1;
            c6Tile.Fill = brush2;
            d6Tile.Fill = brush1;
            e6Tile.Fill = brush2;
            f6Tile.Fill = brush1;
            g6Tile.Fill = brush2;
            h6Tile.Fill = brush1;

            //seveth row
            a7Tile.Fill = brush1;
            b7Tile.Fill = brush2;
            c7Tile.Fill = brush1;
            d7Tile.Fill = brush2;
            e7Tile.Fill = brush1;
            f7Tile.Fill = brush2;
            g7Tile.Fill = brush1;
            h7Tile.Fill = brush2;

            //eight row
            a8Tile.Fill = brush2;
            b8Tile.Fill = brush1;
            c8Tile.Fill = brush2;
            d8Tile.Fill = brush1;
            e8Tile.Fill = brush2;
            f8Tile.Fill = brush1;
            g8Tile.Fill = brush2;
            h8Tile.Fill = brush1;
        }

        public void StartGame()
        {
          
            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));
            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));
            winnerImage.Source = null;
            winnerTextBlock.IsHitTestVisible = false;
            winnerTextBlock.Text = "";
            turnBlack = false;
            turnRed = true;
            redWin = false;
            blackWin = false;

            //DELETE ALL IMAGES:
            a1Picture.Source = null;
            b1Picture.Source = null;
            c1Picture.Source = null;
            d1Picture.Source = null;
            e1Picture.Source = null;
            f1Picture.Source = null;
            g1Picture.Source = null;
            h1Picture.Source = null;
            a2Picture.Source = null;
            b2Picture.Source = null;
           
            d2Picture.Source = null;
       
            f2Picture.Source = null;
            g2Picture.Source = null;
            h2Picture.Source = null;
            a3Picture.Source = null;
            b3Picture.Source = null;
            c3Picture.Source = null;
      
            e3Picture.Source = null;
            f3Picture.Source = null;
            h3Picture.Source = null;
            a4Picture.Source = null;
            b4Picture.Source = null;
            c4Picture.Source = null;
            c4Picture.Source = null;
            d4Picture.Source = null;
            e4Picture.Source = null;
            f4Picture.Source = null;
            g4Picture.Source = null;
            h4Picture.Source = null;
            a5Picture.Source = null;
            b5Picture.Source = null;
            c5Picture.Source = null;
            d5Picture.Source = null;
            e5Picture.Source = null;
            f5Picture.Source = null;
            g5Picture.Source = null;
            h5Picture.Source = null;
            a6Picture.Source = null;
            b6Picture.Source = null;
            c6Picture.Source = null;
            d6Picture.Source = null;
            e6Picture.Source = null;
            f6Picture.Source = null;
            g6Picture.Source = null;
            h6Picture.Source = null;
            a7Picture.Source = null;
            b7Picture.Source = null;
            c7Picture.Source = null;
            d7Picture.Source = null;
            e7Picture.Source = null;
            f7Picture.Source = null;
            g7Picture.Source = null;
            h7Picture.Source = null;
            a8Picture.Source = null;
            b8Picture.Source = null;
            c8Picture.Source = null;
            d8Picture.Source = null;
            e8Picture.Source = null;
            f8Picture.Source = null;
            g8Picture.Source = null;
            h8Picture.Source = null;

            //RE - Paint the board
            PaintBoardTiles();

            //set up game "RED"
            a1Picture.Source = redChecker.Source;
            a1Picture.Tag = "red";
            c1Picture.Source = redChecker.Source;
            c1Picture.Tag = "red";
            e1Picture.Source = redChecker.Source;
            e1Picture.Tag = "red";
            g1Picture.Source = redChecker.Source;
            g1Picture.Tag = "red";

            b2Picture.Source = redChecker.Source;
            b2Picture.Tag = "red";
            d2Picture.Source = redChecker.Source;
            d2Picture.Tag = "red";
            f2Picture.Source = redChecker.Source;
            f2Picture.Tag = "red";
            h2Picture.Source = redChecker.Source;
            h2Picture.Tag = "red";

            a3Picture.Source = redChecker.Source;
            a3Picture.Tag = "red";
            c3Picture.Source = redChecker.Source;
            c3Picture.Tag = "red";
            e3Picture.Source = redChecker.Source;
            e3Picture.Tag = "red";
            g3Picture.Source = redChecker.Source;
            g3Picture.Tag = "red";

            //Set up game "BLACK"
            b8Picture.Source = blackChecker.Source;
            b8Picture.Tag = "black";
            d8Picture.Source = blackChecker.Source;
            d8Picture.Tag = "black";
            f8Picture.Source = blackChecker.Source;
            f8Picture.Tag = "black";
            h8Picture.Source = blackChecker.Source;
            h8Picture.Tag = "black";

            a7Picture.Source = blackChecker.Source;
            a7Picture.Tag = "black";
            c7Picture.Source = blackChecker.Source;
            c7Picture.Tag = "black";
            e7Picture.Source = blackChecker.Source;
            e7Picture.Tag = "black";
            g7Picture.Source = blackChecker.Source;
            g7Picture.Tag = "black";

            b6Picture.Source = blackChecker.Source;
            b6Picture.Tag = "black";
            d6Picture.Source = blackChecker.Source;
            d6Picture.Tag = "black";
            f6Picture.Source = blackChecker.Source;
            f6Picture.Tag = "black";
            h6Picture.Source = blackChecker.Source;
            h6Picture.Tag = "black";

        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            PaintBoardTiles();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void Selected_Checker(object sender, TappedRoutedEventArgs e)
        {
            SolidColorBrush brush1 = new SolidColorBrush(Colors.Pink);
            
        }
        private void ChangeBackground(string str)
        {

            Rectangle rect = FindName(str) as Rectangle;
            SolidColorBrush brushTemp = new SolidColorBrush(Colors.Pink);
            rect.Fill = brushTemp;
        }

        private void CanMoveTop(string str)
        {
            //Left Position
            string letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            string number = str.Substring(1, 1);

            letter = DecrementLetter(letter);
          
            int n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            string ImageCode = letter + number + "Picture";
            string RectCode = letter + number + "Tile";
            Image img = FindName(ImageCode) as Image;
            Rectangle rect = FindName(RectCode) as Rectangle;

            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


            if (img != null)
            {

                if (img.Source == null && img.Source == null)
                {
                    rect.Fill = new SolidColorBrush(Colors.Gray);
                }else
                {
                    DownLeftSearch(letter + number);
                }
            }

            //Right Position
            letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            number = str.Substring(1, 1);

            letter = IncrementLetter(letter);

            n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;

            blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

            redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


            if (img != null)
            {

                if (img.Source == null && img.Source == null)
                {
                    rect.Fill = new SolidColorBrush(Colors.Gray);
                }
                else
                {
                    DownRightSearch(letter + number);
                }
            }

        }

        private void DownLeftSearch(string str)
        {
            Image imgToEat = FindName(str + "Picture") as Image;
            if (imgToEat.Tag.ToString() == "red")
            {
                //Left Position
                string letter = "";
                if (str.Substring(0, 1) != null)
                {
                    letter = str.Substring(0, 1);
                }
                string number = str.Substring(1, 1);

                letter = DecrementLetter(letter);

                int n = (Convert.ToInt32(number) - 1);
                if (n < 1)
                {
                    n = 1;
                }
                number = n.ToString();

                string ImageCode = letter + number + "Picture";
                string RectCode = letter + number + "Tile";
                Image img = FindName(ImageCode) as Image;
                Rectangle rect = FindName(RectCode) as Rectangle;

                Image blackChecker = new Image();
                blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

                Image redChecker = new Image();
                redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


                if (img != null)
                {

                    if (img.Source == null && img.Source == null)
                    {
                        rect.Fill = new SolidColorBrush(Colors.Gray);
                        eatDownLeft = true;
                    }
                }
            }
        }
        private void DownRightSearch(string str)
        {
            Image imgToEat = FindName(str + "Picture") as Image;
            if(imgToEat.Tag.ToString() == "red")
            {
                //Right Position
                string letter = "";
                string number = "";
                if (str.Substring(0, 1) != null)
                {
                    letter = str.Substring(0, 1);
                }
                number = str.Substring(1, 1);

                letter = IncrementLetter(letter);

                int n = (Convert.ToInt32(number) - 1);
                if (n < 1)
                {
                    n = 1;
                }
                number = n.ToString();

                string ImageCode = letter + number + "Picture";
                string RectCode = letter + number + "Tile";
                Image img = FindName(ImageCode) as Image;
                Rectangle rect = FindName(RectCode) as Rectangle;

                Image blackChecker = new Image();
                blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

                Image redChecker = new Image();
                redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


                if (img != null)
                {

                    if (img.Source == null && img.Source == null)
                    {
                        rect.Fill = new SolidColorBrush(Colors.Gray);
                        eatDownRight = true;
                    }

                }
            }
            
        }
        private void UpLeftSearch(string str)
        {
            Image imgToEat = FindName(str + "Picture") as Image;
            if (imgToEat.Tag.ToString() == "black")
            {
                //Left Position
                string letter = "";
                if (str.Substring(0, 1) != null)
                {
                    letter = str.Substring(0, 1);
                }

                string number = str.Substring(1, 1);
                letter = DecrementLetter(letter);

                int n = (Convert.ToInt32(number) + 1);
                if (n < 1)
                {
                    n = 1;
                }
                number = n.ToString();

                string ImageCode = letter + number + "Picture";
                string RectCode = letter + number + "Tile";
                Image img = FindName(ImageCode) as Image;
                Rectangle rect = FindName(RectCode) as Rectangle;

                if (img != null)
                {

                    if (img.Source == null && img.Source == null)
                    {
                        rect.Fill = new SolidColorBrush(Colors.Gray);
                        eatUpLeft = true;
                    }
                }
            }
        }
        private void UpRightSearch(string str)
        {   
            Image imgToEat = FindName(str + "Picture") as Image;
            if (imgToEat.Tag.ToString() == "black")
            {
                // Right position
                string letter = "";
                if (str.Substring(0, 1) != null)
                {
                    letter = str.Substring(0, 1);
                }

                string number = str.Substring(1, 1);

                letter = IncrementLetter(letter);
                int n = (Convert.ToInt32(number) + 1);
                if (n > 8)
                {
                    n = 8;
                }
                number = n.ToString();

                string ImageCode = letter + number + "Picture";
                string RectCode = letter + number + "Tile";
                Image img = FindName(ImageCode) as Image;
                Rectangle rect = FindName(RectCode) as Rectangle;

                Image blackChecker = new Image();
                blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

                Image redChecker = new Image();
                redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


                if (img != null)
                {

                    if (img.Source == null && img.Source == null)
                    {
                        rect.Fill = new SolidColorBrush(Colors.Gray);
                        eatUpRight = true;
                    }
                }
            }

        }
        private void CanMOve(string str)
        {
            // Right position
            string letter = "";
            if(str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            
            string number = str.Substring(1, 1);

            letter = IncrementLetter(letter);
            int n = (Convert.ToInt32(number) + 1);
            if (n > 8)
            {
                n = 8;
            }
            number = n.ToString();

            string ImageCode = letter + number + "Picture";
            string RectCode = letter + number + "Tile";
            Image img = FindName(ImageCode) as Image;
            Rectangle rect = FindName(RectCode) as Rectangle;

            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));


            if(img != null)
            {

                if (img.Source == null && img.Source == null)
                {
                    rect.Fill = new SolidColorBrush(Colors.Gray);
                }else
                {
                    UpRightSearch(letter + number);
                }
            }

            //Left Position
            letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }

            number = str.Substring(1, 1);
            letter = DecrementLetter(letter);

            n = (Convert.ToInt32(number) + 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;

            if (img != null)
            {

                if (img.Source == null && img.Source == null)
                {
                    rect.Fill = new SolidColorBrush(Colors.Gray);
                }
                else
                {
                    UpLeftSearch(letter + number);
                }
            }


        }
        private string DecrementLetter(string str)
        {
            string NewLetter = "";
            switch (str.ToLower())
            {
               
                case "b":
                    NewLetter = "a";
                    break;
                case "c":
                    NewLetter = "b";
                    break;
                case "d":
                    NewLetter = "c";
                    break;
                case "e":
                    NewLetter = "d";
                    break;
                case "f":
                    NewLetter = "e";
                    break;
                case "g":
                    NewLetter = "f";
                    break;
                case "h":
                    NewLetter = "g";
                    break;
            }
            return NewLetter;
        }
        private string IncrementLetter(string str)
        {
            string NewLetter = "";

            switch (str.ToLower())
            {
                case "a":
                    NewLetter = "b";
                    break;
                case "b":
                    NewLetter = "c";
                    break;
                case "c":
                    NewLetter = "d";
                    break;
                case "d":
                    NewLetter = "e";
                    break;
                case "e":
                    NewLetter = "f";
                    break;
                case "f":
                    NewLetter = "g";
                    break;
                case "g":
                    NewLetter = "h";
                    break;
            }
            return NewLetter;
        }

        private void Move(string str)
        {
            string code = str.Substring(0, 2);
            string ImageName = code + "Picture";
            string RectangleName = code + "Tile";
            Image img = FindName(ImageName) as Image;
            Rectangle rect = FindName(str) as Rectangle;
            
            if (rect.Fill == new SolidColorBrush(Colors.Gray))
            {
                string positionToReceive = GetHiglighted(ImageName);
                Image img2 = FindName(positionToReceive) as Image;
                Image temp = new Image();

                temp.Source = img.Source;
                img.Source = img2.Source;
                img2.Source = temp.Source;
            }

            

        }

        private string GetHiglighted(string str)
        {
            //up right
            string letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            string number = str.Substring(1, 1);

            letter = IncrementLetter(letter);

            int n = (Convert.ToInt32(number) + 1);
            if (n > 8 )
            {
                n = 8;
            }
            number = n.ToString();

            string ImageCode = letter + number + "Picture";
            string RectCode = letter + number + "Tile";
            Image img = FindName(ImageCode) as Image;
            Rectangle rect = FindName(RectCode) as Rectangle;

            if (rect.Fill == new SolidColorBrush(Colors.Pink))
            {
                    return img.Name.ToString();
            }

            //up left
            letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            number = str.Substring(1, 1);

            letter = DecrementLetter(letter);

            n = (Convert.ToInt32(number) + 1);
            if (n < 8)
            {
                n = 8;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;

            if (rect.Fill == new SolidColorBrush(Colors.Pink))
            {
                return img.Name.ToString();
            }

            //bottom right
            letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }

            number = str.Substring(1, 1);

            letter = IncrementLetter(letter);
            n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;

            if (rect.Fill == new SolidColorBrush(Colors.Pink))
            {
                return img.Name.ToString();
            }

            //bottom left
            letter = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }

            number = str.Substring(1, 1);
            letter = DecrementLetter(letter);

            n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;

            if (rect.Fill == new SolidColorBrush(Colors.Pink))
            {
                return img.Name.ToString();
            }

            return "";
        }

        private bool CanTakeCoin(string str)
        {
            string code = str.Substring(0, 2);
            string ImageName = code + "Picture";
            string RectangleName = code + "Tile";
            Rectangle rect = FindName(RectangleName) as Rectangle;
            Image img = FindName(ImageName) as Image;

            //Gets the string of the fill in the rectangle
            Brush thisRect = rect.Fill;
            SolidColorBrush b = thisRect as SolidColorBrush;
            string colorTemp = "";
            if (b != null)
                colorTemp = b.Color.ToString();
            // Gray is allowed color
            string allowedColor = "#FF808080";
            //If there is no image on the rectangle and the rectangle is mark as possible move
            if (img.Source == null && colorTemp == allowedColor)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //Finds where did we clicked before secting the open space.
        private string FindSender(string str)
        {
            //Color of the table
            Brush thisRect;
            SolidColorBrush b;
            string colorTemp = "";


            //up right
            string letter = "";
            string number = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            number = str.Substring(1, 1);

            letter = IncrementLetter(letter);

            int n = (Convert.ToInt32(number) + 1);
            if (n > 8)
            {
                n = 8;
            }
            number = n.ToString();

            string ImageCode = letter + number + "Picture";
            string RectCode = letter + number + "Tile";
            Image img = FindName(ImageCode) as Image;
            Rectangle rect = FindName(RectCode) as Rectangle;

            if (rect != null && img != null)
            {
                thisRect = rect.Fill;
                b = thisRect as SolidColorBrush;
                if (b != null)
                    colorTemp = b.Color.ToString();


                if (colorTemp == new SolidColorBrush(Colors.Pink).Color.ToString())
                {
                    return img.Name.ToString();
                }
            }
     

            //up left
            letter = "";
            number = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }
            number = str.Substring(1, 1);

            letter = DecrementLetter(letter);

            n = (Convert.ToInt32(number) + 1);
            if (n > 8)
            {
                n = 8;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;


            if (rect != null && img != null)
            {
                thisRect = rect.Fill;
                b = thisRect as SolidColorBrush;
                if (b != null)
                    colorTemp = b.Color.ToString();


                if (colorTemp == new SolidColorBrush(Colors.Pink).Color.ToString())
                {
                    return img.Name.ToString();
                }
            }
            //bottom right
            letter = "";
            number = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }

            number = str.Substring(1, 1);

            letter = IncrementLetter(letter);
            n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;


            if (rect != null && img != null)
            {
                thisRect = rect.Fill;
                b = thisRect as SolidColorBrush;
                if (b != null)
                    colorTemp = b.Color.ToString();


                if (colorTemp == new SolidColorBrush(Colors.Pink).Color.ToString())
                {
                    return img.Name.ToString();
                }
            }
            //bottom left
            letter = "";
            number = "";
            if (str.Substring(0, 1) != null)
            {
                letter = str.Substring(0, 1);
            }

            number = str.Substring(1, 1);
            letter = DecrementLetter(letter);

            n = (Convert.ToInt32(number) - 1);
            if (n < 1)
            {
                n = 1;
            }
            number = n.ToString();

            ImageCode = letter + number + "Picture";
            RectCode = letter + number + "Tile";
            img = FindName(ImageCode) as Image;
            rect = FindName(RectCode) as Rectangle;


            if (rect != null && img != null)
            {
                thisRect = rect.Fill;
                b = thisRect as SolidColorBrush;
                if (b != null)
                    colorTemp = b.Color.ToString();


                if (colorTemp == new SolidColorBrush(Colors.Pink).Color.ToString())
                {
                    return img.Name.ToString();
                }
            }
            //At This point none of the 4th points 
            //We need to go deeper. maybe this is a EAT move, Eat fuction will give us the name of the sender by going one more level

            return Eat(str);

        }
        private string Eat(string str)
        {
            string number = str.Substring(1, 1);
            string letter = str.Substring(0, 1);

            string senderLetter = "";
            int senderNumber = 0;
            Rectangle temp;

            //When DownLeft and DownRight are true;
            if (eatDownLeft && eatDownRight)
            {
                // Move 4 to the right

                string letter4R2 = IncrementLetter(letter);
                letter4R2 = IncrementLetter(letter4R2);
                letter4R2 = IncrementLetter(letter4R2);
                letter4R2 = IncrementLetter(letter4R2);
                string number4R2 = number;

                temp = FindName(letter4R2 + number4R2 + "Tile") as Rectangle;

                //Gets the string of the fill in the rectangle
                if (temp != null)
                {
                    Brush thisRect = temp.Fill;
                    SolidColorBrush b = thisRect as SolidColorBrush;
                    string colorTemp = "";
                    if (b != null)
                        colorTemp = b.Color.ToString();
                    // Gray is allowed color
                    string allowedColor = "#FF808080";

                    //Check if is this is gray if so, we are moving to the left
                    if (allowedColor == colorTemp)
                    {
                        eatDownRight = false;
                    }
                }

                //Move 4 to the left
                string letter4L2 = DecrementLetter(letter);
                letter4L2 = DecrementLetter(letter4L2);
                letter4L2 = DecrementLetter(letter4L2);
                letter4L2 = DecrementLetter(letter4L2);
                string number4L2 = number;

                temp = FindName(letter4L2 + number4L2 + "Tile") as Rectangle;
                if (temp != null)
                {
                    Brush thisRect = temp.Fill;
                    SolidColorBrush b = thisRect as SolidColorBrush;
                    string colorTemp = "";
                    if (b != null)
                        colorTemp = b.Color.ToString();
                    // Gray is allowed color
                    string allowedColor = "#FF808080";

                    //Check if this is gray if so, we are movinf to the right
                    if (allowedColor == colorTemp)
                    {
                        eatDownLeft = false;

                    }
                }
                //At this point only one bool must be true;
            }


            //When Upleft and Upright are true
            if (eatUpLeft && eatUpRight)
            {
                // Move 4 to the right

                string letter4R = IncrementLetter(letter);
                letter4R = IncrementLetter(letter4R);
                letter4R = IncrementLetter(letter4R);
                letter4R = IncrementLetter(letter4R);
                string number4R = number;
                temp = FindName(letter4R + number4R + "Tile") as Rectangle;

                if (temp != null)
                {
                    Brush thisRect = temp.Fill;
                    SolidColorBrush b = thisRect as SolidColorBrush;
                    string colorTemp = "";
                    if (b != null)
                        colorTemp = b.Color.ToString();
                    // Gray is allowed color
                    string allowedColor = "#FF808080";

                    //Check if is this is gray if so, we are moving to the left
                    if (allowedColor == colorTemp)
                    {
                        eatUpRight = false;
                    }
                }
                    

                    //Move 4 to the left
                    string letter4L2 = DecrementLetter(letter);
                    letter4L2 = DecrementLetter(letter4L2);
                    letter4L2 = DecrementLetter(letter4L2);
                    letter4L2 = DecrementLetter(letter4L2);
                    string number4L2 = number;
                    temp = FindName(letter4L2 + number4L2 + "Tile") as Rectangle;

                    if (temp != null)
                    {
                        Brush thisRect = temp.Fill;
                        SolidColorBrush b = thisRect as SolidColorBrush;
                        string colorTemp = "";
                        if (b != null)
                            colorTemp = b.Color.ToString();
                        // Gray is allowed color
                        string allowedColor = "#FF808080";

                        //Check if is this is gray if so, we are moving to the right
                        if (allowedColor == colorTemp)
                        {
                            eatUpLeft = false;
                        }
                    }
                    //At this point only one bool must be true
                
            }


            if (eatDownLeft)
            {
                //
                senderLetter = "";
                senderNumber = 0;
                //Sender is letter + 2 number + 2
                senderLetter = IncrementLetter(letter);
                senderNumber = Convert.ToInt32(number) + 1;
                if (senderNumber > 8)
                {
                    senderNumber = 8;
                }
                eatCode = senderLetter + senderNumber + "Picture";
                
                senderLetter = IncrementLetter(senderLetter);
                senderNumber = senderNumber + 1;
                if( senderNumber > 8)
                {
                    senderNumber = 8;
                }
                eat = true;


            }
           else if (eatDownRight)
            {
                senderLetter = "";
                senderNumber = 0;
                //Sender is letter - 2 number + 2
                senderLetter = DecrementLetter(letter);
                senderNumber = Convert.ToInt32(number) + 1;
                if (senderNumber > 8)
                {
                    senderNumber = 8;
                }
                eatCode = senderLetter + senderNumber + "Picture";

                senderLetter = DecrementLetter(senderLetter);
                senderNumber = senderNumber + 1;
                if (senderNumber > 8)
                {
                    senderNumber = 8;
                }
               
                eat = true;
            }

           else if (eatUpLeft)
            {
                senderLetter = "";
                senderNumber = 0;
                //Sender is  letter + 2 number - 2
                senderLetter = IncrementLetter(letter);
                senderNumber = Convert.ToInt32(number) - 1;
                if (senderNumber < 1)
                {
                    senderNumber = 1;
                }
                eatCode = senderLetter + senderNumber + "Picture";

                senderLetter = IncrementLetter(senderLetter);
                senderNumber = senderNumber - 1;
                if (senderNumber < 1)
                {
                    senderNumber = 1;
                }
                
                eat = true;
            }
            else if (eatUpRight)
            {
                senderLetter = "";
                senderNumber = 0;
                //Sender is letter - 2 number - 2
                senderLetter = DecrementLetter(letter);
                senderNumber = Convert.ToInt32(number) - 1;
                if (senderNumber < 1)
                {
                    senderNumber = 1;
                }
                eatCode = senderLetter + senderNumber + "Picture";

                senderLetter = DecrementLetter(senderLetter);
                senderNumber = senderNumber - 1;
                if (senderNumber < 1)
                {
                    senderNumber = 1;
                }
                
                eat = true;
            }
            eatDownLeft = false;
            eatDownRight = false;
            eatUpLeft = false;
            eatUpRight = false;
            return (senderLetter + senderNumber + "Picture");
        }

        //Listeners -----------------------------------------------------------


        private void Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {            
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0,2) + "Tile";
            ChangeBackground(rectangleName);

            //Find what tile is it BLACK or RED
            Image img = FindName(imageName) as Image;

            if (img != null)
            {
                if(img.Tag.ToString() == "red" && turnRed)
                {
                    //Send algorithm to move for reds
                    CanMOve(imageName);
                }
                else if(img.Tag.ToString() == "black" && turnBlack)
                {
                    //Send algorithm to move for blacks
                    CanMoveTop(imageName);
                }
            }
            bool Move =  CanTakeCoin(rectangleName);

        }

        private void newGameButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }

        private void newGameAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }



        //Listeners When there is no coin on the tile;
        private void Tile_Tapped(object sender, TappedRoutedEventArgs e)
        {
            //Get names for location

            
            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));
            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));


            string rectangleName = ((Rectangle)sender).Name.ToString();
            string imageName = rectangleName.Substring(0, 2) + "Picture";
            Image img = FindName(imageName) as Image;

                if (CanTakeCoin(rectangleName))
                {
                    string NameOfSender = FindSender(rectangleName);
                    Image imgSender = FindName(NameOfSender) as Image;
                    if (imgSender.Tag.ToString() == "red")
                    {
                        img.Source = redChecker.Source;
                        img.Tag = "red";
                    }
                    else if (imgSender.Tag.ToString() == "black")
                    {
                        img.Source = blackChecker.Source;
                        img.Tag = "black";
                    }
                    //Ending move
                    imgSender.Source = null;
                    imgSender.Tag = null;
                    if (eat)
                    {
                        Image delImage = FindName(eatCode) as Image;
                        delImage.Source = null;
                        delImage.Tag = null;
                        eat = false;
                    }
                    PaintBoardTiles();
                if (turnRed)
                {
                    turnRed = false;
                    turnBlack = true;

                }
                else
                {
                    turnBlack = false;
                    turnRed = true;
                }

               
            }
            CheckWin();
             
        }

        private void CheckWin()
        {
            //If there is one red image on the top of the board, red will be the winer.
            
            if(a8Picture.Tag != null)
            {
                if(a8Picture.Tag.ToString() == "red")
                redWin = true;
            }
            if(b8Picture.Tag != null && b8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (c8Picture.Tag != null && c8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (d8Picture.Tag != null && d8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (e8Picture.Tag != null && e8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (f8Picture.Tag != null && f8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (g8Picture.Tag != null && g8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }
            if (h8Picture.Tag != null && h8Picture.Tag.ToString() == "red")
            {
                redWin = true;
            }


            //If there is one black image on the buttom of the board, black will be the winer.
            if(a1Picture.Tag != null && a1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (b1Picture.Tag != null && b1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (c1Picture.Tag != null && c1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (d1Picture.Tag != null && d1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (e1Picture.Tag != null && e1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (f1Picture.Tag != null && f1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (g1Picture.Tag != null && g1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }
            if (h1Picture.Tag != null && h1Picture.Tag.ToString() == "black")
            {
                blackWin = true;
            }

            if(redWin)
            {
                winnerImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/checker.png"));
                winnerTextBlock.Text = playerName1.Text.ToString() + " WINS!!!";
                turnRed = false;
                turnBlack = false;
            }

            if(blackWin)
            {
                winnerImage.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackPlayerChecker.png"));
                winnerTextBlock.Text = playerName2.Text.ToString() + " WINS!!!";
                turnRed = false;
                turnBlack = false;
            }
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            currentView.BackRequested += backButton_Tapped;

            PaintBoardTiles();
            //StartGame();
            playerName1.Text = SettingsPage.name1;
            playerName2.Text = SettingsPage.name2;

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("p1"))
            {
                playerName1.Text = ApplicationData.Current.LocalSettings.Values["p1"] as string;
            }
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("p2"))
            {
                playerName1.Text = ApplicationData.Current.LocalSettings.Values["p2"] as string;
            }

            
        

            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("c2"))
            {
                string colorOfTheTile = ApplicationData.Current.LocalSettings.Values["c2"] as string;

                if (colorOfTheTile == "Red")
                {
                    color2 = Colors.Red;
                    SettingsPage.colorTile2 = "Red";
                    SettingsPage.color2 = Colors.Red;
                }
                else if (colorOfTheTile == "Blue")
                {
                    color2 = Colors.Blue;
                    SettingsPage.colorTile2 = "Blue";
                    SettingsPage.color2 = Colors.Blue;
                }
                else if (colorOfTheTile == "Yellow")
                {
                    color1 = Colors.Yellow;
                    SettingsPage.colorTile2 = "Yellow";
                    SettingsPage.color2 = Colors.Yellow;
                }
                else if (colorOfTheTile == "Green")
                {
                    color2 = Colors.Green;
                    SettingsPage.colorTile2 = "Green";
                    SettingsPage.color2 = Colors.Green;
                }
                else if (colorOfTheTile == "Purple")
                {
                    color2 = Colors.Purple;
                    SettingsPage.colorTile2 = "Purple";
                    SettingsPage.color2 = Colors.Purple;
                }
                else if (colorOfTheTile == "Black")
                {
                    color1 = Colors.Black;
                    SettingsPage.colorTile2 = "Black";
                    SettingsPage.color2 = Colors.Black;
                }
            }

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);
            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.BackRequested += backButton_Tapped;
            ApplicationData.Current.LocalSettings.Values["p1"] = playerName1.Text.ToString();
            ApplicationData.Current.LocalSettings.Values["p2"] = playerName2.Text.ToString();

        }

        private void backButton_Tapped(object sender, BackRequestedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));

        }
        private void homeAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }
    }

}
