using Services_EF;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp_EF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ICategoryService iCategoryService;
        public MainWindow()
        {
            InitializeComponent();
            iCategoryService=new CategoryService();
            lbCategory.ItemsSource = iCategoryService.GetCategories();
        }
    }
}