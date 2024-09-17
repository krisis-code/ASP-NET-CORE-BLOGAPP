using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>,IEntityBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid? ImageId { get; set; } = Guid.Parse("ffcabb50-7bec-42ca-a1da-def436c61777");

        public Image Image { get; set; }
        
        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> Users { get; set; }
    }
}
