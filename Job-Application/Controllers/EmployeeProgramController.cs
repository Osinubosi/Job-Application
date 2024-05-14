using Job_Application.Respositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Job_Application.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class EmployeeProgramController : ControllerBase
	{
		private readonly IProgramRepository _programRepository;

		public EmployeeProgramController(IProgramRepository programRepository)
		{
			_programRepository = programRepository;
		}
	}
}
