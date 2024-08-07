using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyFristProject.IServices;
using MyFristProject.Models;

namespace MyFristProject.Controllers
{
    [ApiController]
    [Route("[Controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        [HttpGet("{customerId}")]
        [ProducesResponseType(typeof(CousinCustomerResponse), statusCode: 200)]
        public IActionResult GetCousinCustomer(Guid customerId)
        {

            var dto = _customerService.CousinCustomer(customerId);
            var response = new CousinCustomerResponse(dto.CustomerDetailId,
                                                      dto.CustomerFullName,
                                                      dto.CousinListName
                                                                    .Select(cl => new CousinListNameResponse(
                                                                                                        cl.Id,
                                                                                                        cl.CousinName
                                                                                                        )).ToList());

            return Ok(response);
        }
    }
}