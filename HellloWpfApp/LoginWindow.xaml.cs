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

namespace HellloWpfApp
{
    /// <summary>
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            //giả lập account
            //nếu username là obam và pass là 123
            //thì cho vào màn hình MainWindow
            if(txtUserName.Text=="obama" && txtPassword.Password=="123")
            {
                //mở màn hình main:
                MainWindow mw=new MainWindow();
                mw.Show();
                Close();//đóng màn hình đăng nhập (để thu hồi ô nhớ
                           //đã cấp cho LoginWindow luôn)
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại rồi Thím ơi!");
            }    
        }
    }
}
