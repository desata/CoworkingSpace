using Microsoft.AspNetCore.Identity;

namespace CoworkingSpace.Data.Models
{
    public class Aperson : IdentityUser<Guid>
    {
        public Aperson()
        {
            this.Id = Guid.NewGuid();
        }

        public virtual ICollection<Space> RentedSpaces { get; set; } = new List<Space>();
    }
}
