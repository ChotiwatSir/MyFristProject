

namespace MyFristProject.Entities
{
    public class CousinCustomer : IIdBaseEntity, IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreateName { get; set; } = string.Empty;

        public int CustomerDetailId { get; set; }
        public CustomerDetail CustomerDetail { get; set; } = null!;
        public string Name { get; set; } = string.Empty;
    }
}