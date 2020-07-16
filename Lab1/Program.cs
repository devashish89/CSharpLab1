using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//ctrl+F5 to run code

namespace Lab1 //point1: hierarchy is namespace-->class-->methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many records to enter?:");
            int numFolks = Convert.ToInt32(Console.ReadLine());

            byte k = 7; byte l = 7;
           


            for (int i= 0;i< numFolks; i++)
            {
                try
                {
                    Console.WriteLine("Enter Name:");
                    string name = Console.ReadLine();
                    if (name.Length == 0)
                    {
                        Console.WriteLine("Invalid Name");
                        Console.Read(); //msg is visible to user
                        return; //code after retun wont execute
                    }

                    Console.WriteLine("Enter Age");
                    
                    int age = Convert.ToInt16(Console.ReadLine());
                    if (age < 0)
                    {
                        Console.WriteLine("Invalid Age");
                        Console.Read(); //message is visible to user
                        return; //code after retun wont execute
                    }
                    // System.Console.WriteLine("Hello World!" + args[0] + args[1]);
                    Console.WriteLine("Hello!" + name + age);
                   
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Data");
                    Console.WriteLine(e.Message);
                }
            }

        }
    }
}
