using System;
using System.Collections.Generic;

namespace _0901_1
{
    class Program
    {
        static void Main(string[] args)
        {
            personMode[] shinwon = {new personMode("박나나", "정보시스템팀", "7214"), 
                                   new personMode("박정운", "정보시스템팀", "7238"), 
                                    new personMode("이윤형", "정보시스템팀", "7252"),
                                    new personMode("조미희", "정보시스템팀", "7262"), 
                                    new personMode("유영석", "정보시스템팀", "7207"), 
                                    new personMode("김상범", "정보시스템팀", "7225")
            
            
            };

            




            for (int i = 0; i < shinwon.Length; i++)
            {
                shinwon[i].Sinfo();
                Console.WriteLine();
            }
        }
    }

    class personMode
    {
        public string Name;
        public string Dep;
        public string Num;

        public personMode(string name, string dep, string num)
        {
            this.Name = name;
            this.Dep = dep;
            this.Num = num;
        }
        public void Sinfo()
        {
            Console.WriteLine($"이름 : {Name}");
            Console.WriteLine($"부서 : {Dep}");
            Console.WriteLine($"사내번호 : {Num}");
        }

    }
    
}

