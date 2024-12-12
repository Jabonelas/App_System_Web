using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Velzon.Context;

namespace Velzon
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // Configura os serviços da aplicação
        public void ConfigureServices(IServiceCollection services)
        {
            // Registro do contexto do Entity Framework Core
            services.AddDbContext<CApp_SystemApp_System_BancobancoSQLitedbContext>(options =>
                options.UseSqlite(Configuration.GetConnectionString("DefaultConnection")));

            // Registro de serviços personalizados
            services.AddScoped<CategoriaService>();
            services.AddScoped<ConsumidorService>();
            services.AddScoped<ProdutoService>();
            services.AddScoped<MarcasService>();
            services.AddScoped<MatrizService>();
            services.AddScoped<SubCategoriaService>();
            services.AddScoped<SecoesService>();

            // Registro do suporte a MVC (Controllers e Views)
            services.AddControllersWithViews()
                    .AddSessionStateTempDataProvider(); // Adiciona o provedor de TempData para usar sessões

            // Adiciona suporte para sessões
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(30); // Tempo de expiração da sessão
                options.Cookie.HttpOnly = true; // Aumenta a segurança da sessão
            });
        }


        // Configuração do pipeline de requisições HTTP
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            // Adiciona o suporte a sessões
            app.UseSession();  // Habilita o middleware de sessão

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Consumidores}/{action=CadastrarConsumidor}/{id?}");
                // pattern: "{controller=Categorias}/{action=Categorias}/{id?}");
            });
        }

    }

}
