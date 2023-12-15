using System.ComponentModel.DataAnnotations;

namespace CarBrands.WebApi.Domain.Entities
{
    public class CountryOfProduction : BaseEntity
    {
        [Required]
        [MaxLength(10, ErrorMessage = "The ISO3166 code must be up to 10 characters.")]
        public string ISO3166Code { get; set; } = null!;

        public List<CarBrand> CarBrand { get; set; }
        

        public CountryOfProduction(int id, string name, string description, string iso3166Code)
             : base(id, name, description)
        {
            ISO3166Code = iso3166Code;
        }

        public CountryOfProduction()
        {

        }
    }
}
