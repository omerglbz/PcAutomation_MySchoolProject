using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// EkranKarti.xaml etkileşim mantığı
    /// </summary>
    public partial class AnaSepet : UserControl
    {
        public AnaSepet()
        {
            InitializeComponent();
            SQLiteDataReader reader;
            string[] Para;
            double ToplamPara=0;
            SQLiteConnection con = new SQLiteConnection(DBaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("select Fiyat from Sepet", con);
            con.Open();
            reader = com.ExecuteReader();
            while (reader.Read())
            {
                string s =reader.GetString(0);               
                
                Para = s.Split(" ");
                
                foreach (string p in Para)
                {
                    bool isNumber = double.TryParse(p, out _);
                    if (isNumber)
                    {
                        double money = Convert.ToDouble(p);
                        
                        ToplamPara += money;
                    }
                    
                    
                }

            }
            TpF.Content = ToplamPara+" TL";
            reader.Close();
            con.Close();
            

        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            dtbsepet.GridDoldur(dtg_AnaSepet);
        }

        private void temizle_Click(object sender, RoutedEventArgs e)
        {
            SQLiteConnection con = new SQLiteConnection(DBaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("DELETE from Sepet", con);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
            dtbsepet.GridDoldur(dtg_AnaSepet);
            TpF.Content = "";
        }
    }
}
