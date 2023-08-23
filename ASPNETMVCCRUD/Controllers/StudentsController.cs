using ASPNETMVCCRUD.Data;
//using ASPNETMVCCRUD.Data.Domain;
using ASPNETMVCCRUD.Models;
using ASPNETMVCCRUD.Models.Domain;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace ASPNETMVCCRUD.Controllers
{
    
    public class StudentsController : Controller
    {
        private readonly MVCDemoDbContext DemoDbContext;

        public StudentsController(MVCDemoDbContext DemoDbContext)
        {
            this.DemoDbContext = DemoDbContext;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await DemoDbContext.Students.ToListAsync();
            return View(students);
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(Add addStudentRequest)
        {
            var student = new Student()
            {
               
                S_Name = addStudentRequest.S_Name,
                S_Email = addStudentRequest.S_Email,
                S_Department = addStudentRequest.S_Department,
                S_DateOfBirth = addStudentRequest.S_DateOfBirth


            };
             await DemoDbContext.Students.AddAsync(student);
            await DemoDbContext.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}
