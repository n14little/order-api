using Microsoft.AspNetCore.Mvc;
using OrderApi.Models;
namespace OrderApi.Controllers;


[ApiController]
[Route("api/[controller]")]
public class OrderController : ControllerBase
{

  [HttpPost]
  public async Task<IActionResult> Create(Order newOrder)
  {
    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "method not yet implemented" });
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Update(string id, Order updatedOrder)
  {
    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "method not yet implemented" });
  }

  [HttpGet]
  public async Task<IActionResult> List()
  {
    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "method not yet implemented" });
  }

  [HttpPost("{id}/cancel")]
  public async Task<IActionResult> Cancel(string id)
  {
    return StatusCode(StatusCodes.Status500InternalServerError, new { message = "method not yet implemented" });
  }
}
