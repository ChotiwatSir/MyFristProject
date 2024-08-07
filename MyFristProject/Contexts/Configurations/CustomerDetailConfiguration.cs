using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFristProject.Entities;

namespace MyFristProject.Contexts.Configurations
{
    public class CustomerDetailConfiguration : IEntityTypeConfiguration<CustomerDetail>
    {
        public void Configure(EntityTypeBuilder<CustomerDetail> builder)
        {
            builder.HasKey(c => c.Id);
            builder.HasOne(cd => cd.Customer).WithOne(c => c.CustomerDetail).HasForeignKey<CustomerDetail>(cd => cd.CustomerId);

        }
    }
}