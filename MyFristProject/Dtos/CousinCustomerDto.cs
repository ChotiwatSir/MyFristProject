using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFristProject.Dtos
{
    public class CousinCustomerDto
    {
        public Guid CustomerDetailId { get; }
        public string CustomerFullName { get; } = string.Empty;
        public List<CousinListNameDto> CousinListName { get; }

        public CousinCustomerDto(Guid customerDetailId, string customerFullName, List<CousinListNameDto> cousinListName)
        {
            CustomerDetailId = customerDetailId;
            CustomerFullName = customerFullName;
            CousinListName = cousinListName;
        }



    }

    public class CousinListNameDto
    {
        public CousinListNameDto(Guid id, string cousinName)
        {
            Id = id;
            CousinName = cousinName;
        }

        public Guid Id { get; set; }
        public string CousinName { get; } = string.Empty;

    }
}