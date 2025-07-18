using BusinessObjects_EntityFramework;
using Services_EntityFramework;
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

namespace WpfApp_EntityFramework
{
    /// <summary>
    /// Interaction logic for AdminWindow.xaml
    /// </summary>
    public partial class AdminWindow : Window
    {
        ICategoryService iCategoryService=new CategoryService();
        IProductService iProductService=new ProductService();
        //để đánh dấu danh mục nào đang chọn trên Cây
        Category selected_category = null;
        bool is_load_product_completed = false;
        public AdminWindow()
        {
            InitializeComponent();

            LoadCategoriesAndProductIntoTreeView();
        }

        private void LoadCategoriesAndProductIntoTreeView()
        {
            is_load_product_completed = false;
            //Tạo nút gốc:
            tvCategory.Items.Clear();
            TreeViewItem root = new TreeViewItem();
            root.Header = "Kho hàng Cát Lái";
            tvCategory.Items.Add(root);
            //Nạp danh mục:
            List<Category> categories = iCategoryService.GetCategories();
            foreach (Category category in categories)
            {
                //Tạo Cate Node:
                TreeViewItem cate_node = new TreeViewItem();
                cate_node.Header = category.CategoryName;
                cate_node.Tag = category;
                root.Items.Add(cate_node);  
                
                //Đọc danh sách sản phẩm thuộc danh mục:
                category.Products=iProductService.GetProductsByCategory(category.CategoryId);
                //Nạp sản phẩm vào Node Cate:
                foreach (Product product in category.Products)
                {
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header= product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                }    
            }
            root.ExpandSubtree();
            is_load_product_completed = true;
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtMa.Clear();
            txtTen.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtMa.Focus();
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                is_load_product_completed = false;
                Product product = new Product();
                product.ProductName = txtTen.Text;
                product.UnitPrice=decimal.Parse(txtDonGia.Text);
                product.UnitsInStock=short.Parse(txtSoLuong.Text);
                //ta cần bổ sung thêm tham chiếu danh mục:
                if(selected_category!=null)
                    product.CategoryId=selected_category.CategoryId;
                bool ret= iProductService.SaveProduct(product);
                if (ret)
                {
                    //1. Nạp lại Cây:
                    TreeViewItem cate_node=tvCategory.SelectedItem as TreeViewItem;
                    if (cate_node == null || selected_category==null)
                        return;
                    TreeViewItem product_node = new TreeViewItem();
                    product_node.Header = product.ProductName;
                    product_node.Tag = product;
                    cate_node.Items.Add(product_node);
                    //2. Nạp lại ListView
                    List<Product> products = iProductService
                                   .GetProductsByCategory(selected_category.CategoryId);
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
                is_load_product_completed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi lưu mới : "+ex.Message,
                    "Thông báo lỗi",MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                is_load_product_completed = false;
                if (selected_category == null)
                    return;
                Product product = new Product();
                product.ProductId = int.Parse(txtMa.Text);
                product.ProductName = txtTen.Text;
                product.UnitPrice = decimal.Parse(txtDonGia.Text);
                product.UnitsInStock = short.Parse(txtSoLuong.Text);
                product.CategoryId = selected_category.CategoryId;
                bool ret=iProductService.UpdateProduct(product);
                if(ret)
                {
                    //Bước 1: Nạp lại cây cho Node danh mục mới đổi
                    TreeViewItem cate_node = tvCategory.SelectedItem as TreeViewItem;
                    if (cate_node == null || selected_category == null)
                        return;
                    cate_node.Items.Clear();
                    var products_by_cate = iProductService
                        .GetProductsByCategory(selected_category.CategoryId);
                    foreach (var p in products_by_cate)
                    {
                        TreeViewItem p_node = new TreeViewItem();
                        p_node.Header = p.ProductName;
                        p_node.Tag = p;
                        cate_node.Items.Add(p_node);
                    }
                    //Bước 2: Nạp lại sản phẩm trên ListView
                    List<Product> products = iProductService
                                   .GetProductsByCategory(selected_category.CategoryId);
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }
                is_load_product_completed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi CẬP NHẬT: " + ex.Message,
                    "Thông báo lỗi", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }
        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                is_load_product_completed = false;

                int product_id = int.Parse(txtMa.Text);

                //ta tự gọi messagebox để xác nhận xóa:
                bool ret=iProductService.DeleteProduct(product_id);
                if(ret)
                {
                    //Bước 1: Nạp lại cây cho Node danh mục mới đổi
                    TreeViewItem cate_node = tvCategory.SelectedItem as TreeViewItem;
                    if (cate_node == null || selected_category == null)
                        return;
                    cate_node.Items.Clear();
                    var products_by_cate = iProductService
                        .GetProductsByCategory(selected_category.CategoryId);
                    foreach (var p in products_by_cate)
                    {
                        TreeViewItem p_node = new TreeViewItem();
                        p_node.Header = p.ProductName;
                        p_node.Tag = p;
                        cate_node.Items.Add(p_node);
                    }
                    //Bước 2: Nạp lại sản phẩm trên ListView
                    List<Product> products = iProductService
                                   .GetProductsByCategory(selected_category.CategoryId);
                    lvProduct.ItemsSource = null;
                    lvProduct.ItemsSource = products;
                }    

                is_load_product_completed = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Lỗi XÓA: " + ex.Message,
                    "Thông báo lỗi", MessageBoxButton.OK,
                    MessageBoxImage.Error);
            }
        }

        private void tvCategory_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {
            if (e.NewValue == null)
                return;
            selected_category = null;
            TreeViewItem item=e.NewValue as TreeViewItem;
            Object data = item.Tag;
            if (data == null)
            {
                //có thể là người dùng nhấn vào nút GỐC
                List<Product> products = iProductService.GetProducts();
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
                return;
            }

            if (data is Category)
            {//Người dùng bấm vào nút Category
                Category category = (Category)data;
                //lưu vết lại Danh mục nào vừa được chọn:
                selected_category=category;
                List<Product> products = iProductService
                                    .GetProductsByCategory(category.CategoryId);
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
            else if (data is Product)
            {//người dùng bấm vào nút Product
                List<Product> products = new List<Product>();
                products.Add(data as Product);
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
            else
            {//có thể là người dùng nhấn vào nút GỐC
                List<Product> products = iProductService.GetProducts();
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }    
        }

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (is_load_product_completed == false)
                return;
            if (e.AddedItems.Count < 0)
                return;
            Product product=e.AddedItems[0] as Product;
            if (product == null)
                return;
            txtMa.Text=product.ProductId.ToString();
            txtTen.Text = product.ProductName.ToString();
            txtDonGia.Text = product.UnitPrice.ToString();
            txtSoLuong.Text=product.UnitsInStock.ToString();
        }

        private void mnudoimatkhau_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
