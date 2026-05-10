using FoodOrders.Models;
using FoodOrders.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

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
        //[BindProperty]
        //public string Title { get; set; } = string.Empty;
        //[BindProperty]
        //public string Description { get; set; } = string.Empty;
        //[BindProperty]
        //public string Category { get; set; } = string.Empty;
        //[BindProperty]
        //public string Status { get; set; } = "Отправлен";
        public List<Order> Orders { get; set; } = new();
        public int TotalOrdersCount { get; set; }
        public string Message { get; set; } = string.Empty;
        //public List<string> Categories { get; } = new()
        //{
        //    "Программировать",
        //    "Играть",
        //    "Сайты",
        //    "Мобильные приложения",
        //    "Дизайн",
        //    "Другое"
        //};
        //public List<string> Statuses { get; } = new()
        //{
        //    "Идея",
        //    "В разработке",
        //    "Заершён"
        //};
        public void OnGet()
        {
            LoadOrderss();
        }
        //public IActionResult OnPostAdd()
        //{
        //    var userId = _currentUserService.GetCurrentUserId(HttpContext);

        //    if (userId == null)
        //    {
        //        return Redirect("/Index");
        //    }
        //    if (string.IsNullOrEmpty(Title) ||
        //            string.IsNullOrEmpty(Description) ||
        //            string.IsNullOrEmpty(Category) ||
        //            string.IsNullOrEmpty(Status))
        //    {
        //        Message = "Заполните все поля.";
        //        LoadProjects();
        //        return Page();
        //    }
        //    var project = new Order
        //    {
        //        Title = Title,
        //        Description = Description,
        //        Category = Category,
        //        CreatedAt = DateTime.Now,
        //        AuthorId = userId.Value
        //    };
        //    _projectService.AddOrder(project);
        //    return RedirectToPage();
        //}

        private void LoadOrderss()
        {
            Orders = _projectService.GetAllOrders();
            TotalOrdersCount = Orders.Count;
        }
    }
}
