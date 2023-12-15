using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace CarBrands.WebApi.Domain.Entities
{
    public class CarBrand : BaseEntity
    {
        public DateOnly? DateCreated { get; set; }

        [MaxLength(100, ErrorMessage = "The slogan must be up to 100 characters.")]
        public string? Slogan { get; set; }

        public List<CarModel> CarModels { get; set; }

        public List<CountryOfProduction> CountriesOfProduction { get; set; }
        //Navigation property. Principal
        [ForeignKey("HeadquarterId")]
        public Headquarter Headquarter { get; set; }


        public CarBrand()
        {
            
        }

        public CarBrand(int id, string name, string description,
            DateOnly? dateCreated, string? slogan) : base(id, name, description)
        {
            DateCreated = dateCreated;
            Slogan = slogan;
            CarModels = new();
            CountriesOfProduction = new();
        }
    }
}
