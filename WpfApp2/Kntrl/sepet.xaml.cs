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

namespace WpfApp2.Kntrl
{
    /// <summary>
    /// sepet.xaml etkileşim mantığı
    /// </summary>
    /// 

    

    public partial class sepet : UserControl
    {
        private Dictionary<string, string> sepets;
        public Dictionary<string, string> Sepets
        {
            get { return sepets; }
            set { sepets = value; }
        }

        

        public sepet()
        {
            InitializeComponent();

            this.DataContext = this;
            foreach (KeyValuePair<string,string> item in Sepets)
            {
                string urun = item.Key+"  "+item.Value;
                dtg_Sepet.Items.Add(urun);

            }
            
        }
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbsepet.GridDoldur(dtg_Sepet);
        }

        
    }
}
