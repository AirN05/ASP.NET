using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Department
    {
        public string name { get; set; }
        public int count { get; set; }
        public string address { get; set; }
        public string depPhone { get; set; }
        public List<Employee> employees { get; set; }
        public List<Department> subDept { get; set; }

        public Department( string name, int count, string address, string depPhone, List<Employee> employees, List<Department> subDept)
        {
            this.name = name;
            this.count = count;
            this.address = address;
            this.depPhone = depPhone;
            this.employees = employees;
            this.subDept = subDept;

        }
    }
}