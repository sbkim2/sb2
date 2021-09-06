using System;
using System.Collections.Generic;
using System.Text;

namespace _0901_1
{
    public class 김상범:Ias인턴
    {
        public string name { get; set; }
        public string address { get; set; }

        public int age { get; set; }

        public string hobby { get; set; }

        public List<string> hobbys { get; set; }

        public string major { get; set; }

        public int MyProperty { get; set; }

        public bool 깃탐구의지()
        {
            return true;
        }

        public bool 닷넷및기타프로그램트위터구독()
        {
            return true;
        }

        public bool 닷넷에대한사랑열정()
        {
            return true;
        }

        public bool 닷넷프로젝트에대한파악()
        {
            return true;
        }

        public bool 당직일지_업무일지작성()
        {
            return true;
        }

        public bool 도시락잘먹기()
        {
            return true;
        }

        public bool 리눅스서버탐구의지()
        {
            return true;
        }

        public bool 모르는거에대해부끄러워하지말고오픈하고물어보기()
        {
            return true;
        }

        public bool 선후배사원에대한존중()
        {
            return true;
        }

        public bool 성실한근무태도()
        {
            return true;
        }

        public bool 신기술에대한탐구열()
        {
            return true;
        }

        public bool 신원문화에대한이해()
        {
            return true;
        }

        public bool 애사심가지기()
        {
            return true;
        }

        public bool 업무일지잘쓰기()
        {
            return true;
        }

        public bool 오래된_레가시프로그램에대힌비판적시각()
        {
            return true;
        }

        public bool 오래된_레가시프로그램에대힌존중()
        {
            return true;
        }

        public bool 윈도우서버탐구의지()
        {
            return true;
        }

        public bool 유료강좌도볼수있는의지()
        {
            return true;
        }

        public bool 지식의공유()
        {
            return true;
        }

        public bool 직장인으로써메너()
        {
            return true;
        }

        public bool 코로나조심()
        {
            return true;
        }

        public bool 쿼리탐구의지()
        {
            return true;
        }

        public bool 현업에대한희생정신()
        {
            return true;
        }

        public bool 활발한소통하기()
        {
            return true;
        }

        string Ias신원직원.성실한근무태도()
        {
            throw new NotImplementedException();
        }
    }

    public interface Ias인턴:Ias신원직원, Ias닷넷개발자, Ias정보시스템팀원
    {


    }
    public interface Ias신원직원
    {
        public string 성실한근무태도();
        public bool 신원문화에대한이해();
        public bool 도시락잘먹기();
        public bool 코로나조심();
        public bool 직장인으로써메너();

        public bool 애사심가지기();


    }

    public interface Ias정보시스템팀원
    {

        public bool 선후배사원에대한존중();
        public bool 쿼리탐구의지();
        public bool 윈도우서버탐구의지();
        public bool 리눅스서버탐구의지();
        public bool 업무일지잘쓰기();
        public bool 깃탐구의지();
        public bool 현업에대한희생정신();
        public bool 모르는거에대해부끄러워하지말고오픈하고물어보기();
        public bool 당직일지_업무일지작성();
        public bool 오래된_레가시프로그램에대힌존중();
        public bool 오래된_레가시프로그램에대힌비판적시각();
        public bool 활발한소통하기();

    }

    public interface Ias닷넷개발자
    {
        public bool 닷넷에대한사랑열정();
        public bool 닷넷프로젝트에대한파악();
        public bool 유료강좌도볼수있는의지();
        public bool 닷넷및기타프로그램트위터구독();
        public bool 지식의공유();
        public bool 신기술에대한탐구열();
    }

}