using System;
using System.Collections.Generic;
using System.Text;

namespace TheApp.Models
{
    public class User
    {
        public string Name { get; set; }
        public string Number { get; set; }
        public DateTime Active { get; set; }
        public string Code { get; set; }
        public User (string name, string number, DateTime active)
        {
            Name = name;
            Number = number;
            Active = active;
            Code = $"{name.ToString()}_{number.ToString()}_{active.ToString()}";
        }
    }
}
