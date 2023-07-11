using System;


namespace Programmers
{
    class Program
    {
        static void Main(string[] args)
        {
            string my_string = "He11oWor1d";
            string overwrtie_string = "lloWorl";
            int s = 2;
            ////////////////////////////////////
            string answer = "";


            int l = overwrtie_string.Length;
            Console.WriteLine(my_string.Substring(s, l));

            answer = my_string.Replace(my_string.Substring(s, l),overwrtie_string);


            Console.Write(answer);

            
        }
    }
}