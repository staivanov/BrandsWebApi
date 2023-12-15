
namespace CarBrands.WebApi.Domain.Models
{
    public class HeadquarterDto : BaseModel
    {
        public override string Description { get; set; } = null!;
        public override DateOnly? DateCreated { get; set; }
        public string Address { get; set; } = null!;
    }
}
