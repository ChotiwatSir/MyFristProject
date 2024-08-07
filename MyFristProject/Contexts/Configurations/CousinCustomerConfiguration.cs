using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MyFristProject.Entities;

namespace MyFristProject.Contexts.Configurations
{
    public class CousinCustomerConfiguration : IEntityTypeConfiguration<CousinCustomer>
    {
        public void Configure(EntityTypeBuilder<CousinCustomer> builder)
        {
            builder.HasKey(cc => cc.Id);
            builder.HasOne(cc => cc.CustomerDetail).WithMany(cd => cd.CousinCustomers).HasForeignKey(cc => cc.CustomerDetailId);

        }
    }
}