using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using UdemyCourse_WebApiCoffeeShop.Data;

namespace UdemyCourse_WebApiCoffeeShop.Controllers
{
    
    [Route("api/[controller]")]
    public class MenusController : ControllerBase
    {

        private ExpressoDbContext _context;       
        public MenusController(ExpressoDbContext context) : base()
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetMenus()
        {
            var response = _context.Menus.Include(x => x.SubMenus);
            return Ok(response);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMenu(int id)
        {
            var menu = await _context.Menus.Include(x => x.SubMenus).FirstOrDefaultAsync(x => x.Id == id);
            if (menu == null)
            {
                return NotFound("Menu not found");
            }

            return Ok(menu);

        }
        
    }
}