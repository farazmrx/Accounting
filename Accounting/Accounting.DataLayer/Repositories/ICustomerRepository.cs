using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<customers> GetAllCustomers();

        IEnumerable<customers> GetCustomersByFileter(string parameter);

        List<ListCustomerViewModel> GetNameCustomers(string filter = "");

        customers GetCustomerbyId(int customerId);

        bool InsertCustomer(customers customer);

        bool UpdateCustomer(customers customer);

        bool DeleteCustomer(customers customer);

        bool DeleteCustomer(int customerId);

        int GetCustomerIdByName(string name);

        string GetCustomerNameById(int customerId);
    }
}
