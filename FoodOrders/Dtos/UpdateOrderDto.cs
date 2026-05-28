using System.ComponentModel.DataAnnotations;

namespace FoodOrders.Dtos
{
    public class UpdateOrderDto
    {
        [Required(ErrorMessage = "Выберите продукт")]
        public string Sum { get; set; } = string.Empty;
    }
}
