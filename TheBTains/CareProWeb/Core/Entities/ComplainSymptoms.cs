namespace CareProWeb.Core.Entities
{
    public class ComplainSymptoms
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? DID { get; set; }

        public DateTime? SymptomDate { get; set; }

        public decimal? SymptomTime { get; set; }

        public string Symptoms { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
