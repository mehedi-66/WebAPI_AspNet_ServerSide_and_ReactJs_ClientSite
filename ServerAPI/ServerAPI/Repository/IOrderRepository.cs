using ServerAPI.Models;

namespace ServerAPI.Repository
{
    public interface IOrderRepository
    {
        Task<List<OrderModel>> GetAllOrders();

        Task<List<OrderModel>> GetAllOrdersId(int customerId);

        Task<int> AddOrder(OrderModel obj);

        Task UpdateOrderAsync(int id, OrderModel obj);

        Task DeleteOrder(int orderId);
    }
}
