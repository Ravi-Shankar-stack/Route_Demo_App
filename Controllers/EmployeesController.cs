using Routr_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routr_Demo_App.Controllers
{
    public class EmployeesController : Controller
    {
        
        // GET: Employees
        public ActionResult Index()
        {
            var  EmployeeList = new List<Employee>
        {
            new Employee() {EmpID = 1, EmpName = "Mauricio", EmpLocation = "Rio De Jenerio"},
            new Employee() {EmpID = 2, EmpName = "Adriana", EmpLocation = "Brasilia"},
            new Employee() {EmpID = 3, EmpName = "Eduardo", EmpLocation = "Salvadro"},
            new Employee() {EmpID = 4, EmpName = "Talha", EmpLocation = "USA"},
            new Employee() {EmpID = 5, EmpName = "Stephen", EmpLocation = "California"},
        };
            var routeParameter = RouteData.Values["EmpLocation"];
            var SelectedEmployee = new List<Employee>();

            if(routeParameter != null)
            {
                var routeParaString = routeParameter.ToString();
                foreach(var item in EmployeeList)
                {
                    if (item.EmpLocation.Equals(routeParaString))
                    {
                        SelectedEmployee.Add(item);
                    }
                }

                return View(SelectedEmployee);
            }
            
            return View(EmployeeList);
        }
    }
}