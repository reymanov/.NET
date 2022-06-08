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

namespace Aplikacje.NET
{
    /// <summary>
    /// Logika interakcji dla klasy MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
           
        }

        private void redButton_Click(object sender, RoutedEventArgs e)
        {
            box1.Background = Brushes.Red;
            box2.Background = Brushes.Red;
            box3.Background = Brushes.Red;
        }

        private void blueButton_Click(object sender, RoutedEventArgs e)
        {
            box1.Background = Brushes.Blue;
            box2.Background = Brushes.Blue;
            box3.Background = Brushes.Blue;
        }

        private void greenButton_Click(object sender, RoutedEventArgs e)
        {
            box1.Background = Brushes.Green;
            box2.Background = Brushes.Green;
            box3.Background = Brushes.Green;
        }

        private void yellowButton_Click(object sender, RoutedEventArgs e)
        {
            box1.Background = Brushes.Yellow;
            box2.Background = Brushes.Yellow;
            box3.Background = Brushes.Yellow;
        }
    }
}
