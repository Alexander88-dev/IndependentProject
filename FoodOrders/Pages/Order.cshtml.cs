using FoodOrders.Models;
using FoodOrders.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace FoodOrders.Pages
{
    public class OrderModel : PageModel
    {
        private readonly IOrderService _projectService;
        private readonly ICurrentUserService _currentUserService;

        public OrderModel(IOrderService projectService, ICurrentUserService currentUserService)
        {
            _projectService = projectService;
            _currentUserService = currentUserService;
        }
        [BindProperty]
        public string Sum { get; set; }
        public int  Number { get; set; }
        public List<Order> Orders { get; set; } = new();
        public int TotalOrdersCount { get; set; }

        public string Message { get; set; } = string.Empty;
       
        public void OnGet()
        {
            LoadOrderss();
        }
        public IActionResult OnPostAdd()
        {
           // Sum = basketId.Text;
            var userId = _currentUserService.GetCurrentUserId(HttpContext);
            if (userId == null)
            {
                return Redirect("/Index");
            }
            if (Sum.Length == null)//!!!!!!!!!!!
            {
                Message = "Добавьте продукты в корзину.";
                LoadOrderss();
                return Page();
            }
            Console.WriteLine("Тест3");
            var order = new Order
            {
             //   Sum = Sum,
                Number = ++Number,
                Status = "Отправлен",
                CreatedAt = DateTime.Now,
                AuthorId = userId.Value
            };
            
          //  Sum = 0;
            //LoadOrderss();
            //Message = "";

            _projectService.AddOrder(order);
            return RedirectToPage();
        }
        private void LoadOrderss()
        {
            Orders = _projectService.GetAllOrders();
            TotalOrdersCount = Orders.Count;
        }
    }
}
