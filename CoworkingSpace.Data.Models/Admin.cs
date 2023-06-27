using System.ComponentModel.DataAnnotations;
using static CoworkingSpace.Common.GeneralApplicationConstants.Admin;

namespace CoworkingSpace.Data.Models
{
    public class Admin
    {
        public Admin()
        {
            this.Id = Guid.NewGuid();
        }

        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(NameMaxLength)]
        public string Title { get; set; } = null!;
        public Guid UserId { get; set; }

        public virtual Aperson User { get; set; } = null!;

        public virtual ICollection<Space> SpacesToMange { get; set; } = new List<Space>();
    }
}
