

namespace MyFristProject.Entities
{
    public class CousinCustomer : IIdBaseEntity, IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreateName { get; set; } = string.Empty;

        public Guid CustomerDetailId { get; set; }
        public CustomerDetail CustomerDetail { get; set; } = null!;
        public string Name { get; set; } = string.Empty;

        public CousinCustomer( string createName, Guid customerDetailId, string name)
        {
            Id = Guid.Empty;
            Created = DateTime.UtcNow;
            CreateName = createName;
            CustomerDetailId = customerDetailId;
            Name = name;

        }

    }
}