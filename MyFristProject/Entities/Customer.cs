using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFristProject.Entities
{
    public class Customer : IIdBaseEntity, IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreateName { get; set; } = string.Empty;

    }
}