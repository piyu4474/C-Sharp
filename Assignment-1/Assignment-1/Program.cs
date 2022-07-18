using System;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            // for loop
            Console.WriteLine("\n         ---------- ITERATION STATEMENT ----------\n");

            Console.WriteLine("             ********** 1.FOR LOOP **********\n");

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine("             For Loop Number: " + " " + i);
            }


            // foreach loop
            Console.WriteLine("\n             ********** 2. FOREACH LOOP **********\n");

            string[] fruitList = { "Apple", "Mango", "Orange", "Strawberry", "Banana", "Watermelon" };

            foreach (string fruit in fruitList)
            {
                Console.WriteLine("             "+fruit);
            }


            // while loop
            Console.WriteLine("\n             ********** 3.1 WHILE LOOP **********\n");

            int num = 0;

            while (num < 2 )
            {
                Console.WriteLine("             While Loop Number: " + " " + num);
                num++;
            }
            // while loop
            Console.WriteLine("\n             ********** 3.2 WHILE LOOP **********\n");

            int num1 = 1;
            while (num1 <= 10)
            {
                Console.WriteLine("             While Loop Number: "+num1);
                num1++;
            }


            // do while loop
            Console.WriteLine("\n             ********** 4. DO WHILE LOOP **********\n");

            int a = 1;
            do
            {
                Console.WriteLine("             "+a);
                a++;
            }
            while (a < 8);


            Console.WriteLine("\n         ---------- SELECTION STATEMENT ----------\n");

            // if condition
            Console.WriteLine("\n             ********** 1. IF-ELSE CONDITION **********\n");

            //int num2 = 50;
            //int num3 = 100;
            Console.WriteLine("             Enter 1st Number: " );
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("             Enter 2nd Number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if (num2 > num3)
            {
               
                Console.WriteLine("               "+num2+" is greater than "+num3);
            }
            else
            {
                Console.WriteLine("               " + num3 + " is greater than " + num2);

            }

            // else if condition
            Console.WriteLine("\n             ********** 2.2 IF-ELSE CONDITION **********\n");

            Console.WriteLine("             Enter Timing: ");
            int time1 = Convert.ToInt32(Console.ReadLine());

            if ( time1 < 12)
            {
                Console.WriteLine("             Good Morning");
            }
            else if (time1 > 12 )
            {
                Console.WriteLine("             Good Afternoon.");
            }
            else if (time1 > 18)
            {
                Console.WriteLine("             Good Evemimg.");
            }
            else
            {
                Console.WriteLine("             Good Night");
            }

            // if else condition
            Console.WriteLine("\n             ********** 2.3 IF-ELSE CONDITION **********\n");

            Console.WriteLine("             Enter 1st Number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("             Enter 2nd Number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            if
             (number1 == number2)
            {
                Console.WriteLine("             Both number are equal");
            }
            else
            {
                Console.WriteLine("             Both number are not equal ");
            }


            // short if condition
            Console.WriteLine("\n             ********** 3. SHORT IF CONDITION **********\n");

            Console.WriteLine("             Enter Timing: ");
            int time3 = Convert.ToInt32(Console.ReadLine());
            string result = (time3 < 15) ? "Good Afternoon" : "Good Evening";
            Console.WriteLine("             "+result);


            // switch statement
            Console.WriteLine("\n             ********** 4. SWITCH STATEMENT **********\n");

            Console.WriteLine("             Enter any Day, 1st letter should be capital: ");
            string days = Console.ReadLine();

            switch (days)
            {

                case "Monday":
                    Console.WriteLine("             Today is Monday");
                    break;

                case "Tuesday":
                    Console.WriteLine("             Today is Tuesday");
                    break;

                case "Wednesday":
                    Console.WriteLine("             Today is Wednesday");
                    break;

                case "Thursday":
                    Console.WriteLine("             Today is Thursday");
                    break;

                case "Friday":
                    Console.WriteLine("             Today is Friday");
                    break;

                case "Saturday":
                    Console.WriteLine("             Today is Saturday");
                    break;

                case "Sunday":
                    Console.WriteLine("             Today is Sunday");
                    break;
            }


            // switch statement 2nd example
            Console.WriteLine("\n             ********** 5. SWITCH STATEMENT **********\n");


            Console.WriteLine("             Choose Number:\n                1. Black\n                2. Red\n                3. Pink ");
            int number = Convert.ToInt32(Console.ReadLine());
            switch (number)
            {
                case 1:
                    Console.WriteLine("             I am black color");
                    break;

                case 2:
                    Console.WriteLine("             I am red color");
                    break;

                default:
                    Console.WriteLine("             I am pink color");
                    break;
            }

            Console.WriteLine("\n         ---------- JUMP STATEMENT ----------\n");

            // stop for loop 
            Console.WriteLine("\n             ********** 1. BREAK STATEMENT**********\n");

            for (int b = 0; b < 10; b++)
            {
                if (b == 3)
                {
                    break;
                }
                Console.WriteLine("             "+b);
            }
            // return statement
            Console.WriteLine("\n             ********** 2. RETURN STATEMENT **********");

            Console.WriteLine("             Hello C-Sharp");
            Display(6);

            Console.WriteLine("             Welcome to C_Sharp world");
            Display(5);

            void Display(int number)
            {
                if (number == 6)
                {
                    return;
                }
                Console.WriteLine("             "+number);
            }


        }
    }
}