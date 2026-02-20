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
    public class IndexModel : PageModel
    {
        private readonly CarBookingAppDbContext _context;

        public IndexModel(CarBookingAppDbContext context)
        {
            _context = context;
        }

        public IList<Car> Cars { get;set; } = default!;

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
