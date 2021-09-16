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
            Host.CreateDefaultBuilder(args) //Hosting.HostBuilder 클래스의 빌더를 초기화
                .ConfigureWebHostDefaults(webBuilder => // IWebHostBuilder 클래스의 빌더를 초기화
                {
                    webBuilder.UseStartup<Startup>(); // 웹호스트에서 사용할 시작 유형 지정
                });
    }
}
