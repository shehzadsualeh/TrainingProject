using Com.Casio;
using Com.Sharp;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrainingProject.ClassesCore;

namespace TrainingProject
{
    public class Program
    {
        public static readonly Double pivalue = 3.14;


        static void Main(string[] args)
        {
            // Ex01_DataTypes.Demo();
            // Ex02_ControlStatements.Demo();
            // Ex02_ControlStatements.NestedIfElseDemo();
            // Ex02_ControlStatements.SwitchDemo();
            // Ex02_ControlStatements.Assignment1();
            // Ex02_ControlStatements.Assignment2();
            // Ex03_Iterations.DoWhileDemo();
            // Ex03_Iterations.ForDemo();
            // Ex03_Iterations.WhileDemo();
            // Ex03_Iterations.Assignment5();
            // Ex04_Arrays.ArrayDemo();
            // Ex04_Arrays.ListDemo();

            // Ex05 Cars Classes and Methods

            //Car myCar = new Car(); // Instatiation of Car Object
            //Car BMW = new Car();
            //Console.WriteLine("Engine Type is : " + myCar.EngineType);

            //myCar.Start();

            //myCar.ChangeGear(2);

            //string abc = myCar.ReturnCarKeys();
            //Console.WriteLine(abc);

            //double cost = myCar.GetFuelAmount(41.5);
            //Console.WriteLine("£"+cost);

            // Ex 06 Constructors

            //Bike honda = new Bike();
            //Bike suzuki = new Bike("RX-100");
            //suzuki.Details();

            //Ex 07 Home Work Method Overloading 
            // Addition addition = new Addition();

            // Ex08 Inheritance
            //A a = new A();
            //Console.WriteLine("A's firstname " + a.fname);
            //a.Hobbies();

            //B b = new B();
            //Console.WriteLine("B's Surname " + b.fname);
            //b.Hobbies();
            //b.demoThisAndBase();

            // Ex09 namespace and using keyword

            // Com.Casio.Calc c = new Com.Casio.Calc(); // Fully Qualified Name
            // c.Add();

            // Com.Sharp.Calc d = new Com.Sharp.Calc();
            // d.Add();

            // Ex10 Static
            // StaticDemo sdemo = new StaticDemo(); This is not needed for accessing static members and methods
            // StaticDemo.SMethod();
            // Console.WriteLine(StaticDemo.i);


            // pivalue = 9.99; // cannot change value as its readonly

            // Console.WriteLine("The value of Pi is " + pivalue);

            // Ex11 

            // Shape shape = new Shape(); // Abstract Classes cannot be initiated

            // Triangle triangle = new Triangle();
            // triangle.area(10, 20);

            // Rectangle rectangle = new Rectangle();
            // rectangle.area(5, 5);

            // Interface impelementaion

            //Parrot parrot = new Parrot();
            //parrot.Eat();
            //parrot.Fly();

            // Exceptions 

            //  ExceptionDemo.EDemo();

            // Console.WriteLine(weekdays[0]);

            // int x = 0;
            // int y = 53;

            // Console.WriteLine(y/x);



            // Data Encapsulation

            // DataEncapsulation de = new DataEncapsulation();
            // de.Email = "a@b.com";
            // Console.WriteLine(de.Email);

            // Dictionary Demo

            // DictionaryDemo.Demo();

            // String Manipulation

            //string s1 = "My name is Shehzad";
            //Console.WriteLine(s1.Length);
            //int l1 = s1.Length;
            //Console.WriteLine(l1);
            //Console.WriteLine(s1.Substring(3,4));

            //var s2 = s1.Substring(3, l1-3);
            //Console.WriteLine(s2);

            //Console.WriteLine(s1.Trim());

            //string s3 = "My name is Shehzad";
            //Console.WriteLine(s1.ToLower().Equals(s3.ToLower()));

            //string s4 = ReverseString3b(s1);
            //Console.WriteLine(s4);


            // Assignment # 1(a)
            // WriteToFile.writeToFile();

            // Assignment # 1(b)
            //ReadFromFile.readFromFile();

            // Assignment # 1(c)
            // string text = "Tomorrow is Friday";
            // AppendFile.appendFile(text);

            // Assignment # 2
            // CurrentWorkingDirectory.currentWorkingDirectory();

            // Assignment # 3 
            // IfDirectoryNotExist.ifDirectoryNotExist();

            // Assignment # 4
            // Console.WriteLine(Resources.URL); 

            // Assignment # 5
            // int num =RandomNumber.randomNumber();
            // Console.WriteLine(RandomNumber.randomNumber());

            // Assignemtn # 6
            // RandomNumber.random4DigitNumber();

            // Assignemtn # 7
            // string number = RandomNumber.random10DigitNumber(10);
            //  Console.WriteLine(RandomNumber.random10DigitNumber(10));

            // Assignment # 8
            // string name = RandomName.randomName();
            // Console.WriteLine(RandomName.randomName());

            // Assignement # 9
            // Console.WriteLine(CurrentDateandTime.currentDateTime());

            // Assignment # 10
            // Console.WriteLine(CurrentDateandTime.randomDate());
            // Console.WriteLine(CurrentDateandTime.randomDate().ToString("dd/MM/yyyy")); 
        }


        //string s1 ="abdul";
        //i = =0
        //j=4

        //chars[0]=str[4] =l
        //char[4]= str[0] =a

        //i=1; j=3
        //char[1]=str[3]=u
        //char[3]=str[1]=b

        //public static string ReverseString3b(string str)
        //{

        //    char[] chars = new char[str.Length];
        //    for (int i = 0, j = str.Length - 1; i <= j; i++, j--)

        //    {
        //        chars[i] = str[j];
        //        chars[j] = str[i];
        //    }
        //    return new string(chars);
        //}    

    }

}
