using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServerAPI.Models;
using ServerAPI.Repository;

namespace ServerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class OrderController : ControllerBase
    {
        private readonly IOrderRepository _orderRespository;

        public OrderController(IOrderRepository orderRespository)
        {
           _orderRespository = orderRespository;
        }


        [HttpGet("")]
        public async Task<IActionResult> GetAllOrder()
        {
            var order = await _orderRespository.GetAllOrders();

            return Ok(order); 
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetOrderById([FromRoute] string id)
        {
            var order = await _orderRespository.GetAllOrdersId(id);

            if(order == null || order.Count == 0)
            {
                return NotFound();
            }

            return Ok(order);
        }


        [HttpPost("")]
        public async Task<IActionResult> AddOrder([FromBody]OrderModel obj)
        {
            var id = await _orderRespository.AddOrder(obj);

            return CreatedAtAction(nameof(GetOrderById), new { id = id, controller = "order"}, id);
        }



        [HttpPut("{id}")]

        public async Task<IActionResult> UpdateOrder([FromBody] OrderModel obj, [FromRoute] int id)
        {
            await _orderRespository.UpdateOrderAsync(id, obj);

            return Ok();
        }


        [HttpDelete("{id}")]
        
        public async Task<IActionResult> DeleteOrder([FromRoute]int id)
        {
          await  _orderRespository.DeleteOrder(id);

            return Ok();
        }


    }

        
}
