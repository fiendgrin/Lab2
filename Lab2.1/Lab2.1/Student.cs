using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    internal class Student : Human
    {
        private double _grade;

        public Student()
        {
           Grade = 0;
        }

        public double Grade
        {
            get { return _grade; }
            set
            {
                if (value >= 60)
                {
                    _IsWarranted = true;
                }
                else
                {
                    _IsWarranted = false;
                }
                _grade = value;
            }
        }

        private bool _IsWarranted;
        public bool IsWarranted
        {
            get 
            { 
                return _IsWarranted; 
            }
        }

    }
}
