using System.ComponentModel.DataAnnotations;

namespace DataAccess.Models;

public class Supplier
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string? LastName { get; set; }
    public DateTime? DateAdded { get; set; } = DateTime.Now;

}