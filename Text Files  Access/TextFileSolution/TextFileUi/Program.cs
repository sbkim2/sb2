using System;
using System.IO;
using Microsoft.Extensions.Configuration;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using System.Collections.Generic;

namespace TextFileUi
{
    class Program
    {
        private static IConfiguration _config;
        private static string textFile;
        private static TextFileDataAccess db = new TextFileDataAccess();


        static void Main(string[] args)
        {
            InitializeConfiguration();
            textFile = _config.GetValue<string>("TextFile");

            ContactModel user1 = new ContactModel();
            user1.FirstName = "Kim";
            user1.LastName = "Sangbeom";
            user1.EmailAddresses.Add("sbkim2@sw.co.kr");
            user1.EmailAddresses.Add("rla789qja@naver.com");
            user1.PhoneNumbers.Add("123-456");
            user1.PhoneNumbers.Add("777-777");

            ContactModel user2 = new ContactModel();
            user2.FirstName = "hong";
            user2.LastName = "Gildong";
            user2.EmailAddresses.Add("gdHong@sw.co.kr");
            user2.EmailAddresses.Add("ghdrlfehd@naver.com");
            user2.PhoneNumbers.Add("000-000");
            user2.PhoneNumbers.Add("111-111");


            //CreateContact(user1);
            //CreateContact(user2);
            //GetAllContacts();

            //UpdateContactsFirstName("park");
            //GetAllContacts();
            //Console.WriteLine();

            //RemovePhoneNumberFromUser("000-000");
            //GetAllContacts();

            RemoveUser();
            GetAllContacts();

            Console.WriteLine("Done Processing Text File");


            Console.ReadLine();
        }
        public static void RemoveUser()
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.RemoveAt(0);
            db.WriteAllRecords(contacts, textFile);
        }

        public static void RemovePhoneNumberFromUser(string phoneNumber) 
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].PhoneNumbers.Remove(phoneNumber);
            db.WriteAllRecords(contacts, textFile);

        }

        private static void UpdateContactsFirstName(string firstName)
            {
            var contacts = db.ReadAllRecords(textFile);
            contacts[0].FirstName = firstName;
            db.WriteAllRecords(contacts, textFile);

            } 

        

        private static void GetAllContacts()
        {
            var contacts = db.ReadAllRecords(textFile);

            foreach (var contact in contacts) // 받은 객체의 내용을 출력해줌
            {
                Console.WriteLine($"{ contact.FirstName } { contact.LastName }"); // 객체의 FirstName과 LastName을 출력함
            }
        }

        private static void CreateContact(ContactModel contact) //  ContactModel 타입을 인자로 받는 매서드
        {
            var contacts = db.ReadAllRecords(textFile);
            contacts.Add(contact);
            db.WriteAllRecords(contacts, textFile);
        }

        private static void InitializeConfiguration()
        {
           var builder = new ConfigurationBuilder() // 설정값을 받아오는 빌더
                .SetBasePath(Directory.GetCurrentDirectory()) // 현재디렉터리의
                .AddJsonFile("appsettings.json"); // appsettings.json 파일을 추가해줌

            var config = builder.Build(); //소스(appsettings.json)에 설정된 것을 configuration에 빌드함

        }
    }
}
