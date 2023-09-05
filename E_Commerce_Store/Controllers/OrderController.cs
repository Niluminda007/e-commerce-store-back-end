using E_Commerce_Store.DTO;
using E_Commerce_Store.Interfaces;
using E_Commerce_Store.Models;
using E_Commerce_Store.Services.OrderService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_Store.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrderController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [HttpPost("Orders/PlaceOrder")]
        [ProducesResponseType(200, Type = typeof(bool))]
        public async Task<IActionResult> PlaceOrder(OrdersDTO order)
        {
            if(!ModelState.IsValid) {
                return BadRequest(ModelState);
            }
            var orderPlaced = await _orderService.PlaceOrder(order);

            if (orderPlaced)
            {
                return Ok(true);
            }
            return BadRequest("Something went wrong while placing the order");

        }
        [HttpGet("Orders/GetOrders/{userId}")]
        [ProducesResponseType(200, Type = typeof( List<OrdersDTO>))]
        public async Task<IActionResult> GetCustomerOrders(int userId)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var orders = await _orderService.GetCustomerOrders(userId);
            return Ok(orders);
        }

    }
}
