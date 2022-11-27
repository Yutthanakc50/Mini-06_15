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
    public sealed partial class d : Page
    {
        public d()
        {
            this.InitializeComponent();
            this.Loaded += D_Loaded;
            sLst.SelectionChanged += SLst_SelectionChanged;
        }

        private void SLst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mys mf = (Mys)sLst.SelectedItem;
            sImg.Source = mf.sImage;
            //txtBxOutput.Text = mf.sName;
        }

        private void D_Loaded(object sender, RoutedEventArgs e)
        {
            string[] s = { "d1.jpg", "d2.jpg", "d3.jpg", "d4.jpg", "d5.jpg" };
            string[] s1 = { "เดรสคุณหนู", "เดรสโลลิ", "เดรสเเขนตุ๊กตา", "มินิเดรส", "มินิเดรส คอวี" };







            List<Mys> lst = new List<Mys>();
            for (int i = 0; i < 5; i++)
            {
                BitmapImage img = new BitmapImage();
                img.UriSource = new Uri(this.BaseUri, "../Assets/d/" + s[i]);

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
