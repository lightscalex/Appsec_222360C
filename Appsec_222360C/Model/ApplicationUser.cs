using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace Appsec_222360C.Model
{
    public class ApplicationUser : IdentityUser
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string nric { get; set; }
        public DateTime dateOfBirth { get; set; }
        public string resume { get; set; }
        public string whoAmI { get; set; }
    }
}
