namespace CareProWeb.Core.Interfaces
{
    public interface IUnitOfWork
    {
        IPatientRepository Patients { get; }
        IDoctorRepository Doctors { get; }
        IAppointCheckUpRepository AppointCheckUp { get; }
        ICheckupScheduleRepository CheckupSchedule { get; }
        IComplainSymptomsRepository ComplainSymptoms { get; }
        IDoctorDetailsRepository DoctorDetails { get; }
        IDoctorNotificationRepository DoctorNotification { get; }
        IDoctorPatientsRepository DoctorPatients { get; }
        IDoctorReviewsRepository DoctorReviews { get; }
        IDoctorsPrescriptionRepository DoctorsPrescription { get; }
        IHospitalsRepository Hospitals { get; }
        ILabTestCategoryRepository LabTestCategory { get; }
        INotificationTypeRepository NotificationType { get; }
        IPatientDetailsRepository PatientDetails { get; }
        IPatientNotificationRepository PatientNotification { get; }
        IPDailyMedRepository PDailyMed { get; }
        IPLabTestAppointmentRepository PLabTestAppointment { get; }
        ISignUpRepository SignUp { get; }
    }
}
