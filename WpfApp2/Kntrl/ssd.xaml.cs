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
    /// EkranKarti.xaml etkileşim mantığı
    /// </summary>
    public partial class ssd : UserControl
    {
        public ssd()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbasessd.GridDoldur(dtg_ssd);
        }
        string ssdfiyat;
        string ssdsepet;
        string ssdsite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            ssdsepet = ((TextBlock)dtg_ssd.Columns[1].GetCellContent(dtg_ssd.SelectedItem)).Text;
            ssdfiyat = ((TextBlock)dtg_ssd.Columns[5].GetCellContent(dtg_ssd.SelectedItem)).Text;
            ssdsite = ((TextBlock)dtg_ssd.Columns[6].GetCellContent(dtg_ssd.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = ssdsepet;
            item.Fiyat = ssdfiyat;
            item.Site = ssdsite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
