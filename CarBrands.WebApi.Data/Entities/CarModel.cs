using CarBrands.WebApi.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBrands.WebApi.Domain.Entities
{
    public class CarModel : BaseEntity
    {
        public DateOnly DateCreated { get; set; }

        public int ProducedUnits { get; set; }

        public int NumberOfDoors { get; set; }

        [Required]
        public CoupeType CoupeType { get; set; }

        [ForeignKey("CarBrandId")]
        public CarBrand CarBrand { get; set; }

        public int CarBrandId { get; set; }


        public CarModel() { }


        public CarModel(int id, string name, string description, DateOnly dateCreated,
            int producedUnits, int numberOfDoors, CoupeType coupeType)
            : base(id, name, description)
        {
            DateCreated = dateCreated;
            ProducedUnits = producedUnits;
            NumberOfDoors = numberOfDoors;
            CoupeType = coupeType;
        }
    }
}
