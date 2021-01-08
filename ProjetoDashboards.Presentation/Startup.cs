using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ProjetoDashboards.Application.Contracts;
using ProjetoDashboards.Application.Services;
using ProjetoDashboards.Domain.Contracts.Repositories;
using ProjetoDashboards.Domain.Contracts.Services;
using ProjetoDashboards.Domain.Services;
using ProjetoDashboards.Infra.Data.Contexts;
using ProjetoDashboards.Infra.Data.Repositories;

namespace ProjetoDashboards.Presentation
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; set; }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //habilitar o projeto para MVC
            services.AddControllersWithViews();

            #region Configura��o do EntityFramework

            services.AddDbContext<DataContext>
                (options => options.UseSqlServer(Configuration.GetConnectionString("ProjetoDashboards")));

            #endregion

            #region Configura��o de inje��o de depend�ncia (inicializa��o)

            services.AddTransient<IMovimentacaoFinanceiraApplicationService, MovimentacaoFinanceiraApplicationService>();
            services.AddTransient<IMovimentacaoFinanceiraDomainService, MovimentacaoFinanceiraDomainService>();
            services.AddTransient<IMovimentacaoFinanceiraRepository, MovimentacaoFinanceiraRepository>();

            #endregion
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();

            //habilitar o uso da pasta /wwwroot
            app.UseStaticFiles();

            //configurando a p�gina inicial do projeto
            app.UseEndpoints(endpoints => //VS2019
            {
                //mapear a p�gina inicial do projeto (default)
                endpoints.MapControllerRoute(
                    name: "default", //p�gina padr�o
                    pattern: "{controller=Home}/{action=Index}"
                );
            });
        }
    }
}
