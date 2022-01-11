using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace LuckySpin
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //: enable the AddController Service; also register your LuckyNumber class for DIJ
            services.AddControllers();
            services.AddScoped<LuckyNumber>();
        }

        public void Lucky(LuckyNumber luck)
        {

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app)
        {
            //: enable the Middleware components UseRouting and UseEndpoints; add the Route pattern and default values
            app.UseRouting();
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                  name: "default",
                  pattern: "{Controller}/{action}/{id}",
                  defaults: new
                  {
                      Controller = "Spinner",
                      action = "Index",
                      luck = 7
                  }
                );
            });
        }
    }
}
