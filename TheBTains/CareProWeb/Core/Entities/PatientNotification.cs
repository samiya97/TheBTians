namespace CareProWeb.Core.Entities
{
    public class PatientNotification
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? NTID { get; set; }

        public string Message { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
