using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace replacePjt
{
    class Program
    {
        static void Main(string[] args)
        {



            StringReplacementChallenge();

            Console.ReadLine();

        }

        

        private static void StringReplacementChallenge()

        {
            List<string> StringLines = File.ReadAllLines(@"C:\Temp\Mindset_for_a_good_Developer.txt").ToList();
           
            Console.Write("개발자 라고 타이핑 하시오 : ");

          

            string toReplace = Console.ReadLine();



            Console.Write("좋은개발자 라고 타이핑하시오 : ");

            string replacementText = Console.ReadLine();




            // 스트링으로 받아와 작성할 경우는 아래와 같음
            string sb = "";
            for (int i = 0; i < StringLines.Count; i++)
            {
                StringLines[i]=StringLines[i].Replace(toReplace, replacementText); // toReplace문자열을 replacementText로 교체함
                sb += StringLines[i]; // 리스트 StringLines의 문자열 내용을 sb라는 스트링에 데이타에 넣어줌
                sb += "\n"; // 받아오면서 줄바꿈을 해줌
            }
            File.WriteAllText(@"C:\Temp\Mindset_for_a_good_Developer.txt", sb); // sb 문자열 내용을 파일에 작성함

            //리스트로 받아와 작성할 경우 아래와 같음
            foreach(string t in StringLines) // List<t> 의 내용을 변경하는 for문 
            {
                t.Replace(toReplace, replacementText); //toReplace문자열을 replacementText로 교체함
            }
            File.WriteAllLines(@"C:\Temp\Mindset_for_a_good_Developer.txt", StringLines); // 리스트 StringLines의 내용을 파일에 작성함


            Console.WriteLine("업데이트완료!!!!!!!");

        }



    }
}
