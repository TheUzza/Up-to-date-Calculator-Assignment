internal class Program
{
    private static void Main(string[] args)
    {
        bool calculator = true;
        {
            int num1 = 0; int num2 = 0;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            //the welcome screen
            //menu screen
            Console.WriteLine("|*************************************************************|");
            Console.WriteLine("|                      *The Calculator*                       |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("| 1~ Addition                                                 |");
            Console.WriteLine("| 2~ Substraction                                             |");
            Console.WriteLine("| 3~ Multiplication                                           |");
            Console.WriteLine("| 4~ Division                                                 |");
            Console.WriteLine("| 5~ Count-down your number                                   |");
            Console.WriteLine("| 6~ Count-up your number                                     |");
            Console.WriteLine("| 7~ Number 1 to the power of 2                               |");
            Console.WriteLine("| 8~ Number 2 to the power of 2                               |");
            Console.WriteLine("| 9~ The Exit Gate.                                           |");
            Console.WriteLine("|                                                             |");
            Console.WriteLine("|*************************************************************|");
            int selection = int.Parse(Console.ReadLine() ?? "0");
            Console.Clear();
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //the first number then clears the screen
            Console.WriteLine("Type another number, and then press Enter");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            //screen switches to one of those outcomes depending on your input 
            switch (selection)
            {
                case 1:
                    //addition
                    Console.WriteLine(num1 + num2);
                    break;
                case 2:
                    //substraction
                    Console.WriteLine(num1 - num2);
                    break;
                case 3:
                    //multipication
                    Console.WriteLine(num1 * num2);
                    break;
                case 4:
                    //division
                    Console.WriteLine(num1 / num2);
                    break;
                case 5:
                    //counts down starting from 5 to 1
                    for (int i = 5; i > 0; i--)

                        Console.WriteLine("Counting down: " + i);
                    break;
                case 6:
                    //counts up starting from 1 to 5
                    for (int i = 1; i < 6; i++)
                        Console.WriteLine("Counting up: " + i);
                    break;
                case 7:
                    //the power of the first number
                    Console.WriteLine(num1 * num1);
                    break;
                case 8:
                    //power of the second number
                    Console.WriteLine(num2 * num2);
                    break;
                case 9:
                    calculator = false;
                    Console.WriteLine("Thank you and see you again!");
                    break;  
            }

            Console.WriteLine("Choose Again");
            Console.ReadKey(true);
            Console.Clear();
        }
        //goodbye screen
        Console.Write("~~~Thank you for using my calculator~~~");
        Console.ReadKey();
    }
}
