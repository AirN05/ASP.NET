using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;
using System.Web.Security;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

       public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult myHierarchy()
        {
            List<Department> depts = new List<Department>();
      
            
            for (int i = 0; i < 3; i++)
            {
                List<Employee> employees = new List<Employee>();
                
                for (int j = 0; j < 3; j++)
                {
                    Employee emp = new Employee("Александр."+j+"."+i, j+i, "444"+i+j);
                    employees.Add(emp);
                }
                Department dept = new Department("dept" + i, i, "street" + i, "8800555353" + i, employees, null);

                depts.Add(dept);
            }
            Employee emp1 = new Employee("Саша.А.А.", 5, "44467");
            List<Employee> employees1 = new List<Employee>();
            employees1.Add(emp1);
            Department dept1 = new Department("deptMain", 0, "streetMain", "8800555353", employees1, depts);
            
            return View(dept1);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult About(User modelUser)
        {
            if (ModelState.IsValid)
            {
                if (FormsAuthentication.Authenticate(modelUser.login, modelUser.password))
                {
                    FormsAuthentication.SetAuthCookie(modelUser.login, false);
                    return View(modelUser);
                }
                else
                {
                    ModelState.AddModelError("", "The user name or password provided is incorrect.");
                }
            }
            return View(modelUser);
        }
    }


   
}