using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace CheckersUniversalApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class SettingsPage : Page
    {
        public static Color color1 = Colors.Red;
        public static Color color2 = Colors.Black;

        public static string name1 = "Player 1";
        public static string name2 = "Player 2";
        private string username;

        public SettingsPage()
        {
            this.InitializeComponent();
        }

        private void redRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            colorTest.Fill = brush;
            color1 = Colors.Red;
        }

        private void blueRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            colorTest.Fill = brush;
            color1 = Colors.Blue;
        }
        private void greenRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Green);
            colorTest.Fill = brush;
            color1 = Colors.Green;
        }
        private void yellowRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Yellow);
            colorTest.Fill = brush;
            color1 = Colors.Yellow;
        }
        private void purpleRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Purple);
            colorTest.Fill = brush;
            color1 = Colors.Purple;
        }

        private void redRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);
            colorTest2.Fill = brush;
            color2 = Colors.Red;
        }

        private void blueRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Blue);
            colorTest2.Fill = brush;
            color2 = Colors.Blue;
        }

        private void greenRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Green);
            colorTest2.Fill = brush;
            color2 = Colors.Green;
        }

        private void yellowRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Yellow);
            colorTest2.Fill = brush;
            color2 = Colors.Yellow;
        }

        private void purpleRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Purple);
            colorTest2.Fill = brush;
            color2 = Colors.Purple;
        }

        private void blackRB1_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            colorTest.Fill = brush;
            color1 = Colors.Black;
        }

        private void blackRB2_Checked(object sender, RoutedEventArgs e)
        {
            SolidColorBrush brush = new SolidColorBrush(Colors.Black);
            colorTest2.Fill = brush;
            color2 = Colors.Black;
        }


        //Back button https://www.youtube.com/watch?v=lTpfegXtEH4
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            if (ApplicationData.Current.LocalSettings.Values.ContainsKey("username"))
            {
                string username = ApplicationData.Current.LocalSettings.Values["username"] as string;

                var composite = ApplicationData.Current.LocalSettings.Values["pageState"] as ApplicationDataCompositeValue;
                nameBox1.Text = composite["name1"] as string;
                nameBox2.Text = composite["name2"] as string;

            }
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
           ApplicationData.Current.LocalSettings.Values["username"] = username;

            var composite = new ApplicationDataCompositeValue();
            composite["name1"] = nameBox1.Text;
            composite["name2"] = nameBox2.Text;
            ApplicationData.Current.LocalSettings.Values["pageState"] = composite;
        }

        private void homeAppBarButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainMenu));
        }

        private void nameBox1_TextChanged(object sender, TextChangedEventArgs e)
        {
            name1 = nameBox1.Text;
        }

        private void nameBox2_TextChanged(object sender, TextChangedEventArgs e)
        {
            name2 = nameBox2.Text;
        }
    }
}
