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

        public Guid ImageId { get; set; } = Guid.Parse("B93E0A19-EA35-4121-985A-5D2E33720DE4");

        public Image Image { get; set; }
        
        public ICollection<Article> Articles { get; set; }

        public ICollection<AppUser> Users { get; set; }
    }
}
