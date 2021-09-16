using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLibrary
{
    public class MongoDBDataAccess
    {
        private IMongoDatabase db; // IMongoDatabase 타입을 가지는 속성 db

        public MongoDBDataAccess(string dbName, string connectionString) // string dbName, string connectionString 을 받는 생성자 
        {
            var client = new MongoClient(connectionString); // MongoClient 타입의 접속 연결자를 받아오는 변수 생성
            db = client.GetDatabase(dbName); //접속 연결자에서, dbName 이름을 가지는 데이터베이스를 가져와 db에 저장
        }
        

        public void InsertRecord<T>(string table, T record) //  ( string table, T record ) 를 매개변수로 가지는 매서드, record 는 제네릭 타입
        {
            var collection = db.GetCollection<T>(table); // 입력받은 테이블의 컬렉션을 구현함,, 몽고디비 테이블을 컬렉션이라고 한다.
            collection.InsertOne(record); // 컬렉션에 record를 삽입함
        }

        public List<T> LoadRecords<T>(string table)  // 인자로 (string table)을 받아 List<T> 타입을 반환 하는 매서드
        {
            var collection = db.GetCollection<T>(table); // 입력받은 테이블의 컬렉션을 구현함,,
            return collection.Find(new BsonDocument()).ToList(); // 해당 컬렉션의 BsonDocument객체를 생성하여,리스트로 반환해줌
        }

        public T LoadRecordById<T>(string table, Guid id) // 제네릭 타입을 반환 하는 메서드
        {
            var collection = db.GetCollection<T>(table);  // 입력받은 테이블의 컬렉션을 생성하여 변수에 저장
            var filter = Builders<T>.Filter.Eq("Id", id);  // 문서 속성의 Id와, 입력받은 id가 같은 것을 찾는 필터임

            return collection.Find(filter).First(); // 테이블에서 Id가 인자로 받은 id와 같은것을 찾아 반환한다.
        }

        public void UpsertRecord<T>(string table, Guid id, T record) // 제네릭 타입을 반환하는 메서드
        {
            var collection = db.GetCollection<T>(table); //  입력받은 테이블의 컬렉션을 생성하여 변수에 저장

            var result = collection.ReplaceOne( // 컬렉션의 문서를 교체함
                new BsonDocument("_id", id), // BsonDocument 객체를 생성한다, _Id라는  이름의 속성을 가지고 있고, 입력받은 id값을 가지는
                record, 
                new UpdateOptions { IsUpsert = true }); //문서가 삽입되지 않은 경우 문서를 삽입할지 여부를 나타내는 값을 가져오거나 설정합니다.
        } ////----------------------------------모르겠음----------------------------------모르겠음----------------------------------모르겠음

        public void DeleteRecord<T>(string table, Guid id)  // 제네릭 타입을 반환하는 메서드 
        {
            var collection = db.GetCollection<T>(table); // 입력받은 테이블의 컬렉션을 생성하여 변수에 저장
            var filter = Builders<T>.Filter.Eq("Id", id); //문서 속성의 Id와, 입력받은 id가 같은 것을 찾는 필터임
            collection.DeleteOne(filter); // 테이블에서 필터가 가지는 값을 삭제한다.
        }
    }
}
