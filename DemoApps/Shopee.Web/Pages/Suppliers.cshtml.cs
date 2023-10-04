using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Shopee.Web.Pages
{
    public class SuppliersModel : PageModel
    {
        public IEnumerable<string>? Suppliers { get; set; }
        public void OnGet()
        {
            ViewData["Title"] = "Shopee B2B-Suppliers";
            Suppliers = new[]
            {
                "AQR","BlackRock","Citadel"
            };
        }
    }
}
