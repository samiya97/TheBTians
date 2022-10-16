namespace CareProWeb.Core.Entities
{
    public class DoctorReviews
    {
        public int ID { get; set; }

        public int? DID { get; set; }

        public int? PID { get; set; }

        public decimal? Rating { get; set; }

        public string Reviews { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
