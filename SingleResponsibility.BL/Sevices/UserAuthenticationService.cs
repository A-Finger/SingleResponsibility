using SingleResponsibility.DAL.Models;
using SingleResponsibility.DAL.Repositories;

namespace SingleResponsibility.BL.Sevices
{
	public class UserAuthenticationService
	{
		private readonly UserRepository userRepository;
        public UserAuthenticationService(UserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

		public bool AuthenticateUser(string username, string password)
		{
			User user = userRepository.GetUserByUsername(username);
			return user is not null && user.Password == password;
		}
	}
}
