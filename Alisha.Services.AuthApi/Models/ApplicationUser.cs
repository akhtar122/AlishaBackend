using Microsoft.AspNetCore.Identity;

namespace Alisha.Services.AuthApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
