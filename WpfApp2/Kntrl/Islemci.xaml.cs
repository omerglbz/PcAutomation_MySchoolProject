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
using WpfApp2.classlar;
using WpfApp2.classlar.parametreler;

namespace WpfApp2.Kntrl
{
    /// <summary>
    /// Islemci.xaml etkileşim mantığı
    /// </summary>
    public partial class Islemci : UserControl
    {
        public Islemci()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbaseIslemci.GridDoldur(dtg_Islemci);
        }
        string Islemcifiyat;
        string Islemcisepet;
        string Islmecisite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            Islemcisepet = ((TextBlock)dtg_Islemci.Columns[1].GetCellContent(dtg_Islemci.SelectedItem)).Text;
            Islemcifiyat = ((TextBlock)dtg_Islemci.Columns[2].GetCellContent(dtg_Islemci.SelectedItem)).Text;
            Islmecisite = ((TextBlock)dtg_Islemci.Columns[7].GetCellContent(dtg_Islemci.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = Islemcisepet;
            item.Fiyat = Islemcifiyat;
            item.Site = Islmecisite; 
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }
    }
}