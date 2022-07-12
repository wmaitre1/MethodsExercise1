using System;

namespace MethodsExercise1
{
    internal 
        class Program

    {
         //------------------------exercise 2--------------------
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }
        public static int Multiply(int num1, int num2)
        {
            var answer = num1 * num2;
            return answer;
        }
        public static int Subtract(int num1, int num2)
        {
            var answer = num1 - num2;
            return answer;
        }

        static void Main(string[] args)
        {

            var amountOfDrinks = Sum(2, 6);
            var amountOfWatches = Multiply(2, 6);
            var amount = Subtract(6, 2);


            // ------------------------exercise 1---------------------------

            Console.WriteLine("Hello - What is your first name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}.  What is your favorite color?");
            var color = Console.ReadLine();

            Console.WriteLine($"{color} is pretty cool.  What is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"{animal} is awesome.  What is your favorite band?");
            var band = Console.ReadLine();
        
            
       


        }
    }
}
