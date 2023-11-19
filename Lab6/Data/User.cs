namespace Lab6.Data
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

		public List<User> users = new List<User>();
	}
}