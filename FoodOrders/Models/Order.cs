namespace FoodOrders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Status { get; set; } = "Отправлен";//2 Готовиться,3 Готов
        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int AuthorId { get; set; }
        public User? Author { get; set; }
    }
}
