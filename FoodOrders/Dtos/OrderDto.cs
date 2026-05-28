using FoodOrders.Models;

namespace FoodOrders.Dtos
{
    public class OrderDto
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public string Status { get; set; } = "Отправлен";
        public DateTime CreatedAt { get; set; }

        public List<Food> Foods { get; set; } = new List<Food>();

        public int AuthorId { get; set; }
        public string? AutorName { get; set; }
    }
}
