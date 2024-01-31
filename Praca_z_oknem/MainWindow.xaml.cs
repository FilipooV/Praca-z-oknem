using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Praca_z_oknem
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void RadioButton_Checked(object sender, RoutedEventArgs e)
        {
            if(radio1.IsChecked == true)
            {
                textblock2.Text = radio1.Content.ToString();
            }
        }

        private void radio2_Checked(object sender, RoutedEventArgs e)
        {
            if (radio2.IsChecked == true)
            {
                textblock2.Text = radio2.Content.ToString();
            }
        }

        private void radio3_Checked(object sender, RoutedEventArgs e)
        {
            if (radio3.IsChecked == true)
            {
                textblock2.Text = radio3.Content.ToString();
            }
        }

        private void radio4_Checked(object sender, RoutedEventArgs e)
        {
            if (radio4.IsChecked == true)
            {
                textblock2.Text = radio4.Content.ToString();
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            zdjecie2.Source = new BitmapImage(new Uri("stop_zdjecie.png", UriKind.Relative));
        }

        private void przycisk_off_on_Checked(object sender, RoutedEventArgs e)
        {
            
        }

        private void przycisk_off_on_Click(object sender, RoutedEventArgs e)
        {
            if (przycisk_off_on.IsChecked == true)
            {
                zdjecie2.Source = new BitmapImage(new Uri("stop_zdjecie.jpg", UriKind.Relative));

            }
            else if (przycisk_off_on.IsChecked != true)
            {
                zdjecie2.Source = new BitmapImage(new Uri("nakaz_jazdy.jpg", UriKind.Relative));
            }
        }
    }
}