using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Pages
{
    public class ValidationDAAModel : PageModel
    {
        public string Message { get; set; } = string.Empty;

        [BindProperty]
        [Required]
        [StringLength(5, MinimumLength =1)]
        public string InputField { get; set; } = string.Empty;
        public void OnGet()
        {
            Message = "*** OnGet ***";
        }

        public void OnPost() 
        {
            if (ModelState.IsValid) 
            {
                Message = "*** OnPost *** - valid";
            }
            else
            {
                Message = "*** OnPost *** - invalid";
            }
        }
    }
}
