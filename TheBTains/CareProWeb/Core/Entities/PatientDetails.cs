namespace CareProWeb.Core.Entities
{
    public class PatientDetails
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public string Dignosys { get; set; }

        public string Treatment { get; set; }

        public string BloodGroup { get; set; }

        public string Height { get; set; }

        public string Weight { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
