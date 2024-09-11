using System;
using MyNamespace;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.IO;
namespace MyNamespace
{

    class Program
    {
        static IConfigurationRoot configuration;

        static async Task Main(string[] args)
        {
            // 设置配置文件路径
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);

            configuration = builder.Build();

            // 读取配置值
            string appName = configuration["MyAppSettings:ApplicationName"];
            string version = configuration["MyAppSettings:Version"];

            Console.WriteLine($"App Name: {appName}, Version: {version}");

            MyClass myClassInstance = new MyClass();

            List<int> result = await myClassInstance.GetDataAsync();

            // myClassInstance.ArrayMethod();
            // myClassInstance.ListMethod();
            // myClassInstance.DictionaryMethod();
            // myClassInstance.LinqMethod();

        }
    }
}
