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
using System.Windows.Shapes;

using BusinessObjects;
using Services;

namespace WpfApp
{
    /// <summary>
    /// Interaction logic for ProductWindow.xaml
    /// </summary>
    public partial class ProductWindow : Window
    {
        ProductService productService=new ProductService();
        public ProductWindow()
        {
            InitializeComponent();
            
            productService.InitializeDataset();

            lvProduct.ItemsSource=productService.GetProducts();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Product p = new Product();
            p.Id = int.Parse(txtMa.Text);
            p.Name=txtTen.Text; 
            p.Quantity=int.Parse(txtSoLuong.Text);
            p.Price=double.Parse(txtDonGia.Text);
            bool kq=productService.SaveProduct(p);
            if (kq==true)
            {//là lưu thành công ==> nạp lại giao diện cho Listview:
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource=productService.GetProducts();
            }
        }
    }
}
