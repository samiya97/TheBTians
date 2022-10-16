namespace CareProWeb.Core.Entities
{
    public class PDailyMed
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? PreID { get; set; }

        public DateTime? TodayDate { get; set; }

        public decimal? MedTime { get; set; }

        public string MedName { get; set; }

        public bool MedTaken { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
