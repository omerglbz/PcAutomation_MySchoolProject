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
    public partial class OmerRam : UserControl
    {
        public OmerRam()
        {
            InitializeComponent();
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbaseram.GridDoldur(dtg_OmerRam);
        }
        string OmerRamfiyat;
        string OmerRamsepet;
        string OmerRamsite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            OmerRamsepet = ((TextBlock)dtg_OmerRam.Columns[1].GetCellContent(dtg_OmerRam.SelectedItem)).Text;
            OmerRamfiyat = ((TextBlock)dtg_OmerRam.Columns[5].GetCellContent(dtg_OmerRam.SelectedItem)).Text;
            OmerRamsite = ((TextBlock)dtg_OmerRam.Columns[7].GetCellContent(dtg_OmerRam.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = OmerRamsepet;
            item.Fiyat = OmerRamfiyat;
            item.Site = OmerRamsite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }
        }
    }
}
