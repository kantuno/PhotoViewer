using System;
using System.Collections.Generic;
using System.IO;
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

namespace PhotoViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int image = 1;

        public MainWindow()
        {
            InitializeComponent();
            display.Source = new BitmapImage(new Uri(@"" + Directory.GetCurrentDirectory() + "/Images/" + image.ToString() + ".jpg" ));
        }

        private void NextClick(object sender, RoutedEventArgs e)
        {
            if (image < 4)
                image++;
            else
                image = 1;

            display.Source = new BitmapImage(new Uri(@"" + Directory.GetCurrentDirectory() + "/Images/" + image.ToString() + ".jpg"));
        }

        private void PrevClick(object sender, RoutedEventArgs e)
        {
            if (image > 1)
                image--;
            else
                image = 4;

            display.Source = new BitmapImage(new Uri(@"" + Directory.GetCurrentDirectory() + "/Images/" + image.ToString() + ".jpg"));
        }
    }
}
