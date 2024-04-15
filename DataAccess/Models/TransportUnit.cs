using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class TransportUnit
{
    public int Id { get; set; }
    [Required]
    public decimal Weight { get; set; }
    [Required]
    public float Length { get; set; }
}
