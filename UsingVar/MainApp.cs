using System;
using System.Windows.Markup;

namespace UsingVar
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            var a = 20; //var 로 선언하는 변수는 반드시 초기화 해야 한다.
            Console.WriteLine("Type: {0}, Value: {1}", a.GetType(), a);

            var b = 3.1414213;
            Console.WriteLine("Type: {0}, Value: {1}", b.GetType(), b);

            var c = "Hello World!";
            Console.WriteLine("Type: {0}, Value: {1}", c.GetType(), c);

            var d = new int[] {10,20,30}; // 배열도 var 로 선언할수 있습니다.
            Console.Write("Type: {0}, Value: ", d.GetType());
            foreach (var e in d) // 배열의 각 요소를 순회 합니다.
                Console.Write("{0}", e);
            
            Console.WriteLine();   

        }
    }
}