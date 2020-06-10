using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class DataEncapsulation
    {
        private string Name;
        public string Email {get; set;}
        
        public string getName()
        {
            return Name;
        }

        public void setName(string nam)
        {
            Name = nam;
        }
        public string Name1
        {
            get { return Name1; }
            set { Name = value; }
        }        
    }
}
