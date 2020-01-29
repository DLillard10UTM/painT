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
//Date: 1/28/2020
namespace WPFAppTesting
{
    /// <summary>
    /// The functionality for the pain(t) project buttons.
    /// Connected to: MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //Start the canvas and set the brush size to medium.
        public MainWindow()
        {
            InitializeComponent();
            BrushSizeSlider.Value = 4.5;
        }
        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            InkCanvas.Strokes.Clear();
        }
        //Based on the brush value we change the size of the brush, the minimum for the brush size is already set
        //inside of the xaml file.
        private void BrushSizeSlider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            InkCanvas.DefaultDrawingAttributes.Width = BrushSizeSlider.Value;
            InkCanvas.DefaultDrawingAttributes.Height = BrushSizeSlider.Value;
        }
    }
}
