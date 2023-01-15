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
    public partial class sogutucu : UserControl
    {
        public sogutucu()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbsogutucu.GridDoldur(dtg_sogutucu);
        }
        string sogutucufiyat;
        string sogutucusepet;
        string sogutucusite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            sogutucusepet = ((TextBlock)dtg_sogutucu.Columns[1].GetCellContent(dtg_sogutucu.SelectedItem)).Text;
            sogutucufiyat = ((TextBlock)dtg_sogutucu.Columns[5].GetCellContent(dtg_sogutucu.SelectedItem)).Text;
            sogutucusite = ((TextBlock)dtg_sogutucu.Columns[6].GetCellContent(dtg_sogutucu.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = sogutucusepet;
            item.Fiyat = sogutucufiyat;
            item.Site = sogutucusite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
