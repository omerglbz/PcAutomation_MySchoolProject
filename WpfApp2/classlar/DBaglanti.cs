using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.classlar
{
    public  class DBaglanti
    {
        public static string DBadres = @"Data Source=" + Environment.CurrentDirectory + "\\PC.db;version=3;New=False;Compress=True;Read Only=False;";

        public static string BagDurum;
        public static void BagTest()
        {
            using (SQLiteConnection conn = new SQLiteConnection(DBadres))
            {
                if (conn.State == ConnectionState.Closed)
                {
                    try
                    {
                        conn.Open();
                         BagDurum = "Bağlantı Kuruldu"; 
                    }
                    catch (Exception e)
                    {
                        BagDurum = "Bağlantı Hatası";
                    }
                }
                else { BagDurum = "Bağlantı Kuruldu"; }
            }
        }
    }
}
