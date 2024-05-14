using Job_Application.Models;
using Job_Application.Respositories.Interfaces;
using MongoDB.Driver;

namespace Job_Application.Respositories.Implementations
{
	public class ProgramRepository : IProgramRepository
	{
		private readonly IMongoCollection<EmployeeProgram> _programs;
        public ProgramRepository(IMongoDatabase database)
        {
            _programs = database.GetCollection<EmployeeProgram>("Programs");
        }

		public async Task CreateProgramAsync(EmployeeProgram program)
		{
			await _programs.InsertOneAsync(program);
		}

		public async Task DeleteProgramAsync(string id)
		{
			await _programs.DeleteOneAsync(program => program.Id == id);
		}

		public async Task<IEnumerable<EmployeeProgram>> GetAllProgramsAsync()
		{
			return await _programs.Find(program => true).ToListAsync();
		}

		public async Task<EmployeeProgram> GetProgramByIdAsync(string id)
		{
			return await _programs.Find<EmployeeProgram>(program => program.Id == id).FirstOrDefaultAsync();
		}

		public async Task UpdateProgramAsync(string id, EmployeeProgram program)
		{
			await _programs.ReplaceOneAsync(p => p.Id == id, program);
		}
	}
}
