using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using UdemyCourse_WebApiCoffeeShop.Data;
using UdemyCourse_WebApiCoffeeShop.Models;

namespace UdemyCourse_WebApiCoffeeShop.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservationsController : ControllerBase
    {

        private ExpressoDbContext _context;       
        public ReservationsController(ExpressoDbContext context) : base()
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Post([FromBody] Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return StatusCode(StatusCodes.Status201Created);
        }

    }
}