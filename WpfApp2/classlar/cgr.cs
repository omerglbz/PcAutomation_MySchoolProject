using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using WpfApp2.Kntrl;

namespace WpfApp2.classlar
{
    public class Cgr
    {
        public static void Uc_ekle(Grid grd, UserControl uc)
        {
            if(grd.Children.Count > 0)
            {
                grd.Children.Clear();
                grd.Children.Add(uc);
            }
            else
            {
                grd.Children.Add(uc);
            }
        }

      
    }
}
