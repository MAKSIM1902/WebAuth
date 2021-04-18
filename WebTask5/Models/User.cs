using Microsoft.AspNetCore.Identity;

namespace WebTask5.Models
{
    public class User : IdentityUser
    { 
        public string RegistrationDate { get; set; }
        public string LastLogin { get; set; }
        public bool IsLockUser { get; set; }
    }
}
