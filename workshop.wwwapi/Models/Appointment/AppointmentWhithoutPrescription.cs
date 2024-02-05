﻿namespace workshop.wwwapi.Models
{
    public class AppointmentWhithoutPrescription
    {
        public int Id { get; set; }

        public DateTime Booking { get; set; }

        //public AppointmentType Type { get; set; }

        public DoctorWhithoutAppointment Doctor { get; set; }

        public PatientWhithoutAppointment Patient { get; set; }
    }
}