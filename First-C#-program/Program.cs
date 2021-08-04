using System;

namespace My_Variables
{
    class Program
    {
        //Entry method Main...
        static void Main(string[] args)
        {
          //Declearing a varible
            double num01;
            double num02;

            Console.Write("Input a Number: ");
            num01 = Convert.ToDouble( Console.ReadLine());

            Console.Write("Input Second Number: ");
            num02 = Convert.ToDouble( Console.ReadLine());

            double result = num01 * num02;
            Console.WriteLine("the result is: "+  result);


            // Console.WriteLine("Hello World!");
            Console.ReadKey(); //wait for input from keyboard
        }
    }
}
