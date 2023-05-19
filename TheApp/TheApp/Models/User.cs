using System;
using System.Collections.Generic;
using System.Text;

namespace TheApp.Models
{
    class User
    {
        public string Name { get; set; }
        public string Code { get; set; }

        public User (string name)
        {
            Name = name;
        }
    }
}
