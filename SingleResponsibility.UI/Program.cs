using SingleResponsibility.BL.Sevices;
using SingleResponsibility.DAL.Repositories;

namespace SingleResponsibility.UI
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UserRepository userRepository = new UserRepository();
			UserRegistrationService registrationService = new UserRegistrationService(userRepository);
			UserAuthenticationService authenticationService = new UserAuthenticationService(userRepository);
			while (true)
			{
				Console.WriteLine("Sing up!");
				Console.Write("Enter new user name: ");
				string user = Console.ReadLine();
				Console.Write("Enter new password: ");
				string pass = Console.ReadLine();

				try
				{
					registrationService.RegisterUser(user, pass);
				}
				catch (Exception ex)
				{
					Console.WriteLine(ex.Message);
				}
				Console.WriteLine(new String('-', 50));
				Console.WriteLine("Sing in!");
				Console.Write("Enter username: ");
				string authName = Console.ReadLine();
				Console.Write("Enter password: ");
				string authPass = Console.ReadLine();
				if (authenticationService.AuthenticateUser(authName, authPass))
					Console.WriteLine("The user is successfully authenticated.");
				else
					Console.WriteLine("Invalid user data.");
			}
		}
	}
}