using System;
using System.Collections.Generic;
using System.Text;

namespace HW3
{
    public class Model
    {
        public string Name { get; set; }
        public string Address { get; set; }
        public bool IsMale { get; set; }
        public DateTime BirthDate { get; set; }
        public string Email { get; internal set; }
        public string PhoneNumber { get; internal set; }
    }
}
