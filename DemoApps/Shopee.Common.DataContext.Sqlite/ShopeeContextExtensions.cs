using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection; // IService Collection
using System;
namespace Demo.Shared;

public static class ShopeeContextExtensions
{
    public static IServiceCollection AddShopeeContext(this IServiceCollection services, string relativePath = "..")
    {
        string databasePath = Path.Combine(relativePath, "Shopee.db");
        services.AddDbContext<ShopeeContext>(options =>
        {
            options.UseSqlite($"Data source = {databasePath}");
            options.LogTo(Console.WriteLine, new[] { Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId.CommandExecuting });
        });
        return services;
    }
}
