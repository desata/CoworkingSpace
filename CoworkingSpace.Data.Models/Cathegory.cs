using System.ComponentModel.DataAnnotations;
using static CoworkingSpace.Common.GeneralApplicationConstants.Category;

namespace CoworkingSpace.Data.Models
{
    public class Cathegory
    {
        [Key]
        [Required]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Name { get; set; } = null!;

        public ICollection<Space> Spaces { get; set; } = new List<Space>();
    }
}
