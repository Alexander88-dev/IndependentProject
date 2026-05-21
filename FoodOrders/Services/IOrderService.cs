using FoodOrders.Models;

namespace FoodOrders.Services
{
    public interface IOrderService
    {
        bool IsAuthenticated(HttpContext httpContext);
        int? GetCurrentOrderId(HttpContext httpContext);
        Order? GetCurrentOrder(HttpContext httpContext);
        void SignIn(HttpContext httpContext, int orderId);
        void SignOut(HttpContext httpContext);

        List<Order> GetAllOrders(); 
        List<Order> GetOrderByAuthorId(int authorId);
        Order? GetOrderById(int auhorId);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        bool OrderExists(int id);
    }
}
