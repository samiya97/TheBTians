namespace CareProWeb.Core.Entities
{
    public class Promotions
    {
        public int ID { get; set; }

        public int? DID { get; set; }

        public int? PID { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public string Discounts { get; set; }

        public string Vouchers { get; set; }

        public DateTime? DateFrom { get; set; }

        public DateTime? DateTo { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
