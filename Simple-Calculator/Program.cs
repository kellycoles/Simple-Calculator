using System;

namespace Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string UserSelection = string.Empty;
            do
            {
                PrintMenu();
                int UserChoice = Convert.ToInt32(Console.ReadLine());
                while (UserChoice < 1 || UserChoice > 4)
                {
                    Console.WriteLine("Invalid Option. Try again");
                    PrintMenu();
                    Console.WriteLine();
                    UserChoice = Convert.ToInt32(Console.ReadLine());
                }
                Calculate(UserChoice);

                Console.WriteLine("Do you want to continue");
                UserSelection = Console.ReadLine();
                while (UserSelection.ToUpper() != "NO" &&
                       UserSelection.ToUpper() != "YES")
                {
                    Console.WriteLine();
                    Console.WriteLine("Invalid Input - Please type YES or NO");
                    Console.WriteLine("Do you want to continue");
                    UserSelection = Console.ReadLine();
                }

            } while (UserSelection.ToUpper() != "NO");
            Console.WriteLine();
            Console.WriteLine("The program will now terminate");
        }
        public static void PrintMenu()
        {
            Console.WriteLine();
            Console.WriteLine("Select your option");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiplication");
            Console.WriteLine("4. Division");
            Console.WriteLine();
        }

        public static void Calculate(int SelectedOption)
        {
            int Result = 0;
            Console.WriteLine("Enter your first number");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your second number");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();


            switch (SelectedOption)
            {
                case 1:
                    Result = FirstNumber + SecondNumber;
                    Console.WriteLine("{0} + {1} = {2}", FirstNumber, SecondNumber, Result);
                    break;
                case 2:
                    Result = FirstNumber - SecondNumber;
                    Console.WriteLine("{0} - {1} = {2}", FirstNumber, SecondNumber, Result);
                    break;
                case 3:
                    Result = FirstNumber * SecondNumber;
                    Console.WriteLine("{0} * {1} = {2}", FirstNumber, SecondNumber, Result);
                    break;
                case 4:
                    Result = FirstNumber / SecondNumber;
                    Console.WriteLine("{0} / {1} = {2}", FirstNumber, SecondNumber, Result);
                    break;
            }
        }
    }

}
