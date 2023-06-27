using System.ComponentModel.DataAnnotations;
using static CoworkingSpace.Common.GeneralApplicationConstants.Amenity;


namespace CoworkingSpace.Data.Models
{
    public class Amenity
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;
    }
}
