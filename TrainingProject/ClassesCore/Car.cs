using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class Car
    {
        // Members
        public string EngineType = "Diesel";
        public int NumberofGears = 5;

        // Methods

        // NO Input and Output

        public void Start()
        {
            Console.WriteLine("The car started");
        }

        public void ChangeGear(int gearNumber)
        {
            Console.WriteLine("Changing Gear t" + gearNumber);
        }

        public string ReturnCarKeys()
        {
            Console.WriteLine("Car stopped");
            return "Keys with Black Keychain";
        }

        public double GetFuelAmount(double noOfLitres)
        {
            Console.WriteLine("Calculating Cost ...");
            double totalAmount = noOfLitres * 1.28;
            return totalAmount;
        }
    }
}
