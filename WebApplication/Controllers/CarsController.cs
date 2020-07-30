using System.Collections.Generic;
using System.Linq;
using DataBase;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly TestContext _context;

        public CarsController(TestContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public IEnumerable<Car> Get()
        {
            return _context.Cars.Include(c => c.Prices).ToList();
        }
    }
}