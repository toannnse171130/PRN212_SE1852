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
    /// Interaction logic for LoginWindow.xaml
    /// </summary>
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, RoutedEventArgs e)
        {
            MyStoreContext context = new MyStoreContext();
            AccountMember am = context.AccountMembers
                                .FirstOrDefault(x => x.EmailAddress == txtUserName.Text 
                                && x.MemberPassword == txtPassword.Password);
            if (am != null)
            {
                if(am.MemberRole==1)
                {
                    MessageBox.Show("Đăng nhập thành công - ADMINISTRATOR");
                    AdminWindow aw = new AdminWindow();
                    aw.Show();
                    Close();
                }
                else if(am.MemberRole==2)
                {
                    MessageBox.Show("Đăng nhập thành công - Nhân viên");
                }
                else
                {
                    MessageBox.Show("Đăng nhập thành công - tài khoản khác");
                }    
            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại");
            }
        }
    }
}
