namespace FoodOrders.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Status { get; set; } = "Отправлен";//2 Готовиться,3 Готов
        public DateTime OrderTime { get; set; } = DateTime.Now;
        public User? user { get; set; }
    }
}
