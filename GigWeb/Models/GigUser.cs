using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace GigWeb.Models
{
    public class GigUser : IdentityUser<int>
    {
        [Key]
        public int UserId{ get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
    }
}