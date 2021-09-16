using LinqUI.Models;
using System;
using System.Linq; // 람다식에 관한 클래스

namespace LinqUI
{
    class Program
    {
        static void Main(string[] args)
        {
            LambdaTests();
           // LinqTests();
            Console.WriteLine("Done Processing");
            Console.ReadLine();
        }

        private static void LinqTests()
        {
            var contacts = SampleData.GetContactData(); // ContactModel의 각 속성을 가져옴
            var addresses = SampleData.GetAddressData(); // AddressModel의 각 속성을 가져옴

            //var results = (from c in contacts
            //               where c.Addresses.Count > 1
            //               select c);  // contacts의 Addresses 데이터 수가 1개 이상의 contectmedel 을 반환해줌

            //var results = (from c in contacts
            //               join a in addresses
            //               on c.Id equals a.ContactId
            //               select new { c.FirstName, c.LastName, a.City, a.State }); //   List<ContactModel>과 List<AddressModel>에서 ContactModel의 id와 AddressModel의 ContactId 가
            //                                                                         //   같은 것을 join 하여 객체로 전달해줌

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName } from { item.City }, { item.State }");
            //}

            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(x => x.ContactId == c.Id) }); //   List<ContactModel>과 List<AddressModel>에서 ContactModel의 id와 AddressModel의 ContactId 같은 것을 객채로 반환
            //                                                                                                               //   이때 . Addresses 속성에는 AddressModel을 받는다

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName } - { item.Addresses.Count() }"); // 각 객체의 성과 이름을 출력하며, 각 객체의 Addresses속성을 카운트해줌
            //}

            //var results = (from c in contacts
            //               select new { c.FirstName, c.LastName, Addresses = addresses.Where(a => c.Addresses.Contains(a.Id)) }); // ContactModel의 Addresses 리스트의 값들 로  AddressModel의 id를 포함하는 것을
            //                                                                                                                      // 객체로 넘겨준다.. Addresses로 AddressModel 타입으로 받는다

            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName } - { item.Addresses.Count() }"); // 객체의 각 성과 이름을 출력하면서, Addresses 속성의 갯수를 출력해줌
            //}
        }

        private static void LambdaTests()
        {
            var data = SampleData.GetContactData();

            //var results = data.Where(c => c.Addresses.Count > 1);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName }");
            //} // GetContactData 객채에서 반환 받은 값들 중, Addresses 속성의 값이 1개 이상인 것들만 출력

            //var results = data.Select(x => x.FirstName);
            //foreach (var item in results)
            //{
            //    Console.WriteLine(item);
            //} // FirstName의 각 값을 출력함

            //var results = data.Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName }");
            //} // GetContactData 객채에서 반환 받은 값들 중, 상위 2개만 받아옴

            //var results = data.Skip(2).Take(2);
            //foreach (var item in results)
            //{
            //    Console.WriteLine($"{ item.FirstName } { item.LastName }");
            //} // GetContactData 객채에서 반환 받은 값들 중, 상위 2개 건너 뛰고, 2개 만 출력

            var results = data.OrderByDescending(x => x.LastName);
            foreach (var item in results)
            {
                Console.WriteLine($"{ item.FirstName } { item.LastName }");
            } //GetContactData 객채에서 반환 받은 값들 중, LastName을 내림차순으로 정렬해서 던져주고 모두 출력함
        }
    }
}
