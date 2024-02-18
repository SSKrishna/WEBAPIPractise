using WEBAPIPractise.Models;

namespace WEBAPIPractise.DAL.Interface
{
    public interface ICustomerDAL
    {
        List<Customer> GetCustomers();

        Customer GetCustomerById(int id);

        Customer InsertCustomer(Customer customer);

        Customer UpdateCustomer(Customer customer);

        bool DeleteCustomer(int id);
    }
}
