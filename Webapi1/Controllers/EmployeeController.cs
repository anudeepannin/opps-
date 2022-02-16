using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webapi1.Model;

namespace Webapi1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly DataContext _db;
        public EmployeeController(DataContext db)
        {
            _db = db;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Emp>>> GetEmpDetails()
        {
            return await _db.Empp.ToListAsync();
        }



        [HttpGet("(id)")]
        public async Task<ActionResult<Emp>> Getemp(int id)
        {
            var details = await _db.Empp.FindAsync(id);



            return details;
        }



        [HttpPost]
        public async Task<ActionResult<Emp>> post(Emp ep)
        {
            _db.Empp.Add(ep);
            await _db.SaveChangesAsync();



            return ep;
        }



        [HttpPut]
        public async Task putEmp(Emp ep)
        {
            _db.Entry(ep).State = EntityState.Modified;
            await _db.SaveChangesAsync();



        }

        [HttpDelete]
        public async Task<ActionResult> deleteemp(int id)
        {
            var delete = await _db.Empp.FindAsync(id);
            _db.Empp.Remove(delete);
            await _db.SaveChangesAsync();
            return NoContent();
        }
    }
}
