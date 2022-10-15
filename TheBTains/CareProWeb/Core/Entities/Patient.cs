namespace CareProWeb.Core.Entities
{
    public class Patient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string DOB { get; set; }
        public decimal Height { get; set; }
       // public prescription Prescription { get; set; }
        public int DietPlanId { get; set; }
        public int MyProperty { get; set; }
    }
    public class Prescription 
    {

    }

}
