using System;
using Microsoft.AspNetCore.Identity;

namespace ConfArch.Web.Models
{
    public class ApplicationUser : IdentityUser
    {
        public DateTime CareerStarted { get; set; }

        public string FullName { get; set; }
    }
}