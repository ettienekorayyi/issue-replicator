using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Infrastructure;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EmployeeController : ControllerBase
    {
        public EmployeeController(EmployeeDbContext context)
        {
            _context = context;
        }

        [HttpGet(Name = "Employees")]
        public IEnumerable<Employee> Get()
        {
            return _context.Employee.ToList();
        }

        public EmployeeDbContext _context { get; private set; }
    }
}