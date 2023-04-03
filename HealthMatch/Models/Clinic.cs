using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HealthMatch.Models
{
    public class Clinic
    {
        public int ClinicId { get; set; }
        public string ClinicName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
        public string Phone { get; set; }
        public string IsUrgentOffered { get; set; }


    }
}
