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
    public partial class anakart : UserControl
    {
        public anakart()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbaseanakart.GridDoldur(dtg_anakart);
        }
        string fiyat;
        string anakartsepet;
        string anakartsite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            anakartsepet = ((TextBlock)dtg_anakart.Columns[1].GetCellContent(dtg_anakart.SelectedItem)).Text;
            fiyat = ((TextBlock)dtg_anakart.Columns[5].GetCellContent(dtg_anakart.SelectedItem)).Text;
            anakartsite= ((TextBlock)dtg_anakart.Columns[7].GetCellContent(dtg_anakart.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = anakartsepet;
            item.Fiyat= fiyat;
            item.Site= anakartsite;
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }
            
        }
    }
}
