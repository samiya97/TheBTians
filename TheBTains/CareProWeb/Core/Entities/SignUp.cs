namespace CareProWeb.Core.Entities
{
    public class SignUp
    {
        public int ID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public int? RoleID { get; set; }

    }
}
