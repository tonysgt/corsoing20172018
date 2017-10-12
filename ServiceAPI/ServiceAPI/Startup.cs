using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;

namespace ServiceAPI
{
    public class Startup
    {

        /*questo metodo serve a configurare la pipeline di gestione delle richieste di http. Viene usata di default quella di asp.net*/
        public void ConfigureServices(IServiceCollection services)
        {
            //add the asp.net mvc server
            services.AddMvc();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseMvcWithDefaultRoute();
        }
    }
}