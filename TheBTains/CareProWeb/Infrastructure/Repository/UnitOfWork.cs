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

        public IAppointCheckUpRepository AppointCheckUp { get; }

        public ICheckupScheduleRepository CheckupSchedule { get; }

        public IComplainSymptomsRepository ComplainSymptoms { get; }

        public IDoctorDetailsRepository DoctorDetails { get; }

        public IDoctorNotificationRepository DoctorNotification { get; }

        public IDoctorPatientsRepository DoctorPatients { get; }

        public IDoctorReviewsRepository DoctorReviews { get; }

        public IDoctorsPrescriptionRepository DoctorsPrescription { get; }

        public IHospitalsRepository Hospitals { get; }

        public ILabTestCategoryRepository LabTestCategory { get; }

        public INotificationTypeRepository NotificationType { get; }

        public IPatientDetailsRepository PatientDetails { get; }

        public IPatientNotificationRepository PatientNotification { get; }

        public IPDailyMedRepository PDailyMed { get; }

        public IPLabTestAppointmentRepository PLabTestAppointment { get; }

        public ISignUpRepository SignUp { get; }
    }
}
