﻿namespace workshop.wwwapi.Models
{
    public class OutputPatient
    {
        public int Id { get; set; }

        public string FullName { get; set; }

        public IEnumerable<AppointmentWhithoutPatient> Appointments { get; set; }
    }
}
