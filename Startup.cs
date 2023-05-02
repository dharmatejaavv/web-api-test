//using Microsoft.EntityFrameworkCore;
//using web_api_test.Models;
//using web_api_test.Repositories;

//namespace web_api_test
//{
//    public class Startup
//    {
//        public IConfiguration configRoot
//        {
//            get;
//        }
//        public Startup(IConfiguration configuration)
//        {
//            configRoot = configuration;
//        }
//        public void ConfigureServices(IServiceCollection services)
//        {
//            services.AddScoped<IEmpRepository, EmployeeRepository>();
//            services.AddDbContext<EmployeeContext>(o => o.UseSqlServer("Data source=employees.db"));
//            services.AddRazorPages();
//        }
//        public void Configure(WebApplication app, IWebHostEnvironment env)
//        {
//            if (!app.Environment.IsDevelopment())
//            {
//                app.UseExceptionHandler("/Error");
//                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//                app.UseHsts();
//            }
//            app.UseHttpsRedirection();
//            app.UseStaticFiles();
//            app.UseRouting();
//            app.UseAuthorization();
//            app.MapRazorPages();
//            app.Run();
//        }
//    }
//}
