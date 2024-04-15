using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataAccess.Models;

/// <summary>
/// https://learn.microsoft.com/en-us/ef/core/saving/cascade-delete
/// </summary>
public class Route
{
    public int Id { get; set; }

    //[DeleteBehavior(DeleteBehavior.Restrict)]
    public Terminal Source { get; set; }
    //[DeleteBehavior(DeleteBehavior.Restrict)]
    public Terminal Destination  { get; set; }
}
