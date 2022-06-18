using System;
using API_Colectivos.Domain.IRepository;
using API_Colectivos.Domain.Models;
using API_Colectivos.Persistence.Context;

namespace API_Colectivos.Persistence.Repository
{
	public class UserRepository: IUserRepository
	{
		private readonly ApplicationDbContext _context;
		public UserRepository(ApplicationDbContext context)
		{
			_context = context;
		}
		public async Task SaveUser(User user)
        {
			_context.Add(user);
			await _context.SaveChangesAsync();
        }

		public async Task<bool> ValidateExistence(User user)
		{
			var validateExistence = await _context.User.AnyAsync(x => x.NameUser == user.NameUser);
			return validateExistence;
		}
	}
}

