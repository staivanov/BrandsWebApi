using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBrands.WebApi.Domain.Entities
{
    public class Headquarter : BaseEntity
    {
        public DateOnly DateCreated { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        [ForeignKey("CarBrandId")]
        public CarBrand CarBrand { get; set; } = null!;
        //Dependent
        public int CarBrandId { get; set; }


        public Headquarter()
        {
            
        }

        public Headquarter(int id, string name, string description,
              string address, DateOnly dateCreated)
              : base(id, name, description)
        {
            Address = address;
            DateCreated = dateCreated;
        }
    }
}
