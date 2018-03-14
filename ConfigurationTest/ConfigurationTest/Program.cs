using System;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace ConfigurationTest
{
    class Program
    {
        static void Main(string[] args)
        {
	        var builder = new ConfigurationBuilder()
		        .SetBasePath(Directory.GetCurrentDirectory())
		        .AddJsonFile("appsettings.json")
		        .AddJsonFile("appsettings.Test.json",true,reloadOnChange:true);

	        var config = builder.Build();

			//读取配置
			Console.WriteLine(config["Alipay:AppId"]);
	        Console.WriteLine(config["Alipay:PriviteKey"]);

	        Console.WriteLine("更改文件之后，按下任意键");
			Console.ReadKey();

	        Console.WriteLine("change:");
	        Console.WriteLine(config["Alipay:AppId"]);
	        Console.WriteLine(config["Alipay:PriviteKey"]);

			Console.ReadKey();
		}
	}
}
