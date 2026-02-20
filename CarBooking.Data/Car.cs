using System.ComponentModel.DataAnnotations;

namespace CarBooking.Data;

public class Car
{
    public int Id { get; set; }

    public int Year { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Name is too long")]
    public string Name { get; set; }
}
