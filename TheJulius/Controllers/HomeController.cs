using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Julius.Models;
using System.Diagnostics;
using MongoDB.Driver;
using TheJulius.Model;

namespace Julius.Controllers{
    [Produces("application/json")]
    [Route("User")]
    public class HomeController : Controller{
        private readonly UserService _userService = new UserService();

        public HomeController() {
        }
 
        [Route("")]
        [HttpPost]
        public void PostUser([FromBody] User user) {
            _userService.AddUser(user); 
        }

        [HttpPost("patient")]        
        public void PostPatient([FromBody] User user) {
            _userService.AddPatient(user);
        }

        [HttpGet("{id}/select")]
        public async Task<User> Get([FromBody]string id) {
            return await _userService.SelectUser(id); // ?? new User();
        }

        [HttpPut("{id}/put")]
        public async Task Put([FromBody]string id, UserEnum role) {
                await _userService.UpdateUser(id, role);
        }

        [HttpDelete("{id}/delete")]
        public async Task Delete([FromBody]string id) {
            await _userService.DeleteUser(id);
        }

        [HttpGet("all")]
        public async Task<IEnumerable<User>> GetAll() {
            return await _userService.SelectAllUsers();
        }

        //[HttpGet("login/{email}/{wachtwoord}}")]
        //public async Task ([FromBody]string email, UserEnum wachtwoord) {
        //    return await _userService.SelectAllUsers();
        //}
    }
}

        //[HttpGet("redire")]
        //public IActionResult Redire( ) {
        //      return Redirect("/Test.html"); 
        //}

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

        //public IActionResult Test() {
        //    ViewData["Message"] = "your test is here Farshid";
        //    return View();
 
 
