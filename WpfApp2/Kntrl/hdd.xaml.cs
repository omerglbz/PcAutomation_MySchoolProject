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
    public partial class hdd : UserControl
    {
        public hdd()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbasehdd.GridDoldur(dtg_hdd);
        }
        string hddfiyat;
        string hddsepet;
        string hddsite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            hddsepet = ((TextBlock)dtg_hdd.Columns[1].GetCellContent(dtg_hdd.SelectedItem)).Text;
            hddsite = ((TextBlock)dtg_hdd.Columns[6].GetCellContent(dtg_hdd.SelectedItem)).Text;
            hddfiyat = ((TextBlock)dtg_hdd.Columns[5].GetCellContent(dtg_hdd.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = hddsepet;
            item.Fiyat = hddfiyat;
            item.Site = hddsite;

            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
