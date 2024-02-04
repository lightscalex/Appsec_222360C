using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Appsec_222360C.Model;

namespace Appsec_222360C.Pages
{
    public class HomeModel : PageModel
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public HomeModel(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public ApplicationUser currentUser { get; set; }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = await _userManager.GetUserAsync(User);

            if (user != null)
            {
                var dataProtectionProvider = DataProtectionProvider.Create("EncryptData");
                var protector = dataProtectionProvider.CreateProtector("My Secret Key");
                user.nric = protector.Unprotect(user.nric);
                currentUser = user;

                return Page();
            }

            return RedirectToPage("/Login");
        }
    }
}
