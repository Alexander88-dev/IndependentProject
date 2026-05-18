namespace FoodOrders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public double Sum { get; set; }
        public string Status { get; set; } = "Отправлен";//2 Готовиться,3 Готов
        public DateTime CreatedAt { get; set; }

        public int AuthorId { get; set; }
        public User? Author { get; set; }

        public List<Food> Foods { get; set; } = new List<Food>();

    }
}
