using System;
using static System.Console;

namespace StringFormatBasic
{
    class MainApp
    {
        static void Main(string[] args)
        {
            string fmt = "{0,-20}{1,-15},{2,30}";

            WriteLine(fmt, "Publisher","Athor","Title");
            WriteLine(fmt, "Marvel", "Stan Lee", "Iron Man");
            WriteLine(fmt, "Habit", "Hyejung Park", "This is C#");
            WriteLine(fmt, "Prentice Hall", "K&R", "The C Programming Language");
        }
    }
}