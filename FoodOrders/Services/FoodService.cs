using FoodOrders.Data;
using FoodOrders.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrders.Services
{
    public class FoodService : IFoodService
    {
        private readonly AppDbContext _context;
        public FoodService(AppDbContext context)
        {
            _context = context;
        }
        public List<Food> GetAllFoods()
        {
            return _context.Foods
                .Include(p => p.Order)
                .OrderByDescending(p => p.CreatedAt)
                .ThenByDescending(p => p.Id)
                .ToList();
        }
        public List<Food> GetCurrentOrderId(int orderId)
        {
            return _context.Foods
                .Include(p => p.Order)
                .Where(p => p.OrderId == orderId)
                .OrderByDescending(p => p.CreatedAt)
                .ThenByDescending(p => p.Id)
                .ToList();
        }
        public Food? GetFoodById(int id)
        {
            return _context.Foods
                .Include(p => p.Order)
                .FirstOrDefault(p => p.Id == id);
        }
        public void AddFood(Food food)
        {
            _context.Foods.Add(food);
            _context.SaveChanges();
        }
        public void UpdateFood(Food food)
        {
            _context.Foods.Update(food);
            _context.SaveChanges();
        }
        public void DeleteFood(Food food)
        {
            _context.Foods.Remove(food);
            _context.SaveChanges();
        }
        public bool FoodExists(int id)
        {
            return _context.Foods.Any(p => p.Id == id);
        }

    }
}
