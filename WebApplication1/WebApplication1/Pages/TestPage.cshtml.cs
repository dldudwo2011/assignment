using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class Index1Model : PageModel
    {
        public string message { get; set; } = string.Empty;
        [BindProperty]
        public string field { get; set; } = string.Empty;
        public void OnGet()
        {
            message = "*** OnGet ***";
        }
        public void OnPost()
        {
            message = "**** OnPost ****";
            //field = Request.Form[field]!;
        }
    }
}
