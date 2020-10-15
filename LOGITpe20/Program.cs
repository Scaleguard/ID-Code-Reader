using System;

namespace LOGITpe20
{
    class Program
    {
        static void Main(string[] args)
        {

            DisplayLOGIT();
        }
        public static void DisplayLOGIT()
        {
            string LOGITpe20 = "LOGITpe20";
            Console.WriteLine(LOGITpe20);
            string LOGITString = LOGITpe20.Substring(0, 5);
            Console.WriteLine(LOGITString);
            string ITString = LOGITpe20.Substring(5, 2);
            Console.WriteLine(ITString);
            string string20 = LOGITpe20.Substring(7, 2);
            Console.WriteLine(string20);
        }
    }
}
