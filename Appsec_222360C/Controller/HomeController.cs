using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Appsec_222360C.HomeController
{
    public class HomeController : Controller
    {
        private readonly IHttpContextAccessor contxt;

        public HomeController(IHttpContextAccessor httpContextAccessor)
        {
            contxt = httpContextAccessor;
        }
    }
}
