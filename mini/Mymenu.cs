using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Media.Imaging;

namespace mini
{
    class MyMenu
    {
        private string menuItem;
        private BitmapImage menuImage;

        public MyMenu() { }//คอนสตรัคเตอร์ว่าง
        public MyMenu(string mItem, BitmapImage mImage)//คอนสตรัคเตอร์
        {
            MenuItem = mItem;
            MenuImage = mImage;
        }
        public string MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }
        public BitmapImage MenuImage
        {
            get { return menuImage; }
            set { menuImage = value; }
        }
    }
}