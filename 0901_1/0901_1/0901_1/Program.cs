using System;
using System.Collections.Generic;

namespace _0901_1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            list.Add("박나나");
            list.Add("박정운");
            list.Add("이윤형");
            list.Add("조미희");
            list.Add("유영석");
            list.Add("김상범");

            foreach (string i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
