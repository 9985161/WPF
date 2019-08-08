using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Exercise02
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

        Dictionary<string, string[]> cat1 = new Dictionary<string, string[]>();

        private void ListBoxItem_Selected(object sender, RoutedEventArgs e)
        {
            string[] cats = new string[3]("Apple", "Banana", "Orange");
            cat1.ItemsSource = cats;
            cat1.Add("1", new string[] { "1", "2" });
            img1.Source = new BitmapImage(new Uri("C:/Users/rossy/Desktop/WPF/WPF_Exercise02/WPF_Exercise02/images/cats01.jpg", UriKind.RelativeOrAbsolute));
            img2.Source = new BitmapImage(new Uri("C:/Users/rossy/Desktop/WPF/WPF_Exercise02/WPF_Exercise02/images/cats02.jpg", UriKind.RelativeOrAbsolute));
            item1.Content = "Selected";
        }
    }
    public class MyConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            return string.Format("item.{0}.png", value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
