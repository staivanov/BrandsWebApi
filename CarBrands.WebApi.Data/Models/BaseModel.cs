namespace CarBrands.WebApi.Domain.Models
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public abstract string Description { get; set; }
        public abstract DateOnly? DateCreated { get; set; }
    }
}
