using System;

namespace BoxingUnboxing
{
    internal class MainApp
    {
        static void Main(string[] args)
        {
            int a = 123;
            object b = (object)a;
            int c = (int)b;

            Console.WriteLine(a);
            Console.WriteLine(b);   // a에 담긴 값을 박싱 해서 힙에 저장
            Console.WriteLine(c);   // b에 담긴 값을 언박싱해서 스택에 저장

            double x = 3.1414213;
            object y = x;           // x에 담긴 값을 박싱해서 힙에 저장
            double z = (double)y;   // y에 담긴 값을 언박싱 해서 스택에 저장

            Console.WriteLine(x);
            Console.WriteLine(y);
            Console.WriteLine(z);

        }
    }
}