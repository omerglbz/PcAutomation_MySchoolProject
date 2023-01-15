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
    public partial class EkranKarti : UserControl
    {
        public EkranKarti()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            Databasecekme.GridDoldur(dtg_EkranKarti);
        }

        string ekrankartifiyat;
        string ekrankartisepet;
        string ekrankartisite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            ekrankartisepet = ((TextBlock)dtg_EkranKarti.Columns[1].GetCellContent(dtg_EkranKarti.SelectedItem)).Text;
            ekrankartifiyat = ((TextBlock)dtg_EkranKarti.Columns[2].GetCellContent(dtg_EkranKarti.SelectedItem)).Text;
            ekrankartisite = ((TextBlock)dtg_EkranKarti.Columns[4].GetCellContent(dtg_EkranKarti.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = ekrankartisepet;
            item.Fiyat = ekrankartifiyat;
            item.Site = ekrankartisite;
            if (Databasecekme.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }
           

        }


    }
}
