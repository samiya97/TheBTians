namespace CareProWeb.Core.Entities
{
    public class DoctorPatients
    {
        public int ID { get; set; }

        public int? DID { get; set; }

        public int? PID { get; set; }

        public int? PreID { get; set; }

        public int? HID { get; set; }

        public bool? SpeicalPatient { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
