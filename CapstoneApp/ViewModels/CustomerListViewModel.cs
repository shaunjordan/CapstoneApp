using CapstoneApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapstoneApp.ViewModels
{
    public class CustomerListViewModel
    {
        //getcustomers gc = new GetCustomers();

        public CustomerListViewModel()
        {
            //Customers = gc.GetCustomersAsync()
        }

        public ObservableCollection<Customer> Customers { get; set; }
    }
}
