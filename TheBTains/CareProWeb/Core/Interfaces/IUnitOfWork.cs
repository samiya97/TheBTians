namespace CareProWeb.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository Patients { get; }
        IDoctorRepository Doctors { get; }
    }
}
