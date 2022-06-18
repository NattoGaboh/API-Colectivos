using System;
using API_Colectivos.Domain.IRepository;
using API_Colectivos.Domain.IServices;
using API_Colectivos.Domain.Models;

namespace API_Colectivos.Services
{
	public class UserService: IUserService
	{
		public readonly IUserRepository _userRepository;
		public UserService(IUserRepository userRepository)
		{
			_userRepository = userRepository;
		}
		public async Task SaveUser(User user)
        {
			await _userRepository.SaveUser(user);
        }

		public async Task<bool> ValidateExistence(User user)
		{
			return await _userRepository.ValidateExistence(user);
		}
	}
}

