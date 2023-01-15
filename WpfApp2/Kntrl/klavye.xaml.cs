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
    public partial class klavye : UserControl
    {
        public klavye()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbklavye.GridDoldur(dtg_klavye);
        }
        string klavyefiyat;
        string klavyesepet;
        string klavyesite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            klavyesepet = ((TextBlock)dtg_klavye.Columns[1].GetCellContent(dtg_klavye.SelectedItem)).Text;
            klavyefiyat = ((TextBlock)dtg_klavye.Columns[3].GetCellContent(dtg_klavye.SelectedItem)).Text;
            klavyesite = ((TextBlock)dtg_klavye.Columns[4].GetCellContent(dtg_klavye.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = klavyesepet;
            item.Fiyat = klavyefiyat;
            item.Site = klavyesite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
