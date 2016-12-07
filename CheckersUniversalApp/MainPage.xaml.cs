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
using Windows.UI.Xaml.Navigation;

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
           // a1Picture = Image.FromFile("../Pics/image1.jpg");
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            PaintBoardTiles();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            StartGame();
        }
    }
}
