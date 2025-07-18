using MyStoreWpfApp_EntityFrameWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        bool isLoadListviewCompleted = false;
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
            isLoadListviewCompleted = false;
            TreeViewItem item=e.NewValue as TreeViewItem;
            if (item != null)
            {
                Category category = item.Tag as Category;
                ShowProductsByCategory(category);
            }
            isLoadListviewCompleted = true;
        }
        void ShowProductsByCategory(Category category)
        {
            if (category != null)
            {
                //nạp sản phẩm của danh mục lên giao diện ListView
                var products = context.Products
               .Where(p => p.CategoryId == category.CategoryId)
               .ToList();
                lvProduct.ItemsSource = null;
                lvProduct.ItemsSource = products;
            }
        }
       

        private void lvProduct_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (isLoadListviewCompleted == false)
                return;
            if (e.AddedItems.Count < 0)
                return;
            Product p = e.AddedItems[0] as Product;
            txtMa.Text = p.ProductId + "";
            txtTen.Text = p.ProductName;
            txtSoLuong.Text = p.UnitsInStock + "";
            txtDonGia.Text = p.UnitPrice + "";
            /*Không phải lúc nào dữ liệu trên giao diện cũng là dữ liệu
             * đầy đủ của ĐỐI TƯỢNG
             * -->Trường hợp ko đầy đủ dữ liệu (ví dụ như xem CHI TIẾT NÂNG CAO)
             * thì bắt buộc ta phải Truy vấn 1 lần nữa theo ID
             */
        }

        private void btnNew_Click(object sender, RoutedEventArgs e)
        {
            txtMa.Text = "";
            txtTen.Text = "";
            txtSoLuong.Text = "";
            txtDonGia.Text = "";            
        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            //chức năng thêm mới:
            //Bước 1: Cần biết được Danh mục nào
            //để lưu sản phẩm vào
            TreeViewItem tvitem = tvCategory.SelectedItem as TreeViewItem;
            if (tvitem == null)
            {
                MessageBox.Show("Bạn phải chọn danh mục trước", "Lỗi",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            Category category = tvitem.Tag as Category;
            if (category == null)
            {
                MessageBox.Show("Bạn phải chọn danh mục trước", "Lỗi",
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //Bước 2: Tạo sản phẩm:
            Product p = new Product();
            p.ProductName = txtTen.Text;
            p.UnitsInStock = short.Parse(txtSoLuong.Text);
            p.UnitPrice = decimal.Parse(txtDonGia.Text);
            //tham chiếu khóa ngoại:
            p.CategoryId=category.CategoryId;
            //đánh dấu thêm mới
            context.Products.Add(p);
            //xác nhận thêm mới
            context.SaveChanges();
            MessageBox.Show("Đã thêm mới sản phẩm thành công");
            
            //Đưa Node Sản phẩm vào Node danh mục:
            TreeViewItem product_node = new TreeViewItem();
            product_node.Header = p.ProductName;
            product_node.Tag = p;
            tvitem.Items.Add(product_node);
            tvitem.ExpandSubtree();
            //Hiển thị danh sách sản phẩm theo node danh mục:
            ShowProductsByCategory(category);
        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            //Chức năng sửa sản phẩm:
            //Bước 1: Phải tìm ra sản phẩm muốn sửa trước
            int id = int.Parse(txtMa.Text);
            Product product=context.Products.FirstOrDefault(p=>p.ProductId==id);
            if (product == null)
                return;//tìm ko thấy sản phẩm để sửa
            //Bước 2: tiến hành đổi giá trị các thuộc tính của đối tượng
            //(chính là đổi dữ liệu từng Cell trong mỗi dòng của Table Product)
            product.ProductName = txtTen.Text;
            product.UnitsInStock=short.Parse(txtSoLuong.Text);
            product.UnitPrice = decimal.Parse(txtDonGia.Text);
            //Bước 3: Xác nhận sửa:
            context.SaveChanges();
            //Bước 4: Cập nhật lại Cây và ListView:
            //10 phút tự làm
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            //xóa sản phẩm
            //Bước 1: tìm sản phẩm để xóa:
            int id=int.Parse(txtMa.Text);
            Product product=context.Products.FirstOrDefault(p=>p.ProductId==id);
            if (product == null)
            {
                MessageBox.Show("Không tồn tại sản phẩm để xóa", "Xóa lỗi", 
                    MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            MessageBoxResult result = 
                MessageBox.Show("Bạn có chắc chắn muốn xóa sản phẩm [" + product.ProductName + "] này không?",
                "Xác nhận xóa",
                MessageBoxButton.YesNo,
                MessageBoxImage.Question
                );
            if (result == MessageBoxResult.No)
                return;//ý là không xóa nữa
            context.Products.Remove(product);
            context.SaveChanges();
            //Cập nhật lại Treeview +listview sau khi xóa (tự làm)

        }
    }
}
