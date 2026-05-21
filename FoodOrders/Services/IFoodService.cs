using FoodOrders.Models;

namespace FoodOrders.Services
{
    public interface IFoodService
    {
        List<Food> GetAllFoods();
        List<Food> GetCurrentOrderId(int orderId);

        Food? GetFoodById(int orderId);
        void AddFood(Food food);
        void UpdateFood(Food food);
        void DeleteFood(Food food);
        bool FoodExists(int id);
    }
}
