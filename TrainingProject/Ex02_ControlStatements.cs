using System;

namespace TrainingProject
{
    public class Ex02_ControlStatements
    {
        public static void Demo()
        {
            //  int x = 5, y = 10;

            //Console.WriteLine("Enter 1st Number: " + x);
            //Console.ReadLine();

            //Console.WriteLine("Enter 2nd Number: " + y);
            //Console.ReadLine();

            Console.Write("Enter 1st Number: ");
            string a = Console.ReadLine();
            // Console.WriteLine("Enter 1st Number: ", a);

            Console.Write("Enter 2nd Number: ");
            string b = Console.ReadLine();

            int x = Int32.Parse(a);
            int y = Int32.Parse(b);


            //if (x < 10)
            //{
            //    Console.WriteLine("x is less than 10");
            //}


            if (x < 10 && y >= 10)
            {
                Console.WriteLine("The expression is true");
            }

            else if (x < 10 || y > 100)
            {
                Console.WriteLine("Else if loop used");
            }

            else
            {
                Console.WriteLine("nothing has been used");
            }
        }

        public static void NestedIfElseDemo()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();                     

            if (name == "Abdul")
            {
                Console.WriteLine("Assalam-0-Alaikum " + name);
            }

            else if (name == "John")
            {
                Console.WriteLine("Good Morning " + name);
            }

            else if (name == "Ram")
            {
                Console.WriteLine("Namaste " + name);
            }

            else if (name == "Balwinder")
            {
                Console.WriteLine("Sasriakaal " + name);
            }
            
            else
            {
                Console.WriteLine("Bye Bye");
            }            
        }

        public static void SwitchDemo()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            switch (name.ToLower()) 
            {
                case "abdul":
                    Console.WriteLine("Assalam-0-Alailkum " + name);
                    break;

                case "john":
                    Console.WriteLine("Good Morning " + name);
                    break;

                case "ram":
                    Console.WriteLine("Namaste " + name);
                    break;

                default:
                    Console.WriteLine("Bye Bye " + name);
                    break;
            }
        }

        public static void Assignment1()
        {
            int a, b;
            Console.Write("Enter a Number: ");
            a = Int32.Parse(Console.ReadLine());
            b = a % 2;

            if (b == 0)
            {
                Console.WriteLine("Given Number is Even");
            }
            else
            {
                Console.WriteLine("Given Number is Odd");
            }
        }

        public static void Assignment2()
        {
            string x;
            Console.Write("Enter Name of a Browser: ");
            x = Console.ReadLine();

            switch (x.ToLower())
            {
                case "chrome":
                    Console.WriteLine("Browser Name is " + x);
                    break;

                case "edge":
                    Console.WriteLine("Browser Name is " + x);
                    break;

                case "firefox":
                    Console.WriteLine("Browser Name is " + x);
                    break;

                case "safari":
                    Console.WriteLine("Browser Name is " + x);
                    break;

                default:
                    Console.WriteLine("Sorry Wrong Broswer entered");
                    break;
            }
        }
    }
} 
