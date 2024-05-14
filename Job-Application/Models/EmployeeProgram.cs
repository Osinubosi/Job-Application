namespace Job_Application.Models
{
	public class EmployeeProgram
	{
		public string Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public List<Step> Steps { get; set; }
	}

	public class Step
	{
		public string Id { get; set; }
		public string Title { get; set; }
		public string Content { get; set; }
	}

	public class User
	{
		public string Id { get; set; }
		public string Username { get; set; }
		public string Email { get; set; }
	}
}
