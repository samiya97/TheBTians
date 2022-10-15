using CareProWeb.Models;
using Firebase.Auth;

namespace CareProWeb.Core.Interfaces
{
    public interface ILoginRepository 
    {
        Task<FirebaseAuthLink> Login(LoginModel loginModel);
        Task<FirebaseAuthLink> Registration(LoginModel loginModel);
    }
}
