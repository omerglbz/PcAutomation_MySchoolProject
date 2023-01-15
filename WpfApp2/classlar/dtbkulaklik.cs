using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using WpfApp2.classlar.parametreler;

namespace WpfApp2.classlar
{
    public class dtbkulaklik
    {
        public static bool Sepettekle(spt item)
        {
            sbyte i = 0;
            SQLiteConnection con = new SQLiteConnection(DBaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("Insert into Sepet(Isım,Fiyat,Site) values (@Isım,@Fiyat,@Site)", con);
            com.Parameters.AddWithValue("@Site", item.Site);

            com.Parameters.AddWithValue("@Isım", item.Isim);
            com.Parameters.AddWithValue("@Fiyat", item.Fiyat);
            try
            {
                con.Open();
                i = (sbyte)com.ExecuteNonQuery();
            }
            catch (Exception ex) { MessageBox.Show(ex.ToString()); }
            finally { con.Dispose(); }
            if (i > 0) return true;
            else return false;
        }
        public static bool GridDoldur(DataGrid grd)
        {
            sbyte i = 0;
            SQLiteConnection con = new SQLiteConnection(DBaglanti.DBadres);
            SQLiteCommand com = new SQLiteCommand("select * from Kulaklik", con);
            try
            {
                SQLiteDataAdapter adp = new SQLiteDataAdapter(com);
                DataTable dt = new DataTable();
                adp.Fill(dt);
                grd.ItemsSource = null;
                grd.ItemsSource = dt.DefaultView;
            }
            catch (Exception e)
            {
                MessageBox.Show(Environment.CurrentDirectory);
            }
            finally
            {
                con.Dispose();
            }

            if (i > 0) return true; else return false;
        }
    }
}
