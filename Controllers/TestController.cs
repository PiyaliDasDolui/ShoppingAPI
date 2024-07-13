using Microsoft.AspNetCore.Mvc;
using TodoApi.Models;

namespace TodoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {
        private readonly TestContext _context;
        
        public TestController(TestContext context){
            _context = context;
        }
        [HttpGet]
        public List<User> Index(){
            return _context.Users.ToList<User>();
        }

        [HttpPost]
        public async Task<ActionResult<User>> Create(int id, string name)
        {
            User obj = new User();
            obj.Id = id;
            obj.Name = name;
            _context.Add(obj);
            await _context.SaveChangesAsync();
             return obj;
            //return CreatedAtAction("",obj, User);
        } 
        // [HttpPost]
        // public string TestNew(int id)
        // {
        
             
        //     return "name";
        // } 
        
    }

}