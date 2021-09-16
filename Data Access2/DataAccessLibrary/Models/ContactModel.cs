using MongoDB.Bson.Serialization.Attributes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary.Models
{
    public class ContactModel
    {
        [BsonId] //mongoDB에서 값을 받을 때 쓰는 선언 클래스
        [JsonProperty(PropertyName = "id")] 
        

        // Guid값을 받거나, 설정하는 자동구현  속성
        public Guid Id { get; set; } = Guid.NewGuid();

        // FistName의 자동구현 속성
        public string FirstName { get; set; }

        //LastName을 받아오는 자동구현 속성
        public string LastName { get; set; }

        // EmailAddressModel에서 값을 리스트로 받아옴
        public List<EmailAddressModel> EmailAddresses { get; set; } = new List<EmailAddressModel>();

        // PhoneNumberModel 에서 값을 리스트로 받아옴
        public List<PhoneNumberModel> PhoneNumbers { get; set; } = new List<PhoneNumberModel>();
    }
}
