using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Employee
    {
        public string FIO { get; set; }
        public int age { get; set; }
        public string phone { get; set; }

        public Employee(string FIO, int age, string phone)
        {
            this.FIO = FIO;
            this.age = age;
            this.phone = phone;
        }
    }


}