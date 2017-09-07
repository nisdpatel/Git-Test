using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello World");
            //System.Console.Read();

            //System.Console.WriteLine("Hello World!");
            //System.Console.Read();

            int input1 = 0;
            int try_counter = 1;
            bool number_is_correct = false;
            Random r = new Random();
            int low = 1;
            int high = 100;
            int random_num = r.Next(low, high);



            Console.WriteLine("Enter a number between 1 and 100.");

            while (!number_is_correct)
            {
                Console.Write("What number are you guessing :");
                string input2 = Console.ReadLine();

                if (!Int32.TryParse(input2, out input1)) //convert string to an int
                {
                    Console.WriteLine("\nDummy, enter a vaild number");

                }
                else if (input1 > random_num)
                {
                    Console.WriteLine("\nToo high, pick something lower...");
                    try_counter++;
                }
                else if (input1 < random_num)
                {
                    Console.WriteLine("\nToo low, pick something higher..");
                    try_counter++;
                }

                else
                {
                    number_is_correct = true;
                    Console.WriteLine("\nYou guessed right, the number is {0}", random_num);
                    System.Console.WriteLine("\nIt took you {0} tries!!!!!!!", try_counter);
                    System.Console.ReadLine();
                }
            }
        }





    }
    }
}
