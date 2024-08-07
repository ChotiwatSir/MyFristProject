
namespace MyFristProject.Entities
{
    public class CustomerDetail : IIdBaseEntity, IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public Customer Customer { get; set; } = null!;
        public Guid CustomerId { get; set; }
        public string CreateName { get; set; } = string.Empty;
        public string FristName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public ICollection<CousinCustomer>? CousinCustomers { get; set; }
        public CustomerDetail( Guid customerId, string createName, string fristName, string lastName)
        {
            Id = Guid.NewGuid();
            Created = DateTime.UtcNow;
            CustomerId = customerId;
            CreateName = createName;
            FristName = fristName;
            LastName = lastName;
        }
    }
}