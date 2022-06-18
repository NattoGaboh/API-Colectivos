using System;
using API_Colectivos.Domain.Models;

namespace API_Colectivos.Domain.IServices
{
	public interface ILoginService
	{
		Task<User> ValidateUser(User user);
	}
}

