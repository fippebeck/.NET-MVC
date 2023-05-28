using System.Collections.Generic;
using WebApp.Models;

namespace WebApp.Models
{
    public class BackofficeViewModel
    {
        public List<User> Users { get; set; }
        public List<Role> Roles { get; set; }
    }
}