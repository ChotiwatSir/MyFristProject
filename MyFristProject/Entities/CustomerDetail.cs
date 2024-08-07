
namespace MyFristProject.Entities
{
    public class CustomerDetail : IIdBaseEntity, IBaseEntity
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public int CoustomerId { get; set; }
        public Customer Customer { get; set; } = null!;
        public string CreateName { get; set; } = string.Empty;
        public string FristName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
    }
}