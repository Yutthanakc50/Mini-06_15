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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace mini
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            this.Loaded += MainPage_Loaded;
            gvMenu.SelectionChanged += GvMenu_SelectionChanged;
            me.MediaEnded += Me_MediaEnded;

            //me.Position = TimeSpan.FromSeconds(0);
            //me.Play();

        }

        private void Me_MediaEnded(object sender, RoutedEventArgs e)
        {
            me.Position = new TimeSpan(0, 0, 1);
            me.Play();
        }

        //private void mediaElement_OnMediaEnded(object sender, RoutedEventArgs e)
        //{
        //    me.Position = new TimeSpan(0, 0, 1);
        //    me.Play();
        //}
        //void me_MediaEnded(object sender, EventArgs e)
        //{
        //    //play video again
        //    me.Play();
        //}


        private void GvMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int n = gvMenu.SelectedIndex;
            switch (n)
            {
                case 0: this.Frame.Navigate(typeof(p)); break;
                case 1: this.Frame.Navigate(typeof(d)); break;
                case 2: this.Frame.Navigate(typeof(j)); break;
                case 3: this.Frame.Navigate(typeof(s)); break;
                case 4: this.Frame.Navigate(typeof(sk)); break;
                //case 5: this.Frame.Navigate(typeof(s)); break;
                //case 6: this.Frame.Navigate(typeof(p)); break;
            }
        }

        private void MainPage_Loaded(object sender, RoutedEventArgs e)
        {
            //me.Position = TimeSpan.FromSeconds(0);
            //me.Play();

            BitmapImage img1 = new BitmapImage();
            img1.UriSource = new Uri(this.BaseUri, "../Assets/Menu/Screenshot_1.png");
            MyMenu mm1 = new MyMenu("กางเกง", img1);

            BitmapImage img2 = new BitmapImage();
            img2.UriSource = new Uri(this.BaseUri, "../Assets/Menu/Screenshot_2.png");
            MyMenu mm2 = new MyMenu("เดรส", img2);

            BitmapImage img3 = new BitmapImage();
            img3.UriSource = new Uri(this.BaseUri, "../Assets/Menu/Screenshot_3.png");
            MyMenu mm3 = new MyMenu("เสื้อคลุม , เเจ็คเก็ต", img3);

            BitmapImage img4 = new BitmapImage();
            img4.UriSource = new Uri(this.BaseUri, "../Assets/Menu/Screenshot_4.png");
            MyMenu mm4 = new MyMenu("เสื้อ", img4);

            BitmapImage img5 = new BitmapImage();
            img5.UriSource = new Uri(this.BaseUri, "../Assets/Menu/Screenshot_5.png");
            MyMenu mm5 = new MyMenu("กระโปรง", img5);

            

            List<MyMenu> lst = new List<MyMenu>();
            lst.Add(mm1);
            lst.Add(mm2);
            lst.Add(mm3);
            lst.Add(mm4);
            lst.Add(mm5);
            //lst.Add(mm6);
            //lst.Add(mm7);
            gvMenu.ItemsSource = lst;


            //string[,] memus = { { "แกงจืด","แกงจืดหมููสับ.jpg"},
            //                    { "ข้าวผัด","ข้าวผัด.jpg"},
            //                    { "ต้มยำ","ต้มยำทะเล.jpg"},
            //                    { "น้ำพริก","น้ำพริกกะปิ.jpg"},
            //                    { "ผัด","ผัดโป๊ยเซียน.jpg"},
            //                    { "ของหวาน","สตรอเบอร์รีชีสพาย.jpg"},
            //                    { "น้ำดื่ม","น้ำดื่ม.jpg"}};
            //List<MyMenu> lst = new List<MyMenu>();
            //for (int i = 0; i < 7; i++)
            //{
            //    BitmapImage img = new BitmapImage();
            //    img.UriSource = new Uri(this.BaseUri, "../Assets/Menu/" + memus[i, 1]);
            //    MyMenu mm = new MyMenu(memus[i, 0], img);//สร้าง object ของคลาส Mymenu

            //    lst.Add(mm);
            //}
            //gvMenu.ItemsSource = lst;

        }
    }
}
