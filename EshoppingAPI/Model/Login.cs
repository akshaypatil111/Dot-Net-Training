using System;
using System.Collections.Generic;

#nullable disable

namespace EshoppingAPI.Model
{
    public partial class Login
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? IsAdmin { get; set; }
    }
}
