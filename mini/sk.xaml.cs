using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace mini
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class sk : Page
    {
        public sk()
        {
            this.InitializeComponent();
            this.Loaded += Sk_Loaded;
            sLst.SelectionChanged += SLst_SelectionChanged;
        }

        private void SLst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            Mys mf = (Mys)sLst.SelectedItem;
            sImg.Source = mf.sImage;
            txtBxOutput.Text = mf.sName;
        }

        private void Sk_Loaded(object sender, RoutedEventArgs e)
        {
            string[] s = { "sk1.jpg", "sk2.jpg", "sk3.jpg", "sk4.jpg", "sk5.jpg" };
            string[] s1 = { "Milada Skirt", "Shirt ทรง A", "Shirt ทรง พลีท", "Shirt ยาวฮิป", "Tennis Shirt " };







            List<Mys> lst = new List<Mys>();
            for (int i = 0; i < 5; i++)
            {
                BitmapImage img = new BitmapImage();
                img.UriSource = new Uri(this.BaseUri, "../Assets/sk/" + s[i]);

                Mys mm = new Mys(s1[i], img/*, int.Parse(s[i, 2])*/);//สร้าง object ของคลาส Mymenu

                lst.Add(mm);
            }
            sLst.ItemsSource = lst;
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }
    }
}
