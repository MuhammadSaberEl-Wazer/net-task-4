using System.Reflection.Metadata.Ecma335;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp1
{
    internal class Employee
    {
        public int id;
        public string? name;
        public string? address;
        public string? phone;
        public int salary;


        public void SetId(int id) { 
        this.id = id;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public void SetAddress(string address)
        {
            this.address = address;
        }

        public bool SetPhone(string phoneFromUser)
        {
            if (phoneFromUser.Length == 11) {
                if (phoneFromUser.StartsWith("010") || phoneFromUser.StartsWith("011") || phoneFromUser.StartsWith("012") || phoneFromUser.StartsWith("015"))
                {
                    this.phone = phoneFromUser;
                    return true;
                }
                else
                {
                    Console.WriteLine("The string does not start with any of the specified prefixes, try again");
                    return false;
                }

            }
            else
            {
                Console.WriteLine(phoneFromUser.Length);
                Console.WriteLine("Invalid number, try again");
                return false;
            }
        }


        public bool SetSalary(string salary)
        {
            if (Convert.ToInt32(salary) >= 6000)
            {
                this.salary = Convert.ToInt32(salary);
                return true;

            }
            else
            {
                Console.WriteLine("Invalid salary, try again");
                return false;
            }
        }


        public void IncreaseSalary(string newSalary)
        {
            int newSalaryInt = Convert.ToInt32(newSalary);
            newSalaryInt = Math.Abs(newSalaryInt);
                this.salary += newSalaryInt;
                Console.WriteLine($"New Salary is {this.salary}");
        }


        public void Display ()
        {
            Console.WriteLine("------------------");
            Console.WriteLine($"Hello {this.name},\n the id of this employee is {this.id},\n salary is {this.salary},\n phone number is {this.phone},\n his address is {this.address}");
        }







    }
}
