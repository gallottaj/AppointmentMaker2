using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker2.Models
{
    public class AppointmentModel
    {
        public string PatientName { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PatientNetWorth { get; set; }
        public string DoctorName { get; set; }
        public int PainLevel { get; set; }
    }
}
