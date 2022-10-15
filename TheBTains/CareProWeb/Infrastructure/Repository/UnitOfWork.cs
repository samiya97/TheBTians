using CareProWeb.Core.Interfaces;

namespace CareProWeb.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IPatientRepository patientRepository, IDoctorRepository doctorRepository)
        {
            Patients = patientRepository;
            Doctors = doctorRepository;
        }
        public IPatientRepository Patients { get; }

        public IDoctorRepository Doctors { get; }
    }
}
