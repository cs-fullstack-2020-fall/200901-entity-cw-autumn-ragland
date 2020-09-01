using Microsoft.AspNetCore.Mvc;
using Classwork.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using Classwork.Models;

namespace Practice.Controllers
{
    public class Students : Controller
    {
        // ref to db context
        private readonly StudentDbContext _context;
        public Students(StudentDbContext context)
        {
            _context = context;
        }
        // sanity landing page
        public IActionResult Index()
        {
            return Content("Student Controller");
        }
        // get method to view all items in db
        public IActionResult ViewAll()
        {
            return View(_context);
        }
        // get method to one item in db
        public IActionResult ViewOne(int id)
        {
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            if(matchingStudent != null)
            {
                return View(matchingStudent);
            } else {
                ViewData["studentID"] = id;
                return View("NotFound");
            }
        }
        // post method to create new db item
        [HttpPost]
        public IActionResult AddStudent(string name, int classworkAvg)
        {
            StudentModel newStudent = new StudentModel(){name = name, classworkAvg = classworkAvg};
            _context.Add(newStudent);
            _context.SaveChanges();
            return View("ViewAll", _context);
        }
        // put method to update value of exiting db item
        [HttpPut]
        public IActionResult UpdateClassworkAvg(int id, int classworkAvg)
        {
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            if(matchingStudent != null)
            {
                matchingStudent.classworkAvg = classworkAvg;
                _context.SaveChanges();
                return View("ViewAll", _context);
            } else {
                ViewData["studentID"] = id;
                return View("NotFound");
            }
        }
        // delete method to delete db item
        [HttpDelete]
        public IActionResult DeleteStudent(int id, int hoursPlayed)
        {
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            if(matchingStudent != null)
            {
                _context.Remove(matchingStudent);
                _context.SaveChanges();
                return View("ViewAll", _context);
            } else {
                ViewData["StudentID"] = id;
                return View("NotFound");
            }
        }
    }
}