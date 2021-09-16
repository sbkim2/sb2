using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;
using EFConsoleUI.Models;

namespace EFConsoleUI.DataAccess
{
    public class ContactContext : DbContext
    {
        //자동 구현 속성
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Email> EmailAddresses { get; set; }
        public DbSet<Phone> PhoneNumbers { get; set; }


        // 현재 작업경로에서 appsettings.json 읽어와 을 추가하는 빌더
        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json");
            var config = builder.Build();

            options.UseSqlServer(config.GetConnectionString("Default"));// 연결문자열은 기본값이 Default다.
        }
    }
}
