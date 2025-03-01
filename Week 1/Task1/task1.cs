using System;

namespace Tasks
{
    class MainClass
    {
        public static void Main(string [] args)
        {
            int choice1, choice2, num1, num2;
            bool exit = false;

            while (!exit)
            {
                Console.WriteLine("Select which operation you would like to do:\n1 = Addition (+)\n2 = Subtraction (-)\n3 = Multiplication (*)\n4 = Division (/)");
                choice1 = Convert.ToInt32( Console.ReadLine());

                if (choice1 != 1 && choice1 != 2 && choice1 != 3 && choice1 != 4){
                    Console.WriteLine("Please choose one of the given options.");
                    continue;
                }

                Console.Write("Enter the first number: ");
                num1 = Convert.ToInt32( Console.ReadLine());
                Console.Write("Enter the second number: ");
                num2 = Convert.ToInt32( Console.ReadLine());

                Operate(choice1, num1, num2);

                check:
                Console.WriteLine("Would you like to start again? (1 = Yes, 0 = No)");
                choice2 = Convert.ToInt32( Console.ReadLine());
                if (choice2 == 1){
                    exit = false;
                    continue;
                }
                else if (choice2 == 0){
                    exit = true;
                    break;
                }
                else {
                    Console.WriteLine("Please choose 1 or 0.");
                    goto check;
                }
            }
            Console.WriteLine("Goodbye!");

            static void Operate(int choice, int num1, int num2){
                switch (choice){
                    case 1:
                        Console.WriteLine("The result = " + (num1 + num2));
                        break;
                    case 2:
                        Console.WriteLine("The result = " + (num1 - num2));
                        break;
                    case 3:
                        Console.WriteLine("The result = " + (num1 * num2));
                        break;
                    case 4:
                        check:
                        if (num2 == 0){
                            Console.WriteLine("You can't divide by zero! Input another number: ");
                            num2 = Convert.ToInt32( Console.ReadLine() );
                            goto check;
                        }
                        else{
                            Console.WriteLine("The result = " + (num1 / num2));
                        }
                        break;
                }
            }
        }
    }
}