using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CarBooking.Data;

namespace CarBooking.Web.Pages.Makes
{
    public class CreateModel : PageModel
    {
        private readonly CarBooking.Data.CarBookingAppDbContext _context;

        public CreateModel(CarBooking.Data.CarBookingAppDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Make Make { get; set; } = default!;

        // For more information, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Makes.Add(Make);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
