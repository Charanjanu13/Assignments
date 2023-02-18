using System;

namespace InheritanceAssig
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public double Phone { get; set; }

        public Person(int id, string name, string address, double phone)
        {
            this.Id = id;
            this.Name = name;
            this.Address = address;
            this.Phone = phone;
        }

        public  void Details()
        {
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Name: " + Name);
            Console.WriteLine("Address: " + Address);
            Console.WriteLine("Phone Number: " + Phone);
        }
    }

    public class Student : Person
    {
        public string Class { get; set; }
        public int Marks { get; set; }
        public string Grade { get; set; }
        public double Fees { get; set; }

        public Student(int id, string name, string address, double phone, string _class, int marks, string grade, double fees) : base(id, name, address, phone)
        {
            this.Class = _class;
            this.Marks = marks;
            this.Grade = grade;
            this.Fees = fees;
        }

        public  void Details()
        {
            base.Details();
            Console.WriteLine("Class: " + Class);
            Console.WriteLine("Marks: " + Marks);
            Console.WriteLine("Grade: " + Grade);
            Console.WriteLine("Fees: " + Fees);
        }
    }

    public class Staff : Person
    {
        public string Designation { get; set; }
        public double Salary { get; set; }

        public Staff(int id, string name, string address, double phone, string designation, double salary) : base(id, name, address, phone)
        {
            this.Designation = designation;
            this.Salary = salary;
        }

        public  void Details()
        {
            base.Details();
            Console.WriteLine("Designation: " + Designation);
            Console.WriteLine("Salary: " + Salary);
        }
    }

    public class TeachingStaff : Staff
    {
        public string Qualification { get; set; }
        public string Subject { get; set; }

        public TeachingStaff(int id, string name, string address, double phone, string designation, double salary, string qualification, string subject) : base(id, name, address, phone, designation, salary)
        {
            this.Qualification = qualification;
            this.Subject = subject;
        }

        public  void Details()
        {
            base.Details();
            Console.WriteLine("Qualification: " + Qualification);
            Console.WriteLine("Subject: " + Subject);
        }
    }

    public class NonTeachingStaff : Staff
    {
        public string DeptName { get; set; }
        public int ManagerId { get; set; }

        public NonTeachingStaff(int id, string name, string address, double phone, string designation, double salary, string deptname, int managerid) : base(id, name, address, phone, designation, salary)
        {
            this.DeptName = deptname;
            this.ManagerId = managerid;
        }

        public  void Details()
        {
            base.Details();
            Console.WriteLine("Department Name: " + DeptName);
            Console.WriteLine("Manager Id: " + ManagerId);
        }
    }
    class Inheritance
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter details for a student:");
            Console.Write("Id: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Address: ");
            string address = Console.ReadLine();
            Console.Write("Phone: ");
            double phone = double.Parse(Console.ReadLine());
            Console.Write("Class: ");
            string _class = Console.ReadLine();
            Console.Write("Marks: ");
            int marks = Convert.ToInt32(Console.ReadLine());
            Console.Write("Grade: ");
            string grade = Console.ReadLine();
            Console.Write("Fees: ");
            double fees = double.Parse(Console.ReadLine());

            Student student = new Student(id, name, address, phone, _class, marks, grade, fees);
            Console.WriteLine("Details for student:");
            student.Details();

            Console.WriteLine("Enter details for a teaching staff member:");
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Phone: ");
            phone = double.Parse(Console.ReadLine());
            Console.Write("Designation: ");
            string designation = Console.ReadLine();
            Console.Write("Salary: ");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Qualification: ");
            string qualification = Console.ReadLine();
            Console.Write("Subject: ");
            string subject = Console.ReadLine();

            TeachingStaff teachingStaff = new TeachingStaff(id, name, address, phone, designation, salary, qualification, subject);
            Console.WriteLine("Details for teaching staff member:");
            teachingStaff.Details();

            Console.WriteLine("Enter details for a non-teaching staff member:");
            Console.Write("Id: ");
            id = int.Parse(Console.ReadLine());
            Console.Write("Name: ");
            name = Console.ReadLine();
            Console.Write("Address: ");
            address = Console.ReadLine();
            Console.Write("Phone: ");
            phone = double.Parse(Console.ReadLine());
            Console.Write("Designation: ");
            designation = Console.ReadLine();
            Console.Write("Salary: ");
            salary = double.Parse(Console.ReadLine());
            Console.Write("Department name: ");
            string deptname = Console.ReadLine();
            Console.Write("Manager Id: ");
            int managerid = int.Parse(Console.ReadLine());

            NonTeachingStaff nonTeachingStaff = new NonTeachingStaff(id, name, address, phone, designation, salary, deptname, managerid);
            Console.WriteLine("Details for non-teaching staff member:");
            nonTeachingStaff.Details();
        }
    }
}
