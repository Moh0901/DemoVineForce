﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.Authorization.Entities
{
    public class Country
    {
        public int Id { get; set; }
        public string CountryName { get; set; }

        public ICollection<State> States { get; set; }
    }
}
