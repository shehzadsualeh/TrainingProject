using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingProject.ClassesCore
{
    public class AccessModifiers
    {
        public int i1 = 10;// Visible in different Classes as well by accessing this class
        internal int i2 = 20;
        protected int i3 = 30;
        private int i4 = 40;

        public void m1() 
        {
        //i
        //m we are able to access all of themi1, i2, i3, i4 within the class
        }        
        internal void m2() 
        {        
        }
        protected void m3() 
        {        
        }
        private void m4() 
        {        
        }
    }

    public class AmSub : AccessModifiers
    {
        public void demo()
        {
            //i i1, i2, i3 able to access not private
            //m m1, m2, m3 able to access not private
        }
    }

    public class AmNotSub
    {
        AccessModifiers am = new AccessModifiers();
        
        public void demo()
        {
            // am.i1 only i1 and i2 visible
            // am.m1 only m1 and m2 visible
        }

    }
}
