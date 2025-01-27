﻿using Microsoft.EntityFrameworkCore;
using workshop.wwwapi.Data;
using workshop.wwwapi.Models;

namespace workshop.wwwapi.Repository.Implementation
{
    public class PatientRepository : IPatientRepository
    {
        private DatabaseContext _db;
        public PatientRepository(DatabaseContext db)
        {
            _db = db;
        }
        public async Task<IEnumerable<Patient>> Get()
        {
            return await _db.Patients
                .Include(p => p.Appointments)
                    .ThenInclude(a => a.Doctor)
                .Include(p => p.Appointments)
                    .ThenInclude(a => a.Prescription)
                        .ThenInclude(p => p.Medicines)
                .ToListAsync();
        }

        public async Task<Patient?> Get(int id)
        {
            return await _db.Patients
                .Include(p => p.Appointments)
                    .ThenInclude(a => a.Doctor)
                .Include(p => p.Appointments)
                    .ThenInclude(a => a.Prescription)
                        .ThenInclude(pr => pr.Medicines)
                .FirstOrDefaultAsync(p => p.Id == id);
        }
        public async Task<Patient?> Create(Patient patient)
        {
            _db.Patients.Add(patient);
            await _db.SaveChangesAsync();
            return patient;
        }
    }
}
