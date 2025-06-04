
using kolokwium2.Data;
using kolokwium2.DTOs;
using kolokwium2.Exceptions;
using Microsoft.EntityFrameworkCore;

namespace kolokwium2.Services;

public class DbService : IDbService
{
    private readonly DatabaseContext _context;

    public DbService(DatabaseContext context)
    {
        _context = context;
    }

    public async Task<CustomerOrdersDto> GetCustomerOrders(int customerId)
    {
        // var orders = await _context.PurchaseHistories
            // .Select(e => new CustomerOrdersDto
            // {
            //     FirstName = e.Customer.FirstName,
            //     LastName = e.Customer.LastName,
            //     PhoneNumber = e.Customer.PhoneNumber,
            //     Purchases = new PurchasesDto()
            //     {
            //         
            //     }
            // }).FirstOrDefaultAsync(e => e.CustomerId == customerId);
        
        // if (orders is null) throw new NotFoundException("Orders not found");
        return null;
    }

    
}