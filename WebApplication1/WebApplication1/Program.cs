namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Addd service to th container 
            builder.Services.AddRazorPages();

            var app = builder.Build();

            //Configure the HTTP request pipeline

            app.UseStaticFiles(); // ADD FOR WWWROOT 
            app.UseRouting();

            app.MapRazorPages();

            //app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}
