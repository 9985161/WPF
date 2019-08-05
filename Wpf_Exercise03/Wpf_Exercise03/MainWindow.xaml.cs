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

namespace Wpf_Exercise03
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SliderChanged();
        }

        private void RChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush myBrush = (SolidColorBrush)this.Resources["myBrush"];

            myBrush.Color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);

            byte r = (byte)RSlider.Value;
        }

        private void GChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush myBrush = (SolidColorBrush)this.Resources["myBrush"];

            myBrush.Color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);
        }

        private void BChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush myBrush = (SolidColorBrush)this.Resources["myBrush"];

            myBrush.Color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);
        }
        public void SliderChanged()
        {
            var color = new Color() { R = 0xF0, G = 0x10, B = 0x80 };
            var brush = new SolidColorBrush(color);
            var hexcolor = brush.Color.ToString();

            byte r = (byte)RSlider.Value;
            byte g = (byte)GSlider.Value;
            byte b = (byte)BSlider.Value;

            Color color = (Color)ColorConverter.ConvertFromString("#FFDFD991");
            color.Background = new SolidColorBrush(Color.FromArgb(255, r, g, b));
            hexcode.Text = EndColor.Background.ToString();
        }
    }
}
