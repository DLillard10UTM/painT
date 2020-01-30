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

//Author: Danny Lillard
//Date: 1/27/2020
namespace WPFAppTesting
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
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InkCanvas.Strokes.Clear();
        }
        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InkCanvas.DefaultDrawingAttributes.Width = BrushSizeSlider.Value;
            InkCanvas.DefaultDrawingAttributes.Height = BrushSizeSlider.Value;
        }
        //Based on the slider value from 0 to 255, we change the color. Alpha is currently always set to max.
        private void BrushColorSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InkCanvas.DefaultDrawingAttributes.Color = Color.FromArgb(255, Convert.ToByte(RedColorSlider.Value), Convert.ToByte(GreenColorSlider.Value),
                Convert.ToByte(BlueColorSlider.Value));
        }
    }
}
