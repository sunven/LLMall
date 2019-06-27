using Microsoft.AspNetCore.Antiforgery;
using LLMall.Controllers;

namespace LLMall.Web.Host.Controllers
{
    public class AntiForgeryController : LLMallControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
