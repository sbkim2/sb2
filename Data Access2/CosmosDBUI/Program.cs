using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace CosmosDBUI
{
    class Program
    {
        private static CosmosDBDataAccess db;

        static async Task Main(string[] args)
        {
            var c = GetCosmosInfo(); //db의 설정값을 읽어옴

            db = new CosmosDBDataAccess(c.endpointUrl, c.primaryKey, c.databaseName, c.containerName); // 각속성을 가지는 객체를 db라는 변수에 담음

            ContactModel user = new ContactModel 
            {
                FirstName = "Tim",
                LastName = "Corey"
            }; // user 속성을 정의

            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "tim@iamtimcorey.com" });
            user.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@timothycorey.com" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" }); // 각 속성을 추가

            ContactModel user2 = new ContactModel
            {
                FirstName = "Charity",
                LastName = "Corey"
            }; //user2 속성을 정의

            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "nope@aol.com" });
            user2.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@timothycorey.com" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            user2.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-9876" }); // 각 속성을 추가

            //await CreateContact(user);
            //await CreateContact(user2);

            //await GetAllContacts();

            // 0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c
            //await GetContactById("0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c");

            //await UpdateContactsFirstName("Timothy", "0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c");
            //await GetContactById("0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c");

            //await RemovePhoneNumberFromUser("555-1212", "0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c");

            //await RemoveUser("0b6e24b3-95ab-4c77-9198-dbf6d9cc1e7c", "Corey");

            Console.WriteLine("Done Processing CosmosDB");
            Console.ReadLine();
        }

        public static async Task RemoveUser(string id, string lastName) // 비동기 메서드
        {
            await db.DeleteRecordAsync<ContactModel>(id, lastName); // ID와 LastName 속성을 삭제함
        }

        public static async Task RemovePhoneNumberFromUser(string phoneNumber, string id)
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id); // id에 대한 셀렉트 문을 실행해 반환값을 변수에 저장

            contact.PhoneNumbers = contact.PhoneNumbers.Where(x => x.PhoneNumber != phoneNumber).ToList(); // contact의 PhoneNumber가 입력받은 phoneNumber가 아닌것만 리스트형식으로 저장해줌

            await db.UpsertRecordAsync(contact); // contact에 대한 값을 db에 넘겨줌
        }

        private static async Task UpdateContactsFirstName(string firstName, string id) 
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id); // id에 대한 셀렉트 문을 실행해 반환값을 변수에 저장

            contact.FirstName = firstName; // 입력받은 인자값을 contact의 속성에 데이타를 정의해줌

            await db.UpsertRecordAsync(contact); // contact에 대한 값을 db에 넘겨줌
        }

        private static async Task GetContactById(string id) 
        {
            var contact = await db.LoadRecordByIdAsync<ContactModel>(id); // id에 대한 셀렉트 문을 실행해 반환값을 변수에 저장
            Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }"); // 인자로 받은 id의 각 객체의 속성을 출력 
        }

        private static async Task GetAllContacts()
        {
            var contacts = await db.LoadRecordsAsync<ContactModel>(); // id에 대한 셀렉트 문을 실행해 반환값을 변수에 저장

            foreach (var contact in contacts) // 각 값을 출력해주는 반복문
            {
                Console.WriteLine($"{ contact.Id}: { contact.FirstName } { contact.LastName }"); // contacts에 정의된 모든 속성 값을 출력 해줌
            }
        }

        private static async Task CreateContact(ContactModel contact)  
        {
            await db.UpsertRecordAsync(contact); // db에 인자로 받은 객체의 속성과 값을 생성해줌
        }

        private static (string endpointUrl, string primaryKey, string databaseName, string containerName) GetCosmosInfo()
        {
            (string endpointUrl, string primaryKey, string databaseName, string containerName) output; //---------------------모르겠습니다.-------------

            var builder = new ConfigurationBuilder() // 설정값을 받아오는 빌더
                .SetBasePath(Directory.GetCurrentDirectory()) // 현재디렉터리의
                .AddJsonFile("appsettings.json"); // appsettings.json 파일을 추가해줌

            var config = builder.Build(); //소스(appsettings.json)에 설정된 것을 configuration에 빌드함

            output.endpointUrl = config.GetValue<string>("CosmosDB:EndpointUrl"); //output.endpointUrl에 소스의 EndpointUrl에 대한 값을 지정해줌
            output.primaryKey = config.GetValue<string>("CosmosDB:PrimaryKey"); //output.primaryKey에 소스의 PrimaryKey에 대한 값을 지정해줌
            output.databaseName = config.GetValue<string>("CosmosDB:DatabaseName"); // output.databaseName에 소스의 DatabaseName에 대한 값을 지정해줌
            output.containerName = config.GetValue<string>("CosmosDB:ContainerName"); // output.containerName에 소스의 ContainerName에 대한 값을 지정해줌

            return output;
        }
    }
}
