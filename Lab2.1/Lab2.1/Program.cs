namespace Lab2._1
{
    class Program 
    {
        public static void Main(string[] args) 
        {
            Course course = new Course();
            Employee employee = new Employee()
            {
                Name = "Adil",
                SureName = "Jalelov",
                subject = Subject.Math,
                Salary = 400
            };
            Employee employee2 = new Employee()
            {
                Name = "Jonathan",
                SureName = "Leandore",
                subject = Subject.Physics,
                Salary = 420
            };
            Student student = new Student()
            {
                Name = "Yunis",
                SureName = "Huseynov",
                Age = 23,
                Grade = 80
            };
            Student student2 = new Student()
            {
                Name = "Jeffery",
                SureName = "Williams",
                Age = 16,
                Grade = 50
            };
            course.AddStudent(student);
            course.AddStudent(student2);
            course.AddEmployee(employee); 
            course.AddEmployee(employee2);


            foreach (Student student1 in course.students)
            {
                Console.WriteLine($"Name:{student1.Name}\nSureName:{student1.SureName}\nAge:{student1.Age}\nGrade:{student1.Grade}\nIs Warranted:{student1.IsWarranted}");
                Console.WriteLine("======================");
            }
            Console.WriteLine($"Average Grade:{course.GetAvgGrade()}\nMax Grade student:{course.GetMaxGradeStud().Grade}\nTotal salary of employees:{course.TotalSalary()}");

        }
    }
}
