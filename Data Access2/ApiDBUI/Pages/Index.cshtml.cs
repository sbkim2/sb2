using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using ApiDBUI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ApiDBUI.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly IHttpClientFactory _httpClientFactory;

        public IndexModel(ILogger<IndexModel> logger, IHttpClientFactory httpClientFactory) 
        {
            _logger = logger; // 인자로 받은 IILogger<ndexModel> 을 변수로 넣어줌
            _httpClientFactory = httpClientFactory; // 인자로 받은 IHttpClientFactory httpClientFactory를 변수로 넣어줌
        }

        public async Task OnGet()
        {
            await CreateContact(); // 객체를 생성하여 각 속성을 정의함
            await GetAllContacts(); // 
        }

        private async Task CreateContact() // 비동기식 메서드
        {
            ContactModel contact = new ContactModel // ContactModel 타입의 객체를 생성해줌
            {
                FirstName = "Kim",
                LastName = "SangBeom" // 속성 정의
            };

            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "tim@iamtimcorey.com" });
            contact.EmailAddresses.Add(new EmailAddressModel { EmailAddress = "me@timothycorey.com" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1212" });
            contact.PhoneNumbers.Add(new PhoneNumberModel { PhoneNumber = "555-1234" }); // 각 속성을 정의하여 객체에 추가함
           
            var _client = _httpClientFactory.CreateClient(); // 기본 구성을 사용하여 HttpClient를 만듦
            var response = await _client.PostAsync(
                "https://localhost:44396/api/Contacts",
                new StringContent(JsonSerializer.Serialize(contact), Encoding.UTF8, "application/json"));//  contact를 인자로 하여 객체를 직렬화하여, 직렬화된 객체를 HTTP를 사용하여 클라이언트-서버간에 옮김
                                                                                                         //  StringContent 클래스의 새 인스턴스를 만듭니다.
        }

        private async Task GetAllContacts()
        {
            var _client = _httpClientFactory.CreateClient(); // 기본 구성을 사용하여 HttpClient를 만듦
            var response = await _client.GetAsync("https://localhost:44396/api/Contacts");
            List<ContactModel> contacts; // ContactModel을 담은 리스트  contacts 생성

            if (response.IsSuccessStatusCode)  // HTTP 응답이 성공했는지 여부를 나타내는 값을 가져옵니다. 성공햇다면 아래 실행
            {
                var options = new JsonSerializerOptions // JsonSerializerOptions 타입을 가지는 객체를 생성하여 변수에 넣어줌
                {
                    PropertyNameCaseInsensitive = true // 속성 이름이 대/소문자를 구분하지 않는 비교를 사용하는지 여부를 결정하는 값을 ture 로 설정
                };
                string responseText = await response.Content.ReadAsStringAsync(); // HTTP 응답 메시지의 내용을 가져와 HTTP 콘텐츠를 비동기 작업으로 문자열로 직렬화합니다.
                contacts = JsonSerializer.Deserialize<List<ContactModel>>(responseText, options); // responseText 스트림에서 객체를 <ContactModel> 로 재구성 하여 값을 던져줌
            }
            else
            {
                throw new Exception(response.ReasonPhrase); // 예외 발생시 상태코드를 보여줌
            }
        }
    }
}
