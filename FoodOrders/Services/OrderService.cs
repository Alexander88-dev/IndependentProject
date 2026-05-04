using FoodOrders.Data;
using FoodOrders.Models;
using Microsoft.EntityFrameworkCore;

namespace FoodOrders.Services
{
    public class OrderService : IOrderService
    {
        private readonly AppDbContext _context;
        public OrderService(AppDbContext context)
        {
            _context = context;
        }
        public List<Order> GetAllOrders()
        {
            return _context.Orders
                .Include(p => p.Author)
                .OrderByDescending(p => p.CreatedAt)
                .ThenByDescending(p => p.Id)
                .ToList();
        }
        public List<Order> GetProjectByAuthorId(int authorId)
        {
            return _context.Orders
                .Include(p => p.Author)
                .Where(p => p.AuthorId == authorId)
                .OrderByDescending(p => p.CreatedAt)
                .ThenByDescending(p => p.Id)
                .ToList();
        }
        public Order? GetOrderById(int id)
        {
            return _context.Orders
                .Include(p => p.Author)
                .FirstOrDefault(p => p.Id == id);
        }
        public void AddOrder(Order project)
        {
            _context.Orders.Add(project);
            _context.SaveChanges();
        }
        public void UpdateProject(Order project)
        {
            _context.Orders.Update(project);
            _context.SaveChanges();
        }
        public void DeleteProject(Order project)
        {
            _context.Orders.Remove(project);
            _context.SaveChanges();
        }
        public bool ProjectExists(int id)
        {
            return _context.Orders.Any(p => p.Id == id);
        }
    }
}

