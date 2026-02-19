using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CarBooking.Web.Pages.Cars
{
    public class IndexModel : PageModel
    {
        private readonly IConfiguration _configuration;

        public IndexModel(IConfiguration configuration) 
            : base()
        {
            _configuration = configuration;
        }

        public void OnGet()
        {
            Heading = "List of cars from property";
            ConfigMessage = _configuration[nameof(ConfigMessage)];

        }

        public string Heading { get; set; }

        public string ConfigMessage { get; set; }
    }
}
