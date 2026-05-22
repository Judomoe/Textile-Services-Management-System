using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tagroba1
{
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public bool Gender { get; set; }
        protected Person(string name, int age, string password, bool gender)
        {
            Name = name;
            Age = age;
            Password = password;
            Gender = gender;
        }

    }
    public class Customer : Person
    {
        public static List<Customer> customerlist = new List<Customer>();
        public string Address { get; set; }
        public int Points { get; set; }

        public Customer(string name, int age, string password, bool gender, int points, string address) : base(name, age, password, gender)
        {
            Address = address;
            Points = points;
        }
        public void AddCustomer(Customer customer)
        {
            customerlist.Add(customer);
        }
        public void RemoveCustomer(Customer customer)
        {
            customerlist.Remove(customer);
        }
        public override string ToString()
        {
            return Name;
        }
    }
    public class Employee : Person
    {
        public static List<Employee> employeelist = new List<Employee>();
        public int Salary { get; set; }
        public int Holidays { get; set; }
        public Employee(string name, int age, string password, bool gender, int salary, int holidays) : base(name, age, password, gender)
        {
            Salary = salary;
            Holidays = holidays;
        }
        public void AddEmployee(Employee employee)
        {
            employeelist.Add(employee);
        }
    }
}

