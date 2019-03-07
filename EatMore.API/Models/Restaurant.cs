﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EatMore.API.Models
{
    public class Restaurant
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Menu> Menus { get; set; }
    }
}
