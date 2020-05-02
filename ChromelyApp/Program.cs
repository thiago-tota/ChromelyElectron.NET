using Chromely;
using Chromely.Core;
using Chromely.Core.Configuration;

namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            var config = DefaultConfiguration.CreateForRuntimePlatform();
            config.StartUrl = "https://localhost:44341"; //Url from ReactApp project

            AppBuilder
           .Create()
           .UseApp<ChromelyBasicApp>()
           .UseConfiguration<IChromelyConfiguration>(config)
           .Build()
           .Run(args);
        }
    }
}
