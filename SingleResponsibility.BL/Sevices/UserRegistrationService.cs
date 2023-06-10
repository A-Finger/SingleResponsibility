using SingleResponsibility.DAL.Models;
using SingleResponsibility.DAL.Repositories;

namespace SingleResponsibility.BL.Sevices
{
	public class UserRegistrationService
	{
		private readonly UserRepository userRepository;
		public UserRegistrationService(UserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public void RegisterUser(string name, string password)
		{
			User user = userRepository.GetUserByUsername(name);
			userRepository.Save(user is null ? new User(name, password) : throw new ArgumentException("This user already exists"));
		}
	}
}
