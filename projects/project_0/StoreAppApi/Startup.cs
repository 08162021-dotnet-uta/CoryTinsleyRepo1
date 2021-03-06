using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using StoreAppApi.Models;
using Project0.StoreApplication.Storage.Models;
using Microsoft.OpenApi.Models;

namespace StoreAppApi
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

            services.AddControllers();

            services.AddDbContext<StoreAppApiContext>(opt =>
                                                      opt.UseInMemoryDatabase("StoreApp"));
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "StoreAppApi", Version = "v1" });
            });

            services.AddDbContext<StoreApplicationDBContext>(options =>
            {
                if (!options.IsConfigured)
                {
                    options.UseSqlServer(Configuration.GetConnectionString("ConsoleDBString"));
                }
            });

            //services.AddScoped<IRepository<>());
        }



        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "StoreAppApi v1"));
            }

            app.UseDefaultFiles();
            app.UseStaticFiles();
            app.UseStatusCodePages();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
