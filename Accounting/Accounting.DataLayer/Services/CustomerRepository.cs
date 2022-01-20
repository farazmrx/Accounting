using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Repositories;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;

        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }

        public bool DeleteCustomer(customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerbyId(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<customers> GetAllCustomers()
        {
            return db.customers.ToList();
        }

        public IEnumerable<customers> GetCustomersByFileter(string parameter)
        {
            return db.customers.Where(c =>
                c.FullName.Contains(parameter) || c.Email.Contains(parameter) || c.Mobile.Contains(parameter)).ToList();
        }

        public customers GetCustomerbyId(int customerId)
        {
            return db.customers.Find(customerId);
        }

        public bool InsertCustomer(customers customer)
        {
            try
            {
                db.customers.Add(customer);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool UpdateCustomer(customers customer)
        {
            //    try
            //  {
            var local = db.Set<customers>()
                .Local
                .FirstOrDefault(f => f.CustomersID == customer.CustomersID);
            if (local != null)
            {
                db.Entry(local).State = EntityState.Detached;
            }
            db.Entry(customer).State = EntityState.Modified;
            return true;
            //   }
            //   catch
            //   {
            //       return false;
            //   }
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter = "")
        {
            if (filter == "")
            {
                return db.customers.Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomersID,
                    FullName = c.FullName
                }).ToList();
            }

            return db.customers.Where(c => c.FullName.Contains(filter)).Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomersID,
                FullName = c.FullName
            }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
            return db.customers.First(c => c.FullName == name).CustomersID;
        }
    }
}
