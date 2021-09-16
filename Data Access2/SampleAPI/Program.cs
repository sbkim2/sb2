using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

namespace SampleAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args) //Hosting.HostBuilder Ŭ������ ������ �ʱ�ȭ
                .ConfigureWebHostDefaults(webBuilder => // IWebHostBuilder Ŭ������ ������ �ʱ�ȭ
                {
                    webBuilder.UseStartup<Startup>(); // ��ȣ��Ʈ���� ����� ���� ���� ����
                });
    }
}
