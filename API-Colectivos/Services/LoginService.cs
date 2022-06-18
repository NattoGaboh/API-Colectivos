using System;
using API_Colectivos.Domain.IRepository;
using API_Colectivos.Domain.IServices;
using API_Colectivos.Domain.Models;

namespace API_Colectivos.Services
{
	public class LoginService: ILoginService
	{
		public readonly ILoginRepository _loginRepository;
		public LoginService(ILoginRepository loginRepository)
		{
			_loginRepository = loginRepository;
		}

        public async Task<User> ValidateUser(User user)
        {
			return await _loginRepository.ValidateUser(user);
		}
    }
}

