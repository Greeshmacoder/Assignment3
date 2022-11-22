using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seventh
{
    internal class student
    {
        public int rollNumber;
        public string name;

        public student()
        {
            rollNumber = 208765;
            name = "maya";
        }
        public void Displaydetails()
        {
            Console.WriteLine($"Rollnumber is {rollNumber} \n Name is {name}");
        }
    }
      public class test
        {
            static void Main(string[] args)
            {
                student r = new student();
                r.Displaydetails();
            }
        }
    
}