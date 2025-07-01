using MyStoreWpfApp_EntityFrameWork.Models;
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

namespace MyStoreWpfApp_EntityFrameWork
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        MyStoreContext context = new MyStoreContext();
        public AdminWindow()
        {
            InitializeComponent();
            DisplayCategoriesAndProducts();
        }

        private void DisplayCategoriesAndProducts()
        {
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Trà Vinh";
            tvCategory.Items.Add(root);

            //duyệt vòng lặp qua tất cả các danh mục
            var categories = context.Categories.ToList();
            foreach (var category in categories)
            {
                //Tạo node Category:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);
                //vòng lặp duyệt qua các Sản phẩm của Category:
                var products=context.Products
                    .Where(p=>p.CategoryId==category.CategoryId)
                    .ToList();
                foreach(var product in products)
                {
                    //tạo node Product:
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }    
            }
            root.ExpandSubtree();
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            TreeViewItem item=e.NewValue as TreeViewItem;
            if (item != null)
            {
                Category category = item.Tag as Category;
                if(category!=null)
                {
                    //nạp sản phẩm của danh mục lên giao diện ListView
                    var products = context.Products
                   .Where(p => p.CategoryId == category.CategoryId)
                   .ToList();
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }    
            }
        }
    }
}
