using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyFristProject.Entities
{
    public interface IIdBaseEntity
    {
        public Guid Id { get; set; }
    }

}