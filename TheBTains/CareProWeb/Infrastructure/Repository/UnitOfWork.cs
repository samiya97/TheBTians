using CareProWeb.Core.Interfaces;

namespace CareProWeb.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public UnitOfWork(IPatientRepository patientRepository)
        {
            Patients = patientRepository;
        }
        public IPatientRepository Patients { get; }
    }
}
