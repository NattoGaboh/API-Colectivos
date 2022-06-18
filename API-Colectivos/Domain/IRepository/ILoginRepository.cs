using System;
using API_Colectivos.Domain.Models;

namespace API_Colectivos.Domain.IRepository
{
	public interface ILoginRepository
	{
		Task<User> ValidateUser(User user);
	}
}

