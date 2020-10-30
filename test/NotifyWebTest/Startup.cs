using EasyCooperation.WeChat.OfficialAccount.HttpInterfaces;
using EasyCooperation.WeChat.ThirdPartyPlatform.HttpInterface;
using EasyCooperation.WeChat.ThirdPartyPlatform.Notifies;
using EasyCooperation.WeChat.ThirdPartyPlatform.Notifies.Models;
using EasyCooperation.WeChat.ThirdPartyPlatform.Options;
using EasyCooperation.WeChat.ThirdPartyPlatform.Security;
using EasyCooperation.WeChat.ThirdPartyPlatform.Signature;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json;
using WebApiClient;

namespace NotifyWebTest
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.Configure<WeChatComponentOptions>(Configuration.GetSection(WeChatComponentOptions.WeChatComponent));
            //services.AddTransient<HttpLogFilter>();
            services.AddControllersWithViews(/*op=> op.Filters.Add<HttpLogFilter>()*/).AddXmlSerializerFormatters();         
            services.AddScoped<ComponentAuthEventPublisher>();
            services.AddSingleton<WeChatTokenSignerProvider>();
            services.AddSingleton<ComponentAuthEventDecryptor>();
            services.AddOpenApiDocument();
            services.AddMemoryCache();
            services.AddHttpApi<IComponent>();
            services.AddHttpApi<IWebPageAuth>();
            services.AddHttpApi<IComponentWebPageAuth>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            string componentVerifyTicketNotifyModel = System.IO.File.ReadAllText("./componentVerifyTicket.txt");
            app.ApplicationServices.GetRequiredService<IMemoryCache>().Set(nameof(ComponentVerifyTicketNotifyModel),JsonConvert.DeserializeObject<ComponentVerifyTicketNotifyModel>(componentVerifyTicketNotifyModel));
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
            app.UseOpenApi();
            app.UseSwaggerUi3();
        }
    }
}
