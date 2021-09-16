using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{

    class Program
    {
        static void Main(string[] args)
        {
            string serverIP = ConfigurationManager.AppSettings["ServerIPAddress"]; // App.config 파일에서 AppSettings 섹션의 ServerIPAddress의 value를 받아옴
            string defaultConnection = ConfigurationManager.ConnectionStrings["Default"].ConnectionString; // app.config Default 값을 읽어 ConnectionStringSettingsCollection 클래스로
                                                                                                            // 반환후 이를 string 으로 변환한다.

            Console.WriteLine(serverIP); 
            Console.WriteLine(defaultConnection);
            Console.WriteLine();

            var appSettings = ConfigurationManager.AppSettings; //  NameValueCollection 객체로 생성
                                                                // 이는 key와 value를 모두 string으로 받아 보관하는 Collection이다
                                                                // app.config 파일의 <appSettings>의 값을 해당 컬렉션으로 받아 변수에 저장

            foreach (var key in appSettings.AllKeys)  // appSetting 의 키를 받아와 foreach 문 실행
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }"); //  appSettings의 각 key 값과 value 값을 출력한다. 
            }
            Console.WriteLine();

            var connectionStrings = ConfigurationManager.ConnectionStrings;  // app.config 의 <connectionStrings> 를 가져온다

            foreach (ConnectionStringSettings cnn in connectionStrings) //  app.config의 <connectionStrings> 를 규격으로 하는
                                                                        //  ConnectionStringSettings 클래스로  하여 connectionStrings를 출력하는
                                                                        // foreach 문
            {
                Console.WriteLine($"Name: { cnn.Name } Value: { cnn.ConnectionString }"); // <connectionStrings> 의 각 name 과
                                                                                          // ConnectionString 가져오는 메서드를 실행
                                                                                          // 를 출력
            }
            Console.WriteLine();

            var appConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None); // 설정파일을 파일을 Configuration 개체로 열어 변수에 저장한다.
            var appSettingsSection = appConfig.AppSettings.Settings; // 설정 파일의 AppSettings섹션의 키/값 컬렉션을 가져와서 변수에 저장

            string newKey = "Intern";
            string newValue = "Kim Sang Bum";

            if (appSettingsSection[newKey] == null) // 만약 가져온 변수의 appSettingsSection[Intern] 값 value가 없다면
            {
                appSettingsSection.Add(newKey, newValue); // appSettingsSection[Intern] value 에 Kim Sang Bum를 넣어준다.
            }
            else
            {
                appSettingsSection[newKey].Value = newValue; // 아니라면 null이 아니라면 value 값을 변경한다.
            }

            appConfig.Save(ConfigurationSaveMode.Full); // 수정된 속성만 설정 파일에 기록되도록 합니다
            ConfigurationManager.RefreshSection(appConfig.AppSettings.SectionInformation.Name); // AppSettings 섹션의 이름을 가져옴

            appSettings = ConfigurationManager.AppSettings; // app.config 파일의 <appSettings>의 값을 받아 변수에 저장

            foreach (var key in appSettings.AllKeys) // // appSetting 의 키를 받아와 foreach 문 실행
            {
                Console.WriteLine($"Key: { key } Value: { appSettings[key] }"); //appSettings의 각 key 값과 value 값을 출력한다
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }

}
