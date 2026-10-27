using System;

namespace Calculator
{
    class Calculator
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Welcome to the World of High Speed Calculations");
            int firstNum;
            int secondNum;
            int choice = 1;
            double result = 0;

            while(choice != 0)
            {   
                Console.Write("Enter the first number: ");
                firstNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter the second number: ");
                secondNum = Convert.ToInt32(Console.ReadLine());

                Console.Write("1. Addition \n2. Substraction \n3. Product \n4. Division \nEnter your Choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        result = firstNum + secondNum;
                        break;
                    case 2:
                        result = firstNum - secondNum;
                        break;
                    case 3:
                        result = firstNum * secondNum;
                        break;
                    case 4:
                        if(secondNum == 0)
                        {
                            result = 0;
                        } else
                        {
                            result = firstNum / secondNum;
                        }
                        break;
                    default:
                        Console.WriteLine("Invalid Choice! Enter a valid choice");
                        break;
                }

                Console.WriteLine(String.Format("Result: {0}", result));
            }
            
            Console.Write("Thanks for Visiting the Speedy Calculator");



        }
    }
}