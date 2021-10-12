using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyWA.Models
{
    public class Role : IdentityRole
    {
        [Required]
        public string Name { get; set; }
    }
}
