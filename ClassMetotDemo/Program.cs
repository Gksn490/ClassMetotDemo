using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.name = "Yusuf";
            customer1.sname = "Göksün";
            customer1.age = 15;
            customer1.gender = "Male";

            Customer customer2 = new Customer();
            customer2.Id = 2;
            customer2.name = "Selim";
            customer2.sname = "Zeki";
            customer2.age = 18;
            customer2.gender = "Male";

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.name = "Ayşe";
            customer3.sname = "Selin";
            customer3.age = 17;
            customer3.gender = "Female";

            CustomerManager customerManager = new CustomerManager();
            Console.WriteLine("----------------------Add()----------------------");
            customerManager.Add(customer1);
            customerManager.Add(customer2);
            customerManager.Add(customer3);
            Console.WriteLine("----------------------Delete()----------------------");
            customerManager.Delete(customer1);
            customerManager.Delete(customer2);
            customerManager.Delete(customer3);
            Console.WriteLine("----------------------List()----------------------");
            customerManager.List(customer1);
            customerManager.List(customer2);
            customerManager.List(customer3);
        }
    }
}
