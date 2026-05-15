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
    public class OrderModel(IOrderService projectService, ICurrentUserService currentUserService) : PageModel
    {
        private readonly IOrderService _projectService = projectService;
        private readonly ICurrentUserService _currentUserService = currentUserService;

        [BindProperty]
        public int Sum { get; set; }//!!!!!!!!!!!
        public int  Number { get; set; }
        public List<Order> Orders { get; set; } = new();
        public int TotalOrdersCount { get; set; }

        public string Message { get; set; } = string.Empty;




        public void OnGet()
        {
            LoadOrderss();
        }
        //public partial class GlobalInterop
        //{
        //    [JSImport("globalThis.counter")]
        //    public static partial int Counter { get; }
        //}

        public IActionResult OnPostAdd()
        {
           // Sum = GlobalInterop.Counter;
            var userId = _currentUserService.GetCurrentUserId(HttpContext);
            if (userId == null)
            {
                return Redirect("/Index");
            }
            Console.WriteLine(Sum +"    Тест");
          //  if (Sum == "")//!!!!!!!!!!!
          //  {
          //      Message = "Добавьте продукты в корзину.";
          //      LoadOrderss();
          //      return Page();
          //  }
          //  var order = new Order
          //  {
          //   //   Sum = Sum,
          //      Number = ++Number,
          //      Status = "Отправлен",
          //      CreatedAt = DateTime.Now,
          //      AuthorId = userId.Value
          //  };
            
          ////  Sum = 0;
          //  //LoadOrderss();
          //  //Message = "";

          //  _projectService.AddOrder(order);
            return RedirectToPage();
        }
        private void LoadOrderss()
        {
            Orders = _projectService.GetAllOrders();
            TotalOrdersCount = Orders.Count;
        }
    }
}
