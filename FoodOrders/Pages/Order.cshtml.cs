using FoodOrders.Models;
using FoodOrders.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.JSInterop;
using System.Diagnostics.Metrics;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;
using System.Web;
using static System.Net.Mime.MediaTypeNames;


namespace FoodOrders.Pages
{
    public class OrderModel(IOrderService orderService, ICurrentUserService currentUserService, IFoodService foodService) : PageModel
    {
        private readonly IOrderService _orderService = orderService;
        private readonly ICurrentUserService _currentUserService = currentUserService;
        private readonly IFoodService _foodService = foodService;
        
        [BindProperty]
        public int Sum { get; set; }
        [BindProperty]
        public string NameFood { get; set; } = string.Empty;
        [BindProperty]
        public int CountFood { get; set; }
        
        public Dictionary<string, int> Foods = new Dictionary<string, int>();

        public int  Number { get; set; }
        public List<Order> Orders { get; set; } = new();
        public int TotalOrdersCount { get; set; }

        public string Message { get; set; } = string.Empty;


        public void OnGet()
        {
            LoadOrderss();
        }
        public IActionResult OnPostFood()
        {
            //var foodId = _foodService.GetCurrentOrderId(HttpContext);
            //if (foodId == null)
            //{
            //    return Redirect("/Index");
            //}

            //  var order = new Order
            //  {
            //   //   Sum = Sum,
            //      Number = ++Number,
            //      Status = "Отправлен",
            //      CreatedAt = DateTime.Now,
            //      AuthorId = userId.Value
            //  };

            //  foodService.AddOrder(order);
            return RedirectToPage();
        }

        public IActionResult OnPostAdd()
        {
            var userId = _currentUserService.GetCurrentUserId(HttpContext);
            if (userId == null)
            {
                return Redirect("/Index");
            }
            Console.WriteLine(Sum +"    Тест");
            if (Sum == 0)
            {
                Message = "Добавьте продукты в коину.";
                LoadOrderss();
                return Page();
            }
            //  var order = new Order
            //  {
            //   //   Sum = Sum,
            //      Number = ++Number,
            //      Status = "Отправлен",
            //      CreatedAt = DateTime.Now,
            //      AuthorId = userId.Value
            //  };

            Sum = 0;
            LoadOrderss();
            Message = "";

            //  orderService.AddOrder(order);
            return RedirectToPage();
        }
        private void LoadOrderss()
        {
            Orders = _orderService.GetAllOrders();
            TotalOrdersCount = Orders.Count;
        }
    }
}
