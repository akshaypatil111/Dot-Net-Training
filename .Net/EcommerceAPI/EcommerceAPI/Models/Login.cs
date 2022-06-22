using System;
using System.Collections.Generic;

#nullable disable

namespace EcommerceAPI.Models
{
    public partial class Login
    {
        public int Id { get; set; }
        public byte[] UserName { get; set; }
        public byte[] Password { get; set; }
        public int? IsAdmin { get; set; }
    }
}
