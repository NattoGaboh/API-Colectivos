using System;
using API_Colectivos.Domain.Models;

namespace API_Colectivos.Domain.IRepository
{
	public interface IUserRepository
	{
		//Task<List<User>> GetListUser();
		Task SaveUser(User user);
		Task<bool> ValidateExistence(User user);
	}
}

