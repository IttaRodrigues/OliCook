using OliCook.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.UI.Services;


internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        string conexao = builder.Configuration.GetConnectionString("Conexao");
        var versao = ServerVersion.AutoDetect(conexao);
        builder.Services.AddDbContext<AppDbContext>(
         Options => Options.UseMySql(conexao, versao)
        );
        builder.Services.AddIdentity<IdentityUser, IdentityRole>(
            opt => opt.SignIn.RequireConfirmedEmail = true
        )
        .AddEntityFrameworkStores<AppDbContext>()
        .AddDefaultTokenProviders();

        builder.Services.AddControllersWithViews();
        builder.Services.AddTransient<IUsuarioService, IUsuarioService>(); //mudar depois para Usuario

       // IServiceCollection serviceCollection = builder.Services.AddTransient<IEmailSender, EmailSender>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthentication();
        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
    }
}

internal interface IUsuarioService
{
}