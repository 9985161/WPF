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

namespace Wpf_Exercise03_01
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
            byte g = (byte)GSlider.Value;
            byte b = (byte)BSlider.Value;

            hex.Text = string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        private void GChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush myBrush = (SolidColorBrush)this.Resources["myBrush"];

            myBrush.Color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);

            byte r = (byte)RSlider.Value;
            byte g = (byte)GSlider.Value;
            byte b = (byte)BSlider.Value;

            hex.Text = string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        }

        private void BChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SolidColorBrush myBrush = (SolidColorBrush)this.Resources["myBrush"];

            myBrush.Color = Color.FromRgb((byte)RSlider.Value, (byte)GSlider.Value, (byte)BSlider.Value);

            byte r = (byte)RSlider.Value;
            byte g = (byte)GSlider.Value;
            byte b = (byte)BSlider.Value;

            hex.Text = string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);
        }
        public void SliderChanged()
        {
            byte r = (byte)RSlider.Value;
            byte g = (byte)GSlider.Value;
            byte b = (byte)BSlider.Value;

            hex.Text = string.Format("#{0:X2}{1:X2}{2:X2}", r, g, b);

        }
    }
}
