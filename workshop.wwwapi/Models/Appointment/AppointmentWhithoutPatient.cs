﻿namespace workshop.wwwapi.Models
{
    public class AppointmentWhithoutPatient
    {
        public DateTime Booking { get; set; }

        public DoctorWhithoutAppointment Doctor { get; set; }
    }
}