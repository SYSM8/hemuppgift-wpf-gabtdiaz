using System.Drawing;
using System.Windows;
using System.Windows.Media;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();

        }

        private void NavigateToGrid(object sender, RoutedEventArgs e)
        {
            GridWindow gridWindow = new GridWindow();
            gridWindow.Show();
        }
    }
}