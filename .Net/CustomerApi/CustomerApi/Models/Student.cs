using System;
using System.Collections.Generic;

#nullable disable

namespace CustomerApi.Models
{
    public partial class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public int? RollNo { get; set; }
    }
}
