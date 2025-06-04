using kolokwium2.Exceptions;
using kolokwium2.Services;
using Microsoft.AspNetCore.Mvc;

namespace kolokwium2.Controllers;
[ApiController]
[Route("api/[controller]")]
public class CustomersController : ControllerBase
{
    private readonly IDbService _dbService;

    public CustomersController(IDbService dbService)
    {
        _dbService = dbService;
    }

    [HttpGet("{id}/purchases")]
    public async Task<IActionResult> GetCustomerWithOrders(int id)
    {
        try
        {
            var orders = await _dbService.GetCustomerOrders(id);
            return Ok(orders);
        }
        catch (NotFoundException e)
        {
            return NotFound(e.Message);
        }
    }
}