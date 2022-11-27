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
    public sealed partial class s : Page
    {
        

        public s()
        {
            this.InitializeComponent();
            this.Loaded += S_Loaded;
            sLst.SelectionChanged += sLst_SelectionChanged;
        }

        private void sLst_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mys mf = (Mys)sLst.SelectedItem;
            sImg.Source = mf.sImage;
            txtBxOutput.Text = mf.sName;

            //txtBxOutput.Text = sName;
        }

        private void S_Loaded(object sender, RoutedEventArgs e)
        {
            string[] s = { "s1.jpg", "s2.jpg", "s3.jpg", "s4.jpg", "s5.jpg" };
            string[] s1 = { "Diana Shirt", "Shirt สายสก็อต", "เสื้อดรอปไหมพรม", "เเขนกุดเกาหลี", "เสื้อไหมพรมเเขนยาว" };







            List<Mys> lst = new List<Mys>();
            for (int i = 0; i < 5; i++)
            {
                BitmapImage img = new BitmapImage();
                img.UriSource = new Uri(this.BaseUri, "../Assets/s/" + s[i]);

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
