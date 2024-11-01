using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WebApplication1.Domain;
namespace WebApplication1.Pages
{
    public class DynamicDisplaySampleModel : PageModel
    {
        private List<SampleClass> _sampleObjectCollection = new();
        public List<SampleClass> SampleObjectCollection 
        {
            get
            {
                return _sampleObjectCollection;
            }
        }


        public void OnGet()
        {
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
