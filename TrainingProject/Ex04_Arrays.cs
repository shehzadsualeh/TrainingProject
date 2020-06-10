using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject
{
    public class Ex04_Arrays
    {
        public static void ArrayDemo()
        {
            // Object[] ArrayofObjects = new object[] { 1, "3"} Storing different Data Types           
            
            string[] name = new string[3];
            name[0] = "Zeeshan"; // This is one way 
            name[1] = "Shehzad";
            name[2] = "Neaz";
            Console.WriteLine("Second Name is " + name[1]);

            string[] weekdays = new string[] { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday" };

            Console.WriteLine("2nd week day is " + weekdays[1]);

            // 2 Dimensional Array
            int[,] empid = new int[,] { { 10, 20, 30 }, { 40, 50, 60 } };

            Console.WriteLine(empid[1,1]);

            // Functions
            Console.WriteLine("Length of Weekdays " + weekdays.Length);

            foreach (var item in empid)
            {
                Console.WriteLine(item);
            }

            // Traditional
            for (int i = 0; i < weekdays.Length; i++)
            {
                Console.WriteLine("Traditional : " + weekdays[i]);
            }

            for (int i = 0; i < empid.GetLength(0); i++)
            {
                for (int j = 0; j < empid.GetLength(1); j++)

                    Console.WriteLine(empid[i, j]);
            }
        }

        public static void ListDemo() 
        {
            var numberList = new List<int> { 10, 20, 30, 40 };
            numberList.Add(50);
            numberList.Remove(10);            

            foreach (var item in numberList)
            {
                Console.WriteLine(item);
            }
        }
    }
}
