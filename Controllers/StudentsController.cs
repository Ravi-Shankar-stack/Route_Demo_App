using Routr_Demo_App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Routr_Demo_App.Controllers
{
    [RoutePrefix("Students")]
    public class StudentsController : Controller
    {
        // GET: Students
        [Route("~/")]
        [Route("StudentsDetail/{Semester?}/{Subject?}")]
        public ActionResult StudentsDetail(string Semester, string Subject)
        {
            var StudentList = new List<Student>()
            {
                new Student(){StudentName = "Ravi", StudentSemester = "8th", StudentSubject =  "Physics"},
                new Student(){StudentName = "Marcus", StudentSemester = "4th", StudentSubject =  "Electronics"},
                new Student(){StudentName = "Mauricio", StudentSemester = "3rd", StudentSubject =  "Computer"},
            };

            var SelectedStudents = new List<Student>();


            if (Subject != null)
            {
                foreach (var item in StudentList)
                {
                    if (item.StudentSubject.Equals(Subject))
                    {
                        SelectedStudents.Add(item);
                    }
                }
                return View(SelectedStudents);
            }

            if (Semester != null)
            {
                foreach (var item in StudentList)
                {
                    if (item.StudentSemester.Equals(Semester))
                    {
                        SelectedStudents.Add(item);
                    }
                }
                return View(SelectedStudents);
            }


            return View(StudentList);
        }
    }
}