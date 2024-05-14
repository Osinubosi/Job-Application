using Job_Application.Models;

namespace Job_Application.Respositories.Interfaces
{
	public interface IProgramRepository
	{
		Task<IEnumerable<EmployeeProgram>> GetAllProgramsAsync();
		Task<EmployeeProgram> GetProgramByIdAsync(string id);
		Task CreateProgramAsync(EmployeeProgram program);
		Task UpdateProgramAsync(string id, EmployeeProgram program);
		Task DeleteProgramAsync(string id);
	}
}
