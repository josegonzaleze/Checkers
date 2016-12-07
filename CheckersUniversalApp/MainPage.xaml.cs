using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
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
        public Color color1;
        public Color color2;
        public MainPage()
        {
            InitializeComponent();
            ApplicationView.PreferredLaunchWindowingMode = ApplicationViewWindowingMode.FullScreen;


            //Default
            color1 = Colors.Red;
            color2 = Colors.Black;


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
            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));

            //set up game "RED"
            a1Picture.Source = redChecker.Source;
            c1Picture.Source = redChecker.Source;
            e1Picture.Source = redChecker.Source;
            g1Picture.Source = redChecker.Source;

            b2Picture.Source = redChecker.Source;
            d2Picture.Source = redChecker.Source;
            f2Picture.Source = redChecker.Source;
            h2Picture.Source = redChecker.Source;

            a3Picture.Source = redChecker.Source;
            c3Picture.Source = redChecker.Source;
            e3Picture.Source = redChecker.Source;
            g3Picture.Source = redChecker.Source;

            //Set up game "BLACK"
            b8Picture.Source = blackChecker.Source; 
            d8Picture.Source = blackChecker.Source; 
            f8Picture.Source = blackChecker.Source; 
            h8Picture.Source = blackChecker.Source; 

            a7Picture.Source = blackChecker.Source;
            c7Picture.Source = blackChecker.Source;
            e7Picture.Source = blackChecker.Source;
            g7Picture.Source = blackChecker.Source;

            b6Picture.Source = blackChecker.Source;
            d6Picture.Source = blackChecker.Source;
            f6Picture.Source = blackChecker.Source;
            h6Picture.Source = blackChecker.Source;

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

        private void CanMOve(string str)
        {
            // Right position
            string letter = str.Substring(0, 1);
            string number = str.Substring(1, 1);

            letter = IncrementLetter(letter);
            number = (Convert.ToInt32(number) + 1).ToString();

            string ImageCode = letter + number + "Picture";
            string RectCode = letter + number + "Tile";
            Image img = FindName(ImageCode) as Image;
            Rectangle rect = FindName(RectCode) as Rectangle;

            Image blackChecker = new Image();
            blackChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/blackChecker.png"));

            Image redChecker = new Image();
            redChecker.Source = new BitmapImage(new Uri("ms-appx:///Assets/redChecker.png"));
            if (img.Source != redChecker.Source && img.Source != blackChecker.Source)
            {
               rect.Fill = new SolidColorBrush(Colors.Pink);
            }
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

        //Listeners ------------------

            //BOTTOM OF THE BOARD
        private void a1Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0,2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);

        }


        private void b2Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void a3Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void c3Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void d2Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void e3Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void f2Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void g1Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void h2Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void c1Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void e1Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void g3Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void a7Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void b6Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void c7Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void b8Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }

        private void d8Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            CanMOve(rectangleName);
        }


        //TOP OF THE BOARD

        private void f8Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            
        }

        private void h8Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
            
        }

        private void g7Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
        }

        private void e7Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
        }

        private void h6Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
        }

        private void f6Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
        }

        private void d6Picture_Tapped(object sender, TappedRoutedEventArgs e)
        {
            PaintBoardTiles();
            string imageName = ((Image)sender).Name.ToString();
            string rectangleName = imageName.Substring(0, 2) + "Tile";
            ChangeBackground(rectangleName);
        }
    }
}
