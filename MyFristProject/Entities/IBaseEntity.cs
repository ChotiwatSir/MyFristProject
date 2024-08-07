namespace MyFristProject.Entities
{
    public interface IBaseEntity
    {
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string CreateName { get; set; }
    }

}