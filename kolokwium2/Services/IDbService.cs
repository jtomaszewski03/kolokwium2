
using kolokwium2.DTOs;

namespace kolokwium2.Services;

public interface IDbService
{
    public Task<CustomerOrdersDto> GetCustomerOrders(int customerId);
    
}