using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2._1
{
    internal class Course
    {
        public Student[] students = new Student[0];
        public Employee[] employees = new Employee[0];


        public Student[] AddStudent(Student student)
        {
            Array.Resize(ref students, students.Length + 1);
            students[students.Length - 1] = student;
            return students;
        }

        public Employee[] AddEmployee(Employee employee )
        {
            Array.Resize(ref employees, employees.Length + 1);
            employees[employees.Length - 1] = employee;
            return employees;
        }

        public double GetAvgGrade() 
        {
            double sum = 0;
            if (students.Length == 0) 
            {
                Console.WriteLine("No students added");
                return 0;
            }
            foreach (Student item in students)
            {
                sum += item.Grade;
            }

            return sum/students.Length;
        }
        public Student GetMaxGradeStud() 
        {
            double[] Grades = new double[students.Length];

            for (int i = 0; i < students.Length; i++)
            {
                Grades[i] = students[i].Grade;
            }

            int index = Array.IndexOf(Grades, Grades.Max());
            return students[index];
        }
        public double TotalSalary() 
        {
            double Total = 0;
            foreach (Employee item in employees)
            {
                Total += item.Salary;
            }
            return Total;
        }


    }

    
}
