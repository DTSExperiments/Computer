using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json.Linq;

namespace plotBrembs
{
    internal class appConfig
    {
        private static IConfiguration configuration;

        public appConfig()
        {
            var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appSettings.json", optional: true, reloadOnChange: true);
            configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            // ...
            var customSettingValue = configuration["CustomSetting"];
            Console.WriteLine(customSettingValue);  // Outputs "SomeValue"
        }

        public void UpdateAppSettingValue(string key, string newValue)
        {
            // Load the appsettings.json file
            var filePath = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            var json = File.ReadAllText(filePath);
            var jObject = JObject.Parse(json);

            // Update the value
            jObject[key] = newValue;

            // Save the modified file
            File.WriteAllText(filePath, jObject.ToString());
        }

    }
}
