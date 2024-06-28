using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace OnlineHotel.Models
{
    public class ApplicationUser:IdentityUser
    {
        [Required]

        public string Name { get; set; } 
        public string? City {  get; set; }
        public string? PostCode { get; set; }
        public string? Country { get; set; }
    }
}
