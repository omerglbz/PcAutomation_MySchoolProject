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
    public partial class kulaklik : UserControl
    {
        public kulaklik()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbkulaklik.GridDoldur(dtg_kulaklik);
        }
        string kulaklikfiyat;
        string kulakliksepet;
        string kulakliksite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            kulakliksepet = ((TextBlock)dtg_kulaklik.Columns[1].GetCellContent(dtg_kulaklik.SelectedItem)).Text;
            kulaklikfiyat = ((TextBlock)dtg_kulaklik.Columns[3].GetCellContent(dtg_kulaklik.SelectedItem)).Text;
            kulakliksite = ((TextBlock)dtg_kulaklik.Columns[4].GetCellContent(dtg_kulaklik.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = kulakliksepet;
            item.Fiyat = kulaklikfiyat;
            item.Site = kulakliksite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
