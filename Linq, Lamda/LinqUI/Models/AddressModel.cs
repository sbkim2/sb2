using System;
using System.Collections.Generic;
using System.Text;

namespace LinqUI.Models
{
    // Id, ContactID, City, State 이 자동구현 속성으로 정의된 클래스 
    public class AddressModel
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public string City { get; set; }
        public string State { get; set; }
    }
}
