using FoodOrders.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrders.Controllers
{
    public class AdminOrderController: Controller
    {
        public readonly IOrderService _speechLogService;
        private readonly ICurrentUserService _currentUserService;
        public AdminOrderController(IOrderService speechLogService, ICurrentUserService currentUserService)
        {
            _currentUserService = currentUserService;
            _speechLogService = speechLogService;
        }
        public IActionResult Index()
        {
            if (!_currentUserService.IsAuthenticated(HttpContext))
            {
                return RedirectToPage("/Index");
            }
            var log = _speechLogService.GetAllOrders();
            return View(log);
        }

    }
}
