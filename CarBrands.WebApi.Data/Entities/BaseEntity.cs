using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarBrands.WebApi.Domain.Entities
{
    public abstract class BaseEntity
    {
        [Key]
        [Required]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The name must be up to 100 characters.")]
        public string Name { get; set; }

        [Required]
        [MaxLength(1000, ErrorMessage = "Description must be up to 500 characters.")]
        public string Description { get; set; }

        public BaseEntity()
        {
    
        }

        public BaseEntity(int id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }
    }
}
