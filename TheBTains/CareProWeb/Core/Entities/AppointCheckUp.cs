namespace CareProWeb.Core.Entities
{
    public class AppointCheckUp
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? DID { get; set; }

        public bool? RequestCheckUP { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
