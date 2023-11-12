using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb8
{
    public enum Gender // Created a enum for male and female
    {
        Male,
        Female
    }
    internal class Employee // created a class Employee
    {        
        public int Id { get; set; }
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Salary { get; set; }       
        public Employee(int id, string name, Gender gender, int salary) 
        {
            Id = id;
            Name = name;
            Gender = gender;
            Salary = salary;
        }
    }    
}
