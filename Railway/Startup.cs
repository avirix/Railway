using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Railway.Models.Database;
using Railway.Models.Entities;
using Railway.Models.Interfaces;
using Railway.Services;

namespace Railway
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
            services.AddDbContext<IteaDbContext>(options =>
                options.UseSqlServer(
#if DEBUG
                    Configuration.GetConnectionString("SQLConnectionString")
#else
                    Configuration.GetConnectionString("SQLConnectionString_Release")
#endif
                    )
            );

            services.AddTransient<IService<User>, UserService>();
            services.AddTransient<IService<Station>, StationService>();

            services.AddTransient<IService<Carriage>, CarriageSService>();

            services.AddMvc(options => { options.AllowEmptyInputInBodyModelBinding = true; })
                .AddJsonOptions(options =>
                {
                    options.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
                    options.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                })
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseMvc();
        }
    }
}
