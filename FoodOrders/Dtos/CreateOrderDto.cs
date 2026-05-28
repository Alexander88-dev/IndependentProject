using System.ComponentModel.DataAnnotations;

namespace FoodOrders.Dtos
{
    public class CreateOrderDto
    {
        [Required(ErrorMessage = "Выберите продукт")]
        public string Sum { get; set; } = string.Empty;
    }
}
