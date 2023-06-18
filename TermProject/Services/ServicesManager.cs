namespace TermProject.Services
{
    public class ServicesManager : IServicesManager
    {
        private readonly IAuthServices _authServices;

        public ServicesManager(IAuthServices authServices)
        {
            _authServices = authServices;
        }

        public IAuthServices AuthServices => _authServices;
    }
}
