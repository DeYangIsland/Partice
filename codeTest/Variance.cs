using System;
using System.Collections.Generic;
using System.Linq;

namespace codeTest
{

    public class T1
    {
        public string item1;
    }


    class Variance
    {
        static void Main(string[] args)
        {
            string tets = null;
            if (tets == "0")
            {
                tets = "";
            }
            Action testAction = () => { Console.WriteLine("test Action!"); };

            testClass test1 = new testClass();

            test1.AutoSync -= testAction;

        }
        void unionFunc()
        {
            IEnumerable<T1> list_1 = new List<T1>() { new T1() { item1 = "a" } };

            List<T1> list_2 = new List<T1>() { new T1() { item1 = "b" } };

            list_1 = list_1.Union(list_2);

            Console.WriteLine("");
        }
    }

    public class testClass
    {
        public string t1;
        public event Action AutoSync;
        public Action testAction = delegate () { Console.WriteLine("test Action!"); };
        public testClass()
        {

            // covariance   协变   output
            IEnumerable<string> T_1 = new List<string> { "1", "1", "1", "1", "1", "1" };
            IEnumerable<object> T1 = T_1;  // covariance   out标注参数 只读不写   string-> object  可行



            //  不变 父子 关系不明，  传入参数  同时作为返回参数
#if (DBEUG)

            IList<string> T_2 = new List<string> { "1", "1", "1", "1", "1", "1" };
            IList<object> T2 = T_2;    // 
            IList<object> T_2_1 = new List<object>();
            IList<string> T_2_2 = T_2_1;
#endif

            List<string> Temp = new List<string> { "1", "1", "1", "1", "1", "1" };
            IEnumerator<string> T_3 = Temp.GetEnumerator();
            IEnumerator<object> T3 = Temp.GetEnumerator();

            


            //contravariance  逆变    in标注 修饰参数   input    只写不读   只作为传入参数  不能作为返回值
            Action<string> AT = (i) => Console.WriteLine(i);
            Action<string> ATObj = AT;

            Action<object> AT_1 = (i) => Console.WriteLine(i);
            Action<string> ATObj_1 = AT;


            

            AutoSync += testAction;
            testAction += delegate () { Console.WriteLine("send action"); };


            var tst = test();




            List<(string first, string middle, string last)> testLLL = new List<(string first, string middle, string last)>();





            (string first, string middle, string last) test()
            {


                return ("", "", "");
            }


        }




    }
}
