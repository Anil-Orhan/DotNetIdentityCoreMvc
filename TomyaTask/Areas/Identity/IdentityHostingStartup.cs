using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TomyaTask.Areas.Identity.Data;

[assembly: HostingStartup(typeof(TomyaTask.Areas.Identity.IdentityHostingStartup))]
namespace TomyaTask.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<TomyaDb>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("AuthConnectionString")));

                services.AddDefaultIdentity<ApplicationUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<TomyaDb>();
            });
        }
    }
}