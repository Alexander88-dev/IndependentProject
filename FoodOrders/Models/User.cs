namespace FoodOrders.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = string.Empty;
        public string HashPassword { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public int Age { get; set; }
        public string PersonType { get; set; } = string.Empty;
        
        public List<Order> Orders { get; set; } = new List<Order>();
    }
}
