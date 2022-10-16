namespace CareProWeb.Core.Entities
{
    public class DoctorDetails
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? HID { get; set; }

        public string Qualification { get; set; }

        public string Specialization { get; set; }

        public decimal? Timings { get; set; }

        public decimal? Days { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
