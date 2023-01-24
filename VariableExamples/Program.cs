using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace VariableExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Declare a string variable, put your name in it, display it
            string firstName;
            firstName = "Tony";
            Console.WriteLine(firstName);

            //2. Declare an integer variable, put your age in it, display it
            int age = 24;
            Console.WriteLine(age);

            //3. Declare a double variable, put a decimal numberin it, display it
            double pi = 3.14;
            Console.WriteLine(pi);

            // 4.Combine a text with a variable to display "Hello" followed by your name and age
            //   (e.g. Hello Tony. You are 21 years old.)
            Console.WriteLine("Hello " + firstName + ". You are " + age + " years old.");
            Console.WriteLine($"Hello {firstName}. You are {age} years old.");

            //5. Adding, subtract, multiply, and divide numbers
            int x = 8;
            int y = 2;
            int answer;

            answer = x + y;
            Console.WriteLine($"{x} + {y} = {answer}");

            answer = x - y;
            Console.WriteLine($"{x} - {y} = {answer}");

            answer = x * y;
            Console.WriteLine($"{x} * {y} = {answer}");

            answer = x / y;
            Console.WriteLine($"{x} / {y} = {answer}");

            double num1 = 8.2;
            double num2 = 2.15;
            double num3 = num1 / num2;
            Console.WriteLine($"{num1} / {num2} = {num3}");

            //6. Do the same double calculation as above but place the result in an int variable
            int numberCast = (int)(num1 / num2);
            Console.WriteLine(numberCast);

            int numberConvert = Convert.ToInt16(num1 / num2);
            Console.WriteLine(numberConvert);

            //7. Calculate employee rate based on hours worked and pay rate
            double payRate = 15.27;
            double hoursWorked = 8.2;
            double totalPay = payRate * hoursWorked;

            Console.WriteLine($"\n\nRate of Pay:  {payRate}");
            Console.WriteLine($"Hours Worked: {hoursWorked}");
            Console.WriteLine($"Total Pay:    {totalPay}");

            //8. Increment your age by 1
            age++;
            Console.WriteLine(age);

            //9. Decremene your age by 1
            age--;
            Console.WriteLine(age);
            Console.ReadKey();
        }
    }
}
