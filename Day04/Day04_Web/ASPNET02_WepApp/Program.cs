using ASPNET02_WepApp.Data;
using Microsoft.EntityFrameworkCore;

namespace ASPNET02_WebApp
{
    public class Program
    {
        // ���⼭ DB ����
        // ASP.NET ������ ���� ���� �ʱ�ȭ
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            // Add services to the container.
            builder.Services.AddControllersWithViews();
            // Data���� ���� ApplicationDbContext�� ����ϰڴٴ� ���� �߰�
            builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseMySql(
                // appsettings.json ConnectionString ���� ���� ���ڿ� �Ҵ�
                //< ApplicationDbContext >�� ("DefaultConnection") ����
                builder.Configuration.GetConnectionString("DefaultConnection"),
                // ���� ���ڿ��� DB�� ���� ������ �ڵ����� ������ ��
                ServerVersion.AutoDetect(builder.Configuration.GetConnectionString("DefaultConnection"))
            ));

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

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}