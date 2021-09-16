using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;

namespace MongoDBUI
{
    class Program
    {
        private static MongoDBDataAccess db; // MongoDBDataAccess 타입을 가지는 속성을 정의
        private static readonly string tableName = "Contacts"; // 읽기 전용으로 Contacts 값을 가지는  tableName 속성 생성

        static void Main(string[] args)
        {
            db = new MongoDBDataAccess("MongoContactsDB", GetConnectionString("")); // MongoContactsDB 이름을 가지는 DB 생성하여 db에 저장

            ContactModel user = new ContactModel // ContactModel 타입의 user 생성
            {
                FirstName = "Charity", 
                LastName = "Corey"   // ContactModel의 각 속성 값 정의 
            };

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" }); // user객체에 EmailAddress 속성과 값을 추가함
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@timothycorey.com" }); // user객체에 EmailAddress 속성과 값을 추가함
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" }); // user 객체에 PhoneNumber 속성과 값을 추가
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" }); // user 객체에 PhoneNumber 속성과 값을 추가

            CreateContact(user);

            //GetAllContacts();

            // GetContactById("5eb4dfb2-6e63-41c7-aacd-e66fa5943985");

            //UpdateContactsFirstName("Timothy", "fb3ddc6d-a4cc-49fa-95d9-c3674cd387bb");
            //GetAllContacts();

            //RemovePhoneNumberFromUser("555-1212", "fb3ddc6d-a4cc-49fa-95d9-c3674cd387bb");

            //RemoveUser("fb3ddc6d-a4cc-49fa-95d9-c3674cd387bb");

            Console.WriteLine("Done Processing MongoDB");
            Console.ReadLine();
        }

        public static void RemoveUser(string id)
        {
            Guid guid = new Guid(id); //guid 값을 받은 객체 생성 
            db.DeleteRecord<ContactModel>(tableName, guid); // 입력받은 tableName의 테이블에서 guid를 가지는 테이블을 삭제함
        }

        public static void RemovePhoneNumberFromUser(string phoneNumber, string id) //(string phoneNumber, string id) 매개변수로 받는 매서드
        {
            Guid guid = new Guid(id); // Guid 값을 받은 객체 생성
            var contact = db.LoadRecordById<ContactModel>(tableName, guid); // guid 값을 가지는 tablename을 ContactModel 타입 객체로 불러온다
            
            
            //contact의 PhoneNumber가 입력받은 phoneNumber가 아닌것만 리스트형식으로 저장해줌
            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList();

            // tableName 이름을 가지는 db에서 입력된 레코드 값을 교체함
            db.UpsertRecord(tableName, contact.Id, contact);
        }

        private static void UpdateContactsFirstName(string firstName, string id)
        {
            Guid guid = new Guid(id); // 입력받은 id값을 가지는 Guid 타입의 객체 생성
            var contact = db.LoadRecordById<ContactModel>(tableName, guid); //  guid 값을 가지는 tablename의 ContactModel 타입 객체로 불러온다

            contact.FirstName = firstName; // contact의 FirstName 속성을 입력한 값으로 변경

            db.UpsertRecord(tableName, contact.Id, contact); // tableName 이름을 가지는 db에서 입력된 레코드 값을 교체함
        } //----------------------------------모르겠습니다----------------------------------모르겠음----------------------------------모르겠음

        private static void GetContactById(string id) // string id 을 인자로 받는 매서드
        {
            Guid guid = new Guid(id); // 입력받은 id값을 가지는 Guid 타입의 객체 생성
            var contact = db.LoadRecordById<ContactModel>(tableName, guid); // guid 값을 가지는 tablename의 ContactModel 타입 객체로 불러온다

            Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }"); // 해당 객체의 Id, FirstName, LastName을 출력함
        }

        private static void GetAllContacts()
        {
            var contacts = db.LoadRecords<ContactModel>(tableName); // tableName이름의 ContactModel 타입 객체를 불러옴

            foreach (var contact in contacts) // 받은 객체의 내용을 출력해줌
            {
                Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }"); // 객체의 각 ID와 FirstName과 LastName을 출력함
            } 
        }

        private static void CreateContact(ContactModel contact) //  ContactModel 타입을 인자로 받는 매서드
        {
            db.UpsertRecord(tableName, contact.Id, contact); // TableName 이라는 ----------------------------------모르겠습니다 ----------------------------------모르겠음
        }

        private static string GetConnectionString(string connectionStringName = "Default") // string connectionStringName 을 인자로 받는데 없을 시, 기본값은 Default 
        {
            string output = ""; // 아웃풋 초기화

            var builder = new ConfigurationBuilder() // 설정값을 받아오는 빌더임
                .SetBasePath(Directory.GetCurrentDirectory()) // 현재 작업 경로에서
                .AddJsonFile("appsettings.json"); // appsettings.json파일을 추가함


            var config = builder.Build(); //  소스(appsettings.json)에 설정된 것을 configuration에 빌드함

            output = config.GetConnectionString(connectionStringName); // 연결자문자열을 가져옴

            return output; // 연결자를 반환해준다.
        }
    }
}
