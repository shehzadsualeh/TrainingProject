namespace TrainingProject.ClassesCore
{
    public class Bike
    {
        string Model;

        public Bike()
        {
            System.Console.WriteLine("Default Constructor Exposed !!!");
        }

        public Bike(string modelx)
        {
            Model = modelx;
            System.Console.WriteLine("Default Constructor Exposed !!!" + modelx);
        }

        public void Details()
        {
            System.Console.WriteLine("The bike Model is " + Model);
        }
    }
}
