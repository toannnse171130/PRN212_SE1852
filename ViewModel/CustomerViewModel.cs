using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.ComponentModel;
using ObjectModel;
namespace ViewModel
{


    public class CustomerViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Customer> Customers { get; set; }

        public CustomerViewModel()
        {
            // Fake data
            Customers = new ObservableCollection<Customer>
        {
            new Customer { Id = 1, Name = "Nguyen Van A" },
            new Customer { Id = 2, Name = "Tran Thi B" },
            new Customer { Id = 3, Name = "Le Van C" }
        };
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
