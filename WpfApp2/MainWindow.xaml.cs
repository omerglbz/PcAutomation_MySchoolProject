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
using WpfApp2.Kntrl;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
      
        public MainWindow()
        {
            InitializeComponent();
        }

        private void bt_acKapa_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void bt_simgeDurumu_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;   
        }

        private void bt_maximized_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Normal) 
            {
                this.WindowState = WindowState.Maximized;
            }
            else
            {
                this.WindowState = WindowState.Normal;
            }
        }

        private void brd_Sagust_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                this.DragMove();
            }
        }
        private void bt_ekranKarti_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content,new EkranKarti());
            DBaglanti.BagTest();
        }

        private void bt_Islemci_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new Islemci());
            DBaglanti.BagTest();
        }
     

        private void bt_OmerRam_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new OmerRam());
            DBaglanti.BagTest();
        }


        private void bt_hdd_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new hdd());
            DBaglanti.BagTest();
        }

        private void bt_ssd_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new ssd());
            DBaglanti.BagTest();
        }

        private void bt_anakart_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new anakart());
            DBaglanti.BagTest();
        }

        private void bt_monitor_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new monitor());
            DBaglanti.BagTest();
        }

        private void bt_kasa_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new kasa());
            DBaglanti.BagTest();
        }

        private void bt_sogutucu_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new sogutucu());
            DBaglanti.BagTest();
        }

        private void bt_klavye_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new klavye());
            DBaglanti.BagTest();
        }

        private void bt_mouse_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new mouse());
            DBaglanti.BagTest();
        }

        private void bt_kulaklik_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new kulaklik());
            DBaglanti.BagTest();
        }

        private void bt_sepet_Click(object sender, RoutedEventArgs e)
        {
            Cgr.Uc_ekle(Content, new AnaSepet());
            DBaglanti.BagTest();
        }
    }
}
