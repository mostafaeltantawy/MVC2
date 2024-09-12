using Microsoft.AspNetCore.Routing.Constraints;

namespace MVC2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllersWithViews();// Register MVC require services (Controller Activations  , model binding , Action filtering ) to DI Container

            var app = builder.Build();

            app.UseRouting();
            app.UseStaticFiles();
            

            //app.MapGet("/",async context =>
            //{
            //    await context.Response.WriteAsync("Zalta"); 
            //});


            app.MapControllerRoute(
                name: "Default",
                pattern: /*urlpath*/ "{Controller=Home}/{action=Index}/{id:int?}" 
                //constraints: new {id = new IntRouteConstraint()}
                //defaults: new {controller = "Movies" , action = "Index"}
                );

            app.Run();
        }
    }
}
