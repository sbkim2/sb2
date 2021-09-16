using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccessLibrary;
using DataAccessLibrary.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private MongoDBDataAccess db; // MongoDBDataAccess 타입을 가지는 속성을 정의 
        private readonly string tableName = "Contacts"; // 읽기전용 속성에 값을 넣어서 정의
        private readonly IConfiguration _config; // IConfiguration 타입을 가지는 속성을 정의

        public ContactsController(IConfiguration config) //생성자
        {
            _config = config; // 인자의 값을 받아서  _config에 넣어줌
            db = new MongoDBDataAccess("MongoContactsDB", _config.GetConnectionString("Default")); // 연결문자열을 받아와 MongoContactsDB 라는 이름을 가진 MongoDBDataAccess 타입의 db 객체를 생성
        }

        [HttpGet]
        public List<ContactModel> GetAll()
        {
            return db.LoadRecords<ContactModel>(tableName); // 인자로 받은 값의 ContactModel 을 구현하여 값을 받아옴
        }

        [HttpPost]
        public void InsertRecord(ContactModel contact) 
        {
            db.UpsertRecord(tableName, contact.Id, contact); // 입력받은 ContactModel id를 가지고 db에 넣어줌
        }
    }
}