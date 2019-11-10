using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestConnDbWithEf.Models;

namespace TestConnDbWithEf.Controllers {
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase {
        // GET: api/Users
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUsers() {
            // Получает данные из БД
            using (ApplicationContext db = new ApplicationContext()) {
                var users = db.Users.ToList();
                foreach (var user in users) {
                    Console.WriteLine(user.Name);
                }
                return await db.Users.ToListAsync();
            }
        }
    }
}