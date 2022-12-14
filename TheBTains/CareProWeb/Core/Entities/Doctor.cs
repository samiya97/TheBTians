namespace CareProWeb.Core.Entities
{
    public class Doctor
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public DateTime? DOB { get; set; }

        public decimal? Phone { get; set; }

        public string Address { get; set; }

        public bool? Status { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
