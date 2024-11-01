using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Security.Cryptography.X509Certificates;
using WebApplication1.Domain;

namespace WebApplication1.Pages
{
    public class DynamicFormDisplaySampleModel : PageModel
    {
        public string Message { get; set; } = string.Empty;
        [BindProperty]
        public string AField { get; set; } = string.Empty;
        [BindProperty]
        public string ACollection { get; set; } = string.Empty;

        public List<SampleClass> SampleObjectCollection { get; } = new();
        public void OnGet()
        {
            Message = "*** OnGet ***";
            SampleClass SampleObject;
            SampleObject = new();
            SampleObject.FirstProperty = "1";
            SampleObject.SecondProperty = "One";
            SampleObjectCollection.Add(SampleObject);

            SampleObject = new()
            {
                FirstProperty = "2",
                SecondProperty = "Two"
            };
            SampleObjectCollection.Add(SampleObject);
            SampleObject = new()
            {
                FirstProperty = "3",
                SecondProperty = "Three"
            };
            SampleObjectCollection.Add(SampleObject);
        }
    }
}
