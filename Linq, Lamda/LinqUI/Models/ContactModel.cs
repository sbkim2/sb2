using System;
using System.Collections.Generic;
using System.Text;

namespace LinqUI.Models
{
    //Id, FirstName, LastName이 자동구현 속성으로 정의된 클래스 
    public class ContactModel
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<int> Addresses { get; set; }
    }
}
