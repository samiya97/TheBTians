using CareProWeb.Core.Interfaces;
using CareProWeb.Models;
using Firebase.Auth;

namespace CareProWeb.Infrastructure.Repository
{
    public class LoginRepository : ILoginRepository
    {
        FirebaseAuthProvider auth;

        public LoginRepository()
        {
            auth = new FirebaseAuthProvider(
                            new FirebaseConfig("AIzaSyCu39EZDuRhIDPlQpSblBNNHF7xv6CRnr4"));
        }

        public async Task<FirebaseAuthLink> Login(LoginModel loginModel)
        {
            if (string.IsNullOrEmpty(loginModel.Email) || string.IsNullOrEmpty(loginModel.Password))
            {
                throw new ArgumentNullException(nameof(loginModel.Email));
            }
            try
            {
                //log in an existing user
                return await auth
                                .SignInWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
            }
            catch (FirebaseAuthException ex)
            {
                throw ex;
            }
        }
        public async Task<FirebaseAuthLink> Registration(LoginModel loginModel)
        {
            if (string.IsNullOrEmpty(loginModel.Email) || string.IsNullOrEmpty(loginModel.Password))
            {
                throw new ArgumentNullException(nameof(loginModel.Email));
            }
            try
            {
                //create the user
                await auth.CreateUserWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
                //log in the new user
                return await auth
                                .SignInWithEmailAndPasswordAsync(loginModel.Email, loginModel.Password);
            }
            catch (FirebaseAuthException ex)
            {
                throw ex;
            }
        }
    }
}
