using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFristProject.Models
{
    public class CousinCustomerResponse
    {
     
        /// <summary>
        /// Id ของ Customer Detail
        /// </summary>
        /// <example> 7b6c2e67-bb4a-4d32-8047-f7aa38990176 </example>
        public Guid CustomerDetailId { get;  }

        /// <summary>
        /// ชื่อ - นามสกุล ของ customer 
        /// </summary>
        /// <example> korawi bunyuen </example>
        public string CustomerFullName { get;  } = string.Empty;

        /// <summary>
        /// ชื่อ Cousin
        /// </summary>
        /// <example> ToTO </example>
        public List<CousinListNameResponse>? CousinListNames { get;  }

        public CousinCustomerResponse(Guid customerDetailId, string customerFullName, List<CousinListNameResponse>? cousinListNames)
        {
            CustomerDetailId = customerDetailId;
            CustomerFullName = customerFullName;
            CousinListNames = cousinListNames;
        }


    }

    public class CousinListNameResponse {
        public CousinListNameResponse(Guid id, string cousinName)
        {
            Id = id;
            CousinName = cousinName;
        }

        public Guid Id { get; set; }
        public string CousinName { get; } = string.Empty;

    }
}