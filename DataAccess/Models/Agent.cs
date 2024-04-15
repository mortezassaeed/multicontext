using Azure.Core.Pipeline;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class Agent
{
    public int Id { get; set; }
    [Required]
    public string Name_Changed { get; set; }

}