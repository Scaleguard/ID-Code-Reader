using System;
using System.Reflection.Metadata.Ecma335;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID Code:");
            string usersID = Console.ReadLine();

            if (Validate(usersID))
            {
                Console.WriteLine("Welcome!");
                HelloUser(usersID);
            }
            else
            {
                Console.WriteLine("Wrong Format. Try again.");
            }
        }
        public static bool Validate(string idcode)
        {
            if(idcode.Length == 11)
            {
                try
                {
                    long.Parse(idcode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong Format: {e}");
                    return false;
                }
            }
            else
            {
                return false;
            }
            
            
        }

        public static void HelloUser(string idCode)
        {
            int firstNum = Int32.Parse(idCode[0].ToString());
            if(firstNum == 1 || firstNum == 3|| firstNum == 5)
            {
                Console.WriteLine("Hello, Sir!");
            } else if (firstNum == 2 || firstNum == 4 || firstNum == 6)
            {
                Console.WriteLine("Hello, Madam!");
            }
        }
    }
}
