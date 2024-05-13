namespace FirstApi.Models
{
	public class FirstModel
	{
		public FirstModel(string name, string password)
		{
			Id = Guid.NewGuid();
			Name = name;
			Password = password;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
	}
};
