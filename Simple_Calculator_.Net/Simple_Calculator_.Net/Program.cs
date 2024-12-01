using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Calculator_.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1;
            int number2;
            String answer;
            int result;

            Console.WriteLine("Strating........Simple Calculator.........");
            Console.WriteLine("Enter First Number");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            number2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Chosse Operaion:");
            Console.WriteLine("Please Enter + for Addition \nPlease Enter - For Substraction \nPlease Enter * For Multiplication \n" +
                "Please Enter / For Division : ");

            answer = Console.ReadLine();

            if (answer == "+")
            {
                result = number1 + number2;
            }
            else if (answer == "-")
            {
                result = number1 - number2;
            }
            else if (answer == "*")
            {
                result = number1 * number2;
            }
            else
            {
                result = number1 / number2;
            }

            Console.WriteLine("The Finalyyy Result:"+result);
            Console.ReadKey();


        }
    }
}
