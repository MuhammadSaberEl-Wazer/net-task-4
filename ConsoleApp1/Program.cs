using System.Net;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee Emp1 = new Employee();
            int id;
            string name, address, phone,salary;
            bool validPhone = false;
            bool validSalary = false;
            bool stableSalary = false;




            Console.WriteLine("Hello, please set Employee name");
            name = Console.ReadLine() ;
            Emp1.SetName(name);

            Console.WriteLine("Please set Employee id");
            id = Convert.ToInt32(Console.ReadLine());
            Emp1.SetId(id);

            Console.WriteLine("Please set Employee Address");
            address = Console.ReadLine();
            Emp1.SetAddress(address);


            do
            {
                Console.WriteLine("Please set Phone number");
                phone = Console.ReadLine();
                validPhone = Emp1.SetPhone(phone);
            }
            while (!validPhone);

            do
            {
                Console.WriteLine("Please set salary");
                salary = Console.ReadLine();
                validSalary = Emp1.SetSalary(salary);
            }
            while (!validPhone);




            do
            {
                string yesOrNoCondition;
                Console.WriteLine("Do you wanna increase salary? 'y' to continue..");
                yesOrNoCondition = Console.ReadLine();
                if(yesOrNoCondition == "y" || yesOrNoCondition == "Y")
                {
                    string increaseSalaryBy;
                    Console.WriteLine("Please enter increasing value..");
                    increaseSalaryBy = Console.ReadLine();
                    Emp1.IncreaseSalary(increaseSalaryBy);
                } else
                {
                    stableSalary = true;
                }
               
            }
            while (!stableSalary);



            Emp1.Display();






        }
    }
}
