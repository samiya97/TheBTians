namespace CareProWeb.Core.Entities
{
    public class DoctorsPrescription
    {
        public int ID { get; set; }

        public int? PID { get; set; }

        public int? LabTestID { get; set; }

        public string MedName { get; set; }

        public decimal? MedDosage { get; set; }

        public decimal? MedDays { get; set; }

        public decimal? MedTime { get; set; }

        public string SpecificInstruction { get; set; }

        public int? CreatedBy { get; set; }

        public DateTime? CreatedOn { get; set; }

    }
}
