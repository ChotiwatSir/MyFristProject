
namespace MyFristProject.Entities
{
    public class Customer : IIdBaseEntity, IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreateName { get; set; } = string.Empty;
        public CustomerDetail? CustomerDetail { get; set; } 

        public Customer(string createName)
        {
            Id = Guid.NewGuid();
            Created = DateTime.UtcNow;
            CreateName = createName;
        }

    }

    public static class CustomerSetting 
    { 
        public const int CREATE_NAME_MAX_LENGTH = 50;
    }
}