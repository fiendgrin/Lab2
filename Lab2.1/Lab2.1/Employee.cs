using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    internal class Employee : Human
    {
        
        private double  _Salary;

        public double Salary
        {
            get { return _Salary; }
            set 
            {
                _Salary = check(value);
            }
        }

        public Subject subject;

        private double check(double value) 
        {
            double salary;
        less:
            if (value >= 300)
            {
                salary = value;
            }
            else
            {
                Console.WriteLine("Salary cant be less than 300");
                value = int.Parse(Console.ReadLine());
                goto less;
            }
            return salary;
        }
        
    }
}
