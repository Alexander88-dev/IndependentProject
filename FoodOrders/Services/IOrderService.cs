using FoodOrders.Models;

namespace FoodOrders.Services
{
    public interface IOrderService
    {
        List<Order> GetAllOrders(); 
        List<Order> GetOrderByAuthorId(int authorId);
        Order? GetOrderById(int auhorId);
        void AddOrder(Order order);
        void UpdateOrder(Order order);
        void DeleteOrder(Order order);
        bool OrderExists(int id);
    }
}
/*
 Путник:
cd .\название папки  проекта\

dotnet build

dotnet ef migrations add название

dotnet ef database update
 */