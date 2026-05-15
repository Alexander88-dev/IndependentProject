using FoodOrders.Models;

namespace FoodOrders.Services
{
    public interface IOrderService
    {
        void AddOrder(Order project);
        List<Order> GetAllOrders();

        public interface IOrderService
        {
            List<Order> GetAllOrders(); //GetAllOrders
            List<Order> GetOrderByAuthorId(int authorId);
            Order? GetOrderById(int auhorId);
            void AddOrder(Order order);
            void UpdateOrder(Order order);
            void DeleteOrder(Order order);
            bool ProjectExists(int id);
        }
    }
}
