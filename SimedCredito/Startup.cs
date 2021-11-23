using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Serialization;
using Serilog;
using Swashbuckle.AspNetCore.Swagger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace SimedCredito
{
    public class Startup
    {
        public IConfiguration Configuration { get; }


        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;

        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddMvc()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_1)
                .AddJsonOptions(options => options.SerializerSettings.ContractResolver = new DefaultContractResolver());

            services.AddCors();


            //services.AddScoped<AuthTokenFilter>();
            //services.AddScoped<IViewRenderService, ViewRenderService>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new Info { Title = "SIMED API", Version = "v1" });
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {

                c.RoutePrefix = "swagger";
                c.SwaggerEndpoint("v1/swagger.json", "Api v1");
            });


            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseStaticFiles();
            app.UseMvc();

            loggerFactory.AddSerilog();

            var LogPath = string.Empty;
            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows)) LogPath = env.WebRootPath + "\\logs\\log-{Date}.log";
            else if (RuntimeInformation.IsOSPlatform(OSPlatform.Linux)) LogPath = env.WebRootPath + "/logs/log-{Date}.log";

            Log.Logger = new LoggerConfiguration()
                .MinimumLevel.Warning()
                .WriteTo.RollingFile(LogPath)
                .CreateLogger();
        }
    }
}
