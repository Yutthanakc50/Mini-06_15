using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Shapes;

namespace mini
{
    class Mys
    {
        public Mys() { }
        public Mys(string fn, BitmapImage fi/*, int p*/)
        {
            sName = fn;
            sImage = fi;
            //Price = p;
        }



        public string sName { get; set; }
        public BitmapImage sImage { get; set; }
        public int Price { get; set; }
    }
    //**************************************************

}
