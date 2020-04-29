using Microsoft.Win32;
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


namespace Recepten.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        const string pad = @"../../Assets/Artikelen2.csv";
        const char DecimaalTeken = '.';

        string[] verpakkingen =  { "100 g", "100 ml", "200 cl", "50 cl", "500 g", "75 cl", "Bot", "Doos",
                                        "doosje", "Fles", "Kg", "Liter", "pak", "Portie", "Stuk", "zak" };


        public MainWindow()
        {
            InitializeComponent();
           
        }

         private void MaakGuiLeeg()
        {
            lstArtikelen.SelectedItem = null;
            ClearPanel(grdArtikel);
            cmbEenheid.SelectedIndex = 0;
            txtPrijs.Text = "0";
            txtArtikelnaam.Focus();
            tbkFeedback.Visibility = Visibility.Hidden;
        }


    }
}
