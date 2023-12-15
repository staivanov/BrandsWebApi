
namespace CarBrands.WebApi.Domain.Models
{
    public class CarModelDto : BaseModel
    {
        public override string Description { get; set; }
        public override DateOnly? DateCreated { get; set; }
        public int ProducedUnits { get; set; }
        public int NumberOfDoors { get; set; }
        public CoupeType CoupeType { get; set; }
    }
}
