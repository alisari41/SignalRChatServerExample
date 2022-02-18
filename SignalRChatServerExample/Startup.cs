using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SignalRChatServerExample.Hubs;

namespace SignalRChatServerExample
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            //Taray�c�da �al��mas� i�in Cors k�t�phanesini ekle
            services.AddCors(options=>options.AddDefaultPolicy(policy=>
                policy.AllowCredentials()
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .SetIsOriginAllowed(x=>true)));
            //SignalR hub ekle
            services.AddSignalR();
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            //Ayarlad���m cros politikas�n� olu�turmak i�in
            app.UseCors();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
