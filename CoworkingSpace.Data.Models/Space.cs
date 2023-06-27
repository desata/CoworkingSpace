using System.ComponentModel.DataAnnotations;
using static CoworkingSpace.Common.GeneralApplicationConstants.Space;

namespace CoworkingSpace.Data.Models
{
    public class Space
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;


        [Required]
        [MaxLength(DescriptionMaxLength)]
        public string Description { get; set; } = null!;

        public string? ImgUrl { get; set; }

        [Required]
        public int CathegoryId { get; set; }

        [Required]
        public Cathegory Cathegory { get; set; } = null!;

        [Required]
        [Range(0.00, 100.00)]
        public decimal PricePerDay { get; set; }

        [Required]
        [Range(0.00, 1000.00)]
        public decimal PricePerWeek { get; set; }

        [Required]
        [Range(0.00, 10000.00)]
        public decimal PricePerMonth { get; set; }

        public Guid? RenterId { get; set; }

        public virtual Aperson? Renter { get; set; }

        public ICollection<Amenity> Amenities { get; set; } = new List<Amenity>();
    }
}