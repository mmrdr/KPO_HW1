using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using Microsoft.Extensions.DependencyInjection;
using ZooManagementApp.Domain.Entities;
using ZooManagementApp.Domain.Abstractions;
namespace ZooManagementApp;

class Program
{
    static void Main(string[] args)
    {
        var services = new ServiceCollection();
        services.AddSingleton<IVeterinaryClinic, VeterinaryClinic>();
        services.AddSingleton<IZooLogic, Zoo>();
        services.AddSingleton<IZooFactory, ZooFactory>();
        var provider = services.BuildServiceProvider();
        var zoo = provider.GetService<IZooLogic>();
        var zooFactory = provider.GetService<IZooFactory>();
        var menu = new Menu(); 
        menu.RunApp(zoo, zooFactory);
    }
}