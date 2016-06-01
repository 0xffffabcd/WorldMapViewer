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

namespace WorldMapViewer
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

        private void CountryMouseEnter(object sender, MouseEventArgs e)
        {
            var path = sender as Path;
            if (path != null)
            {
                path.Fill = new SolidColorBrush(Colors.Aqua);
            }
        }

        private void Country_MouseLeave(object sender, MouseEventArgs e)
        {
            var path = sender as Path;
            if (path != null)
            {
                path.Fill = new SolidColorBrush(Colors.Black);
            }
        }
    }
}
