using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class Terminal
{
    public int Id { get; set; }
    public string Name { get; set; }
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public Country Country { get; set; }
}

public class Country
{
    public int Id { get; set; }
    public string Name { get; set; }
}