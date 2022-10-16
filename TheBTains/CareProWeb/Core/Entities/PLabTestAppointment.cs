namespace CareProWeb.Core.Entities
{
    public class PLabTestAppointment
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? TCID { get; set; }

        public int? PreID { get; set; }

        public DateTime? TestDate { get; set; }

        public string LabName { get; set; }

        public string TestResult { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
