﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Julius.Models;

 

using System.Diagnostics;

namespace Julius.Controllers{
    [Produces("application/json")]
    [Route("api/User")]
    public class HomeController : Controller{
        private readonly UserService _userService = new UserService();

        public HomeController() {
        }
 
        [Route("")]
        [HttpPost]
        public void Post(User user) {

            _userService.AddBook(user); 
        }

        [HttpGet("{id}")]
        public async Task<User> GetBook(string id) {
            return await _userService.SelectBook(id) ?? new User();
        }

        [HttpGet("all")]
        public async Task<IEnumerable<User>> GetBooks() {
            return await _userService.SelectAllBooks();
        }

        [HttpGet("redire")]
        public IActionResult Redire( ) {
              return Redirect("/Test.html"); 
        }

        //public IActionResult About(int id)
        //{
        //    if (id <= 6) {
        //        ViewData["Message"] = "your response :" + id;
        //    }
        //    else {
        //        ViewData["Message"] = "nope";
        //    }
        //    return View();
        //}

        //public IActionResult Contact()
        //{
        //    ViewData["Message"] = "Your contact page.";

        //    return View();
        //}

        //public IActionResult Test() {
        //    ViewData["Message"] = "your test is here Farshid";
        //    return View();
        //}

        //public IActionResult Anna() {
        //    ViewData["Message"] = "your test is here Farshid";
        //    return View();
        //}

        //public IActionResult Final() {
        //    ViewData["Message"] = "my final teskt";
        //    return View();
        //}
        //public IActionResult Student() {
        //    ViewData["Message"] = "My Shit";
        //    return View();
        //}

        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}