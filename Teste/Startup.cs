using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Teste.Repository;
using Swashbuckle.AspNetCore.Swagger;


namespace Teste
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
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddSingleton<IConfiguration>(Configuration);
            services.AddTransient<IFundosRepository, FundosRepository>();
            services.AddTransient<IResgateRepository, ResgateRepository>();

            // Inject an implementation of ISwaggerProvider with defaulted settings applied
            services.AddSwaggerGen(s =>
            {
                s.SwaggerDoc("v1", new Info
                {
                    Version = "v1",
                    Title = "Carla Soares API",
                    Description = "Carla Soares API Swagger",
                    Contact = new Contact
                    {
                        Name = "Carla Soares",
                        Email = "carlardsouza@gmail.com",
                        Url = "http://carlareginasouzasoares.atspace.cc/"
                    }
                });
                s.DescribeAllEnumsAsStrings();
                //s.CustomSchemaIds(x => x.FullName);
                s.ResolveConflictingActions(apiDescriptions => apiDescriptions.First());
                s.EnableAnnotations();
            });

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(s =>
            {
                s.SwaggerEndpoint("../swagger/v1/swagger.json", "Carla Soares API v1");
            });

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
