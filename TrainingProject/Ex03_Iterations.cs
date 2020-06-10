using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class Ex03_Iterations
    {
        public static void WhileDemo()
        {
            int i = 1;
            
            while(i <= 5)
            {
                Console.WriteLine("The value of i:" + i);
                //break;
                i++;
            }
        }

        public static void DoWhileDemo()
        {
            int i = 1;

            do
            {
                Console.WriteLine("The value of i:" + i);
                //break;
                i++;
            } while (i <= 5);
        }

        public static void ForDemo()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("The value of i:" + i);
            }
        }

        public static void Assignment1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void Assignment2()
        {
            int a = 5;
            int b, c;
            for (b = 1; b <= 10; b++)
            { 
                c = a * b;
                Console.WriteLine("5 x " + b + " = " + c);
            }            
        }

        public static void Assignment3()
        {
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }            
        }

        public static void Assignment4()
        {
            int i = 10;
            for (i = 10; i >= 1; i--)
            {
                Console.WriteLine(i);
            }
        }

        public static void Assignment5()
        {
            int i = 1;
            for (i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);

                if (i == 7)
                {
                    break;
                }
            }
        }
    }
}
