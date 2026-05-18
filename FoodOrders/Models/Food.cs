namespace FoodOrders.Models
{
    public class Food
    {
        public int Id { get; set; }
        public string FoodName { get; set; } = string.Empty;
        public int FoodNumber { get; set; }
        
        public DateTime CreatedAt { get; set; }
        public int OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
