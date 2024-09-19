
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pav.Parcial2Rec.Dominio.Repositorios;
using Pav.Parcial2Rec.Infraestructura.Datos;
using Pav.Parcial2Rec.Infraestructura.Datos.Datos;
using Pav.Parcial2Rec.Infraestructura.Datos.Repositorios;
using Pav.Parcial2Rec.Infraestructura.Transversal;
using Pav.Parcial2Rec.Presentacion.Interfaces;
using Pav.Parcial2Rec.Presentacion.Presentadores;
using Pav.Parcial2Rec.Presentacion.Tareas;
using Pav.Parcial2Rec.Presentacion.Vistas;

namespace Pav.Parcial2Rec.Presentacion
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();

            var service = new ServiceCollection();
            service
                .AddDbContext<PavParcialRecContext>(options =>
                {
                    options.UseSqlServer(PavParcialRecContext.CadenaDeConexion);
                })
                .AddSingleton<Navigator>()
                .AddScoped<IPrincipalView, PrincipalView>()
                .AddScoped<IAdministrarMesasView, AdministrarMesasView>()
                .AddScoped<IAgregarMesaView, AgregarMesaView>()
                .AddScoped<IRepositorio, Repositorio>()
                .AddScoped<PrincipalPresenter>()
                .AddScoped<AdministrarMesasPresenter>()
                .AddScoped<AgregarMesaPresenter>()
                .AddScoped<PrincipalTarea>()
                .AddScoped<AdministrarMesasTarea>();


            using var serviceProvider = service.BuildServiceProvider();
            Factoria.Instance.SetContenedor(serviceProvider);
            AdministradorDeTareas.Instance.Iniciar<PrincipalTarea>();

            Application.Run(Application.OpenForms[0]!);
        }
    }
}