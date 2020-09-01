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
            // pass object to default view
            return View(_context);
        }
        // get method to one item in db
        public IActionResult ViewOne(int id)
        {
            // return object from student bd set of StudentsDbContext with the ID matching the ID param
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            // if first or default returns a student object
            if(matchingStudent != null)
            {
                // pass student object to default view
                return View(matchingStudent);
            } else 
            // otherwise
            {
                // pass view data to specificed view
                ViewData["studentID"] = id;
                return View("NotFound");
            }
        }
        // post method to create new db item
        [HttpPost]
        public IActionResult AddStudent(string name, int classworkAvg)
        {
            // create new student object from params
            StudentModel newStudent = new StudentModel(){name = name, classworkAvg = classworkAvg};
            // add new student to StudentDbContext DbSet
            _context.Add(newStudent);
            // save changes to database (add record)
            _context.SaveChanges();
            // pass db context to specificed view
            return View("ViewAll", _context);
        }
        // put method to update value of exiting db item
        [HttpPut]
        public IActionResult UpdateClassworkAvg(int id, int classworkAvg)
        {
            // return object from student bd set of StudentsDbContext with the ID matching the ID param
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            // if first or default returns a student object
            if(matchingStudent != null)
            {
                // update classwork average property to param
                matchingStudent.classworkAvg = classworkAvg;
                // save change to data base (update record)
                _context.SaveChanges();
                // pass db context to specificed view
                return View("ViewAll", _context);
            } else 
            // otherwise
            {
                // pass view data to specificed view
                ViewData["studentID"] = id;
                return View("NotFound");
            }
        }
        // delete method to delete db item
        [HttpDelete]
        public IActionResult DeleteStudent(int id)
        {
            // return object from student bd set of StudentsDbContext with the ID matching the ID param
            StudentModel matchingStudent = _context.students.FirstOrDefault(Student => Student.id == id);
            // if first or default returns a student object
            if(matchingStudent != null)
            {
                // remove student object from database
                _context.Remove(matchingStudent);
                // save changes to database (remove record)
                _context.SaveChanges();
                // pass db context to specificed view
                return View("ViewAll", _context);
            } else 
            // otherwise
            {
                // pass view data to specificed view
                ViewData["StudentID"] = id;
                return View("NotFound");
            }
        }
    }
}