using System;
using JamesThew.Areas.Identity.Data;
using JamesThew.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

[assembly: HostingStartup(typeof(JamesThew.Areas.Identity.IdentityHostingStartup))]
namespace JamesThew.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<JamesThewContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("JamesThewContextConnection")));

                services.AddDefaultIdentity<JamesThewUser>()
                    .AddEntityFrameworkStores<JamesThewContext>();
            });
        }
    }
}