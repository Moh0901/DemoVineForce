using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoVineForce.Authorization.Entities
{
    public class State
    {
        public int Id { get; set; }
        public string StateName { get; set; }
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
