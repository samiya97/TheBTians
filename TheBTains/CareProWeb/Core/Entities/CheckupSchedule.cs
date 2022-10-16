namespace CareProWeb.Core.Entities
{
    public class CheckupSchedule
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? DID { get; set; }

        public DateTime? CheckUpDate { get; set; }

        public decimal? CheckUpTime { get; set; }

        public string CheckUpStatus { get; set; }

        public string CheckUpPriority { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
