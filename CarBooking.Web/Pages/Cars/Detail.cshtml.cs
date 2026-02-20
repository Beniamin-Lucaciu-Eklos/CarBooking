using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CarBooking.Data;

namespace CarBooking.Web.Pages.Cars
{
    public class DetailModel : PageModel
    {
        private readonly CarBookingAppDbContext _context;

        public DetailModel(CarBookingAppDbContext context)
        {
            _context = context;
        }

        public Car Car { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id is null)
            {
                return NotFound();
            }

            var car = await _context.Cars.FirstOrDefaultAsync(m => m.Id == id);

            if (car is not null)
            {
                Car = car;

                return Page();
            }

            return NotFound();
        }
    }
}
