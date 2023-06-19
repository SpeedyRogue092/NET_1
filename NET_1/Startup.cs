using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using NET_1.Data.Mocks;
using NET_1.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using NET_1.Data.Repository;
using NET_1.DB;

namespace NET_1
{
    public class Startup
    {
		private IConfigurationRoot _confString;

		[Obsolete]
		public Startup(Microsoft.Extensions.Hosting.IHostingEnvironment hostEnv)
		{
		   _confString = new ConfigurationBuilder().SetBasePath(hostEnv.ContentRootPath).AddJsonFile("dbsettings.json").Build();
		}
		public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient<IAllToys, ToyRepository>();
            services.AddTransient<IToysCategory, CategoryRepository>();
            services.AddMvc(mvcOtions => {mvcOtions.EnableEndpointRouting = false;});
			services.AddDbContext<AppDBContent>(options => options.UseSqlServer(_confString.GetConnectionString("DefaultConnection")));

		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment
        env)
        {
         app.UseDeveloperExceptionPage();
         app.UseStatusCodePages();
         app.UseStaticFiles();
         app.UseMvcWithDefaultRoute();
		 using (var scope = app.ApplicationServices.CreateScope())
		 {
			AppDBContent content = scope.ServiceProvider.
		    GetRequiredService<AppDBContent>();
		 	DBObjects.Initial(content);
		 }

		}
	}
}
