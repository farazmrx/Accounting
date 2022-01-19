using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomerRepository
    {
        List<customers> GetAllCustomers();

        IEnumerable<customers> GetCustomersByFileter(string parameter);

        customers GetCustomerbyId(int customerId);

        bool InsertCustomer(customers customer);

        bool UpdateCustomer(customers customer);

        bool DeleteCustomer(customers customer);

        bool DeleteCustomer(int customerId);

        void save();
    }
}
