namespace FirstApi.Models
{
	public class FirstModel
	{
		public FirstModel(Guid id, string name, string password)
		{
			Id = id;
			Name = name;
			Password = password;
		}

		public Guid Id { get; set; }
		public string Name { get; set; }
		public string Password { get; set; }
	}
};
