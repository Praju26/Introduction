using System;

namespace Introduction
{
    class Program
    {
        static void Main(string[] args)
        {

            bool? AreYouMajor = null;
            if (AreYouMajor == true)
            {
                Console.WriteLine("User is Major");
            }
            else if (AreYouMajor == false) 
            {
                Console.WriteLine("User is not Major");
            }
        
            else
            {
                Console.WriteLine("User is Did not answer the question");
            }
        }
    }
}
