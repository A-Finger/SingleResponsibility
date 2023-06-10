using SingleResponsibility.DAL.Models;
using SingleResponsibility.DAL.Repositories;

namespace SingleResponsibility.BL.Sevices
{
	public class UserRegistrationService
	{
		public readonly UserRepository userRepository;
		public UserRegistrationService(UserRepository userRepository)
		{
			this.userRepository = userRepository;
		}

		public void RegisterUser(string name, string password)
		{
			User user = userRepository.GetUserByUsername(name) is null ?
				throw new ArgumentException("This user already exists") :
				new User(name, password);
		}
	}
}
