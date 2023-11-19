using Lab6.Data;

namespace Lab6.Services
{
    public class UserList : IUserList
    {
        public List<User> users { get; set; } = new List<User>();
    }
}
