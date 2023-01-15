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
    public partial class mouse : UserControl
    {
        public mouse()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbmouse.GridDoldur(dtg_mouse);
        }
        string mousefiyat;
        string mousesepet;
        string mousesite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            mousesepet = ((TextBlock)dtg_mouse.Columns[1].GetCellContent(dtg_mouse.SelectedItem)).Text;
            mousefiyat = ((TextBlock)dtg_mouse.Columns[3].GetCellContent(dtg_mouse.SelectedItem)).Text;
            mousesite = ((TextBlock)dtg_mouse.Columns[4].GetCellContent(dtg_mouse.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = mousesepet;
            item.Fiyat = mousefiyat;
            item.Site = mousesite;  
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
