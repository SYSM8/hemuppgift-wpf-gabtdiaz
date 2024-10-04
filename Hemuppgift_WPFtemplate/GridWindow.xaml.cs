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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void ApplyColor(object sender, RoutedEventArgs e)
        {
            {
                // Läs in inmatning i textboxar och konvertera till Int
                int row = Convert.ToInt32(txtBoxRow.Text);
                int col = Convert.ToInt32(txtBoxColumn.Text);

                // Kontrollera att användaren har matat in värden
                if (txtBoxRow.Text != null && txtBoxColumn.Text != null)
                {
                    // Kontrollera att rad och kolumn är inom gränserna 0-3 (för 4x4 rutnät)
                    if (row >= 0 && row < 4 && col >= 0 && col < 4)
                    {
                        // Ändra position på knappen
                        Grid.SetRow(btnColor, row);
                        Grid.SetColumn(btnColor, col);

                        // Ändra knappens bakgrundsfärg
                        btnColor.Background = Brushes.LightGreen;

                        // Visa knappen
                        btnColor.Visibility = Visibility.Visible;
                    }
                    else
                    {
                        MessageBox.Show("Ange radnummer och kolumnnummer mellan 0-3", "Felmeddelande");
                    }
                }
                else
                {
                    MessageBox.Show("Var vänlig ange rad och kolumn", "Felmeddelande");
                }
            }
        }
    }
}
