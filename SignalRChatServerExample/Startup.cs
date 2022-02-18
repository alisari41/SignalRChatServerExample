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
            //Tarayıcıda çalışması için Cors kütüphanesini ekle
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
            //Ayarladığım cros politikasını oluşturmak için
            app.UseCors();

            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chathub");
            });
        }
    }
}
