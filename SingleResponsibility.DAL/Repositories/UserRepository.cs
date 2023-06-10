using SingleResponsibility.DAL.Models;

namespace SingleResponsibility.DAL.Repositories
{
	public class UserRepository
	{
		private List<User> users;
		public UserRepository()
		{
			users = new();
		}
		public void Save(User user) => users.Add(user);
		public User GetUserByUsername(string name) => users.FirstOrDefault(u => u.Name == name);
	}
}
