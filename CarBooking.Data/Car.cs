using System.ComponentModel.DataAnnotations;

namespace CarBooking.Data;

public class Car
{
    public int Id { get; set; }

    [Required]
    [Range(1990, int.MaxValue, ErrorMessage = "Year must be greater than 1990")]
    public int Year { get; set; }

    [Required]
    [StringLength(150, ErrorMessage = "Model is too long")]
    public string Model { get; set; }

    public int? MakeId { get; set; }
    public virtual Make Make { get; set; }
}
