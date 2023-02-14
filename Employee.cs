using System;

namespace assignment1
{
    public class Employee
    {
        static int nextEmployeeNumber = 1001;
        public int employeeId;
        public string employeeName;
        public DateTime dateOfBirth;
        public bool gender;
        public short numberOfDependents;
        public string[] dependents;


        static Employee()
        {
            nextEmployeeNumber = 1001;
        }

        public Employee()
        {
            employeeId = nextEmployeeNumber++;
            dependents = new string[3];
        }

        public Employee(string employeeName, DateTime dateOfBirth, bool gender) : this()
        {
            this.employeeName = employeeName;
            this.dateOfBirth = dateOfBirth;
            this.gender = gender;
        }

        public Employee(string employeeName, DateTime dateOfBirth, bool gender, short numberOfDependents) : this(employeeName, dateOfBirth, gender)
        {
            if (numberOfDependents < 0)
            {
                this.numberOfDependents = 0;
            }
            else if (numberOfDependents > 3)
            {
                this.numberOfDependents = 3;
            }
            else
            {
                this.numberOfDependents = numberOfDependents;
            }
        }

        public short AddDependent(string dependentName)
        {
            if (numberOfDependents < 3)
            {
                dependents[numberOfDependents++] = dependentName;
                return numberOfDependents;
            }
            return 0;
        }

        public bool UpdateDependents(string dependentName, int dependentId)
        {
            if (dependentId > 0 && dependentId <= numberOfDependents)
            {
                dependents[dependentId - 1] = dependentName;
                return true;
            }
            return false;
        }
    }

    internal class Employee
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("Enter employee name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter date of birth (YYYY-MM-DD):");
            DateTime dateOfBirth = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Enter gender (M/F):");
            bool gender = Console.ReadLine().ToUpper() == "M";

            Console.WriteLine("Enter number of dependents (0-3):");
            short numDependents = short.Parse(Console.ReadLine());

            Employee employee = new Employee(name, dateOfBirth, gender, numDependents);

            for (int i = 0; i < numDependents; i++)
            {
                Console.WriteLine($"Enter name of dependent {i + 1}:");
                string dependentName = Console.ReadLine();
                employee.AddDependent(dependentName);
            }

            Console.WriteLine($"Employee ID: {employee.employeeId}");
            Console.WriteLine($"Employee name: {employee.employeeName}");
            Console.WriteLine($"Date of birth: {employee.dateOfBirth.ToShortDateString()}");
            Console.WriteLine($"Gender: {(employee.gender ? "Male" : "Female")}");
            Console.WriteLine($"Number of dependents: {employee.numberOfDependents}");
            for (int i = 1; i < employee.numberOfDependents; i++)
            {
                Console.WriteLine($"Dependent {i + 1}: {employee.dependents[i]}");
            }

        }
    }
}


