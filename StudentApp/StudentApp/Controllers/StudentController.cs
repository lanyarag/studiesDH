using Microsoft.AspNetCore.Mvc;
using StudentApp.Models;

namespace StudentApp.Controllers
{
    public class StudentController : Controller
    {
        public List<Student> list = new List<Student>();
        public IActionResult Index()
        {
            list.Add(new Student() {Id = 1, Name = "Willian", LastName="Sant Anna", Status= "Disapproved"}); 
            list.Add(new Student() {Id = 1, Name = "Thiago", LastName="Machado", Status= "Approved"});
            list.Add(new Student() {Id = 1, Name = "Caroline", LastName="Da Silva", Status= "Recuperation"});
            ViewBag.Student = list;
            return View();
        }
        [HttpPost]
        public IActionResult AddStudent()
        {
            list.Add(new Student());
            return RedirectToAction("Index");
        }
    }
}
