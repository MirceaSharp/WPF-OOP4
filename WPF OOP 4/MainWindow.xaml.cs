using OpenXmlPowerTools;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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

namespace WPF_OOP_4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       
       
       

       


        public MainWindow()


        {
            


            InitializeComponent();
        }
       
        
        private void cbPower_Checked(object sender, RoutedEventArgs e)
        {
            






            TV Samsung = new TV("Samsung", "QLED 8K 85Q950TS (2020)", 100, 77, "Samsung.jpg");
            TV Sony = new TV("Sony", "KD-77AG9", 100, 85, "Sony.jpg");
            if (cbPower.IsChecked ==  true)
            {
                if(rdSamsung.IsChecked ==true)
                {
                    BitmapImage pic = new BitmapImage();
                    pic.BeginInit();
                    pic.UriSource = new Uri(@"Images\" + "Samsung.jpg", UriKind.Relative);
                    pic.EndInit();
                    lblBrand.Content = Samsung.Brand;
                    lblType.Content = Samsung.Type;
                    lblHerz.Content = Samsung.Herz;
                    lblImageSize.Content = Samsung.ImageSize;
                    img.Source = pic;
                }
                else if(rdSony.IsChecked ==true)
                {
                    BitmapImage pic2 = new BitmapImage();
                    pic2.BeginInit();
                    pic2.UriSource = new Uri(@"Images\" + "Sony.jpg", UriKind.Relative);
                    pic2.EndInit();
                    lblBrand.Content = Sony.Brand;
                    lblType.Content = Sony.Type;
                    lblHerz.Content = Sony.Herz;
                    lblImageSize.Content = Sony.ImageSize;
                    img.Source = pic2;


                }
            }
        }
    }
    
}
