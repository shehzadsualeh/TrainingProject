using System;

namespace TrainingProject.ClassesCore
{
    class B : A
    {
        string fname = "Shehzad";

        public void Hobbies()
        {
            Console.WriteLine("Playing Football.");
        }

        public void demoThisAndBase()
        {
            this.Hobbies();
            base.Hobbies();
        }
    }
}
