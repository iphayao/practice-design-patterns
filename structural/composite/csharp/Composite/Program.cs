using System;
using System.Collections.Generic;

namespace Composite
{
    public interface IEmployee
    {
        string getName();
        void setSalary(double salary);
        double getSalary();
    }

    public class Developer : IEmployee
    {
        protected double salary;
        protected string name;

        public Developer(string name, double salary) 
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }
    }

    public class Designer : IEmployee
    {
        protected string name;
        protected double salary;

        public Designer(string name, double salary)
        {
            this.name = name;
            this.salary = salary;
        }

        public string getName()
        {
            return this.name;
        }

        public void setSalary(double salary)
        {
            this.salary = salary;
        }

        public double getSalary()
        {
            return this.salary;
        }
    }

    public class Organization
    {
        protected List<IEmployee> employees = new List<IEmployee>();

        public void addEmployee(IEmployee employee)
        {
            employees.Add(employee);
        }

        public double getNetSalary()
        {
            double netSalary = 0;

            foreach (var employee in employees)
            {
                netSalary += employee.getSalary();
            }

            return netSalary;
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Developer john = new Developer("John Doe", 100);
            Designer jane = new Designer("Jane", 200);

            Organization org = new Organization();
            org.addEmployee(john);
            org.addEmployee(jane);

            Console.WriteLine(org.getNetSalary().ToString());
        }
    }
}
