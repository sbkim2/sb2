using EFConsoleUI.DataAccess;
using EFConsoleUI.Models;
using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace EFConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateTim();
            ReadAll();
            ReadById(1);
            CreateCharity();
            UpdateFirstName(1, "Timothy");
            ReadAll();

            //RemovePhoneNumber(1, "555-1212");

            //RemoveUser(3);
            //ReadAll();

            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        public static void RemoveUser(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(e => e.EmailAddresses)
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First(); // 쿼리 결과에 포함할 엔티티를 지정함, 이때 조건은 id가 같은 것
                db.Contacts.Remove(user); // 해당 Contact 타입 객체는 삭제됨
                db.SaveChanges();
            }
        }

        public static void RemovePhoneNumber(int id, string phoneNumber)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts
                    .Include(p => p.PhoneNumbers)
                    .Where(c => c.Id == id).First();

                user.PhoneNumbers.RemoveAll(p => p.PhoneNumber == phoneNumber);

                db.SaveChanges(); // 위와 동일 내용, Phone 객체는 삭제됨
            }
        }

        private static void UpdateFirstName(int id, string firstName)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                user.FirstName = firstName;

                db.SaveChanges(); // 입력받은 id를 가지고 해당 id의 firstName 값을 변경해줌
            }
        }

        private static void CreateTim()
        {
            var c = new Contact
            {
                FirstName = "Tim",
                LastName = "Corey"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "tim@iamtimcorey.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@timothycorey.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1234" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void CreateCharity()
        {
            var c = new Contact
            {
                FirstName = "Charity",
                LastName = "Corey"
            };
            c.EmailAddresses.Add(new Email { EmailAddress = "nope@aol.com" });
            c.EmailAddresses.Add(new Email { EmailAddress = "me@timothycorey.com" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-1212" });
            c.PhoneNumbers.Add(new Phone { PhoneNumber = "555-9876" });

            using (var db = new ContactContext())
            {
                db.Contacts.Add(c);
                db.SaveChanges();
            }
        }

        private static void ReadAll()
        {
            using (var db = new ContactContext())
            {
                var records = db.Contacts
                    //.Include(e => e.EmailAddresses)
                    //.Include(p => p.PhoneNumbers)
                    .ToList();

                foreach (var c in records)
                {
                    Console.WriteLine($"{ c.FirstName } { c.LastName }");
                }
            }
        }

        private static void ReadById(int id)
        {
            using (var db = new ContactContext())
            {
                var user = db.Contacts.Where(c => c.Id == id).First();

                Console.WriteLine($"{ user.FirstName } { user.LastName }");
            }
        }
    }
}
