using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("New customer adding...\nAdded : "+customer.name+" "+customer.sname+"\n----------------------");
        }
        public void Delete(Customer customer)
        {
            Console.WriteLine("Customer deleting...\nDeleted : "+customer.name+" "+customer.sname + "\n----------------------");
        }
        public void List(Customer customer)
        {
            Console.WriteLine("Id : {0}\nName : {1}\nSurname : {2}\nAge : {3}\nGender : {4}\n---------------",customer.Id,customer.name,customer.sname,customer.age,customer.gender);
        }
    }
}
