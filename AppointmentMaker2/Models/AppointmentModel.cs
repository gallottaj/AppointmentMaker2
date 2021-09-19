using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AppointmentMaker2.Models
{
    public class AppointmentModel
    {
        [Required]
        [DisplayName("Patient's full name")]
        public string PatientName { get; set; }
        [DisplayName("Appointment request date")]
        public DateTime AppointmentDate { get; set; }
        [DisplayName("Patient's net worth")]

        public decimal PatientNetWorth { get; set; }
        [DisplayName("Primary doctor last name")]

        public string DoctorName { get; set; }
        [DisplayName("Patients perceived name (1-10)")]

        public int PainLevel { get; set; }

    }
}
