
namespace CarBrands.WebApi.Domain.Models
{
    public class BrandDto : BaseModel
    {
        public override string Description { get; set; }
        public override DateOnly? DateCreated { get; set; }
        public string? Slogan { get; set; }
    }
}
