
using MyFristProject.Dtos;

namespace MyFristProject.IServices
{
    public interface ICustomerService
    {
        CousinCustomerDto CousinCustomer(Guid customerId);
    }
}