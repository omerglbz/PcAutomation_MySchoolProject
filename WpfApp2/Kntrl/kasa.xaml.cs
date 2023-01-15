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
    public partial class kasa : UserControl
    {
        public kasa()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbkasa.GridDoldur(dtg_kasa);
        }
        string kasafiyat;
        string kasasepet;
        string kasasite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            kasasepet = ((TextBlock)dtg_kasa.Columns[1].GetCellContent(dtg_kasa.SelectedItem)).Text;
            kasafiyat = ((TextBlock)dtg_kasa.Columns[5].GetCellContent(dtg_kasa.SelectedItem)).Text;
            kasasite = ((TextBlock)dtg_kasa.Columns[6].GetCellContent(dtg_kasa.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = kasasepet;
            item.Fiyat = kasafiyat;
            item.Site = kasasite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
