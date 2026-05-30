using FoodOrders.Dtos;
using FoodOrders.Models;
using FoodOrders.Services;
using Microsoft.AspNetCore.Mvc;

namespace FoodOrders.Controllers.Api
{
    [ApiController]
    [Route("/api/OrderService")]//!!!!!!!!!
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        private readonly ICurrentUserService _currentUserService;

        public OrderController(IOrderService orderService,
            ICurrentUserService currentUserService)
        {
            _orderService = orderService;
            _currentUserService = currentUserService;
        }
        [HttpGet]
        public ActionResult<List<OrderDto>> GetAll()
        {
            var logs = _orderService.GetAllOrders();
            var res = logs.Select(log => ToDo(log)).ToList();
            return Ok(res);
        }
        [HttpPost]
        public IActionResult Create(CreateOrderDto dto)
        {
            var userId = _currentUserService.GetCurrentUserId(HttpContext);
            if (userId == null)
            {
                return Unauthorized(new
                {
                    message = "Нужно войти в аккаунт"
                });
            }
            var log = new Order
            {
                Sum = 0,
                //Status = dto.Status,
                //Rate = dto.Rate,
                //CreatedAt = DateTime.Now,
                //UserId = userId.Value
            };
            _orderService.AddOrder(log);
            return Ok(new
            {
                message = "Лог сохранен"
            });
        }
        private static OrderDto ToDo(Order log)
        {
            return new OrderDto
            {
                Id = log.Id,
                //Text = log.Text,
                //VoiceName = log.VoiceName,
                //Rate = log.Rate,
                //CreatedAt = log.CreatedAt,
                //UserName = log.User?.Name
            };
        }
    }

}
