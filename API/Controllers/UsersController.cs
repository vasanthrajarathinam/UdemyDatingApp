using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using API.Data;
using API.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace API.Controllers
{

    public class UsersController : BaseAPIController
    {
       
        public DataContext _context { get; }

        public UsersController(DataContext context)
        {
            _context = context;
        }
        


        [AllowAnonymous] 
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AppUser>>> GetUsers()
        {
            return await _context.Users.ToListAsync();  

        }

        //api/users/1
        [Authorize]
         [HttpGet("{id}")]
        public  async Task<ActionResult<AppUser>> GetUsers(int id)
        {
          return await _context.Users.FindAsync(id);  
          
        }
        
    }
}