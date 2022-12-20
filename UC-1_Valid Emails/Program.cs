using System;

namespace UC_1_Valid_Emails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pattern pat = new Pattern();
            Console.WriteLine("Enter Email Id: ");
            string email = Console.ReadLine();
            bool id = pat.Validate_Email(email);
            Console.WriteLine(id);
            if (id)
            {
                Console.WriteLine("correct match");
            }
            else
            {
                Console.WriteLine("Wrong match");
            }
        }
    }
}
