﻿using RunHub.Models;

namespace RunHub.Interfaces
{
	public interface IClubRepository
	{
		Task<IEnumerable<Club>> GetAll();

		Task<Club> GetByIdAsync(int id);

		Task<IEnumerable<Club>> GetClubCity(string city);

		bool Add(Club club);
		bool Update(Club club);	
		bool Delete(Club club);	
		bool Save();





	}
}
