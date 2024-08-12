using System;
using System.Collections;
using System.Globalization;
using static System.Console;


namespace project3_0812
{
    class MainApp
    {
        static void Main(String[] args)
        {
            #region 예제 1
            //DateTime dt = new DateTime(2024, 08, 12, 18, 27, 22);
            //WriteLine("12시간 형식: {0:yyyy-MM-dd tt hh:mm:ss (ddd)}", dt);
            //WriteLine("24시간 형식: {0:yyyy-MM-dd HH:mm:ss (dddd)}", dt);

            //CultureInfo ciKo = new CultureInfo("ko-KR");
            //WriteLine();
            //WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)",ciKo));
            //WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)",ciKo));
            //WriteLine(dt.ToString(ciKo));

            //CultureInfo ciEn = new CultureInfo("en-US");
            //WriteLine();
            //WriteLine(dt.ToString("yyyy-MM-dd tt hh:mm:ss (ddd)", ciEn));
            //WriteLine(dt.ToString("yyyy-MM-dd HH:mm:ss (dddd)", ciEn));
            //WriteLine(dt.ToString(ciEn));
            #endregion
            #region 예제 2
            //string name = "김튼튼";
            //int age = 23;
            //WriteLine($"{name,-10}, {age:D3}");

            //name = "박날씬";
            //age = 30;
            //WriteLine($"{name}, {age,-10:D3}");

            //name = "이비실";
            //age = 17;
            //WriteLine($"{name}, {(age > 20 ? "성인" : "미성년자")}");
            #endregion

            #region 다음단원 예제 1
            //int a = 111 + 222;
            //Console.WriteLine(a);
            //int b = a - 100;
            //Console.WriteLine(b);
            //int c = b * 10;
            //Console.WriteLine(c);
            //double d = c / 6.3;
            //Console.WriteLine(d);
            //Console.WriteLine($"22 / 7 = {22 / 7}({22 % 7})");
            #endregion
            #region 예제 2
            //int a = 10;
            //WriteLine(a++);
            //WriteLine(++a);
            //WriteLine(a--);
            //WriteLine(--a);
            #endregion

            #region 예제 3

            //string result = "123" + "456";
            //Console.WriteLine(result);

            //result = "Hello" + " " + "World";
            //Console.WriteLine(result);
            #endregion
            #region 예제 4

            //WriteLine("Testing && ...");
            //WriteLine($"1 > 0 && 4 < 5 : {1 > 0 && 4 < 5}");
            //WriteLine($"1 > 0 && 4 > 5 : {1 > 0 && 4 > 5}");
            //WriteLine($"1 == 0 && 4 > 5 : {1 == 0 && 4 > 5}");
            //WriteLine($"1 == 0 && 4 < 5 : {1 == 0 && 4 < 5}");
            //WriteLine("\nTesting || ... ");
            //WriteLine($"1 > 0 || 4 < 5 : {1 > 0 || 4 < 5}");
            //WriteLine($"1 > 0 || 4 > 5 : {1 > 0 || 4 > 5}");
            //WriteLine($"1 == 0 || 4 > 5 : {1 == 0 || 4 > 5}");
            //WriteLine($"1 == 0 || 4 < 5 : {1 == 0 || 4 < 5}");
            #endregion
            #region 예제 5
            string result  = ( 10 % 2) == 0 ? "짝수" : "홀수";

            Console.WriteLine(result);
            #endregion

            ArrayList a = null;
            a?.Add("야구");
            a?.Add("축구");
            WriteLine("count :"+ a?.Count);
            Console.WriteLine(a?[0]);
            Console.WriteLine(a?[1]);

            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine(a?.Count);
            WriteLine(a?[0]);
            WriteLine(a?[1]);

        }
    }
}