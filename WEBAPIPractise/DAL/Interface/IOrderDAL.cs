using WEBAPIPractise.Models;

namespace WEBAPIPractise.DAL.Interface
{
    public interface IOrderDAL
    {
        List<Order> GetOrders();

        Order InsertOrder(Order order);

        Order UpdateOrder(Order order);

        bool DeleteOrder(Order order);
    }
}
