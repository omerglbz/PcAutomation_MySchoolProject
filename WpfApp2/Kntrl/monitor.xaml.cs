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
    public partial class monitor : UserControl
    {
        public monitor()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbasemonitor.GridDoldur(dtg_monitor);
        }
        string monitorfiyat;
        string monitorsepet;
        string monitorsite;
        private void sepete_ekle_Click(object sender, RoutedEventArgs e)
        {
            monitorsepet = ((TextBlock)dtg_monitor.Columns[1].GetCellContent(dtg_monitor.SelectedItem)).Text;
            monitorfiyat = ((TextBlock)dtg_monitor.Columns[5].GetCellContent(dtg_monitor.SelectedItem)).Text;
            monitorsite = ((TextBlock)dtg_monitor.Columns[7].GetCellContent(dtg_monitor.SelectedItem)).Text;
            spt item = new spt();
            item.Isim = monitorsepet;
            item.Fiyat = monitorfiyat;
            item.Site = monitorsite;    
            if (dtbaseanakart.Sepettekle(item))
            {
                MessageBox.Show("Sepete Eklendi");
            }


        }
    }
}
