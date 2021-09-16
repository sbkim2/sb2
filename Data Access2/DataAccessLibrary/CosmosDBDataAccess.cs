using Microsoft.Azure.Cosmos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLibrary
{
    public class CosmosDBDataAccess
    {
        private readonly string _endpointUrl;
        private readonly string _primaryKey;
        private readonly string _databaseName;
        private readonly string _containerName; // 읽기전용 문자열 속성 생성
        
        
        private CosmosClient _cosmosClient;
        private Database _database;
        private Container _container; // 각 속성 생성

        public CosmosDBDataAccess(string endpointUrl,
                                  string primaryKey,
                                  string databaseName,
                                  string containerName) // CosmosDBDataAccess 클래스의 생성자
        {
            _endpointUrl = endpointUrl;
            _primaryKey = primaryKey;
            _databaseName = databaseName;
            _containerName = containerName;

            _cosmosClient = new CosmosClient(_endpointUrl, _primaryKey); // (_endpointUrl, _primaryKey)을 인자로하여 CosmosClient 타입의 객체 생성
            _database = _cosmosClient.GetDatabase(_databaseName); // 데이터베이스에 대한 프록시 참조를 저장
            _container = _database.GetContainer(_containerName); // 데이터베이스의 컨테이너 참조를 저장 
        }

        public async Task<List<T>> LoadRecordsAsync<T>() // async 는 비동기식, 결과를 기다리지 않음
        {
            string sql = "select * from c"; // 셀렉트 하는 SQL문, 

            QueryDefinition queryDefinition = new QueryDefinition(sql); // 인자를 받은 QueryDefinition 타입 객체 생성 
            FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition); //  데이터베이스의 컨테이너 아래 항목에 대한 쿼리를 만듭니다

            List<T> output = new List<T>(); // 리스트형식의 제네릭 타입을 담는  객체 생성

            while (feedIterator.HasMoreResults) // 쿼리에 대한 결과가 있을 시 
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync();//  Await 호출이 완료되면 이후 코드가 수행되도록 컴파일러가 코드를 생성해 줍니다.
                                                                                      // 다음세트의 결과를 읽어옴
                foreach (var item in currentResultSet) // 해당 내용을 읽어오는 반복문
                {
                    output.Add(item); // 내용 추가
                }
            }

            return output; // 모든 결과를 반환해줌
        }

        public async Task<T> LoadRecordByIdAsync<T>(string id) // 비동기식 매서드
        {
            string sql = "select * from c where c.id = @Id";

            QueryDefinition queryDefinition = new QueryDefinition(sql).WithParameter("@Id", id); // id 인자가 결합된 sql 객체를 생성
            FeedIterator<T> feedIterator = _container.GetItemQueryIterator<T>(queryDefinition); //  데이터베이스의 컨테이너 아래 항목에 대한 쿼리를 만듭니다

            while (feedIterator.HasMoreResults) // 쿼리에 대한 결과가 있을 시 
            {
                FeedResponse<T> currentResultSet = await feedIterator.ReadNextAsync();//  Await 호출이 완료되면 이후 코드가 수행되도록 컴파일러가 코드를 생성해 줍니다.
                                                                                      // 다음세트의 결과를 읽어옴

                foreach (var item in currentResultSet) // 해당 내용을 읽어오는 반복문
                {
                    return item; // item 값을 넘겨준다.
                }
            }

            throw new Exception("Item not found"); // 예외 발생시, 해당 내용이 출력
        }

        public async Task UpsertRecordAsync<T>(T record) // 비동기 메서드
        {
            await _container.UpsertItemAsync(record); //  비동기 작업으로 만족하는 결과가 있다면 추가하고 없다면 인서트를 해줌
        }

        public async Task DeleteRecordAsync<T>(string id, string partitionKey) // 비동기 메서드
        {
            await _container.DeleteItemAsync<T>(id, new PartitionKey(partitionKey)); // 비동기 작업으로 만족하는 결과가 있다면 삭제함
        }
    }
}
