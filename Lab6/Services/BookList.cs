using Lab6.Data;

namespace Lab6.Services
{
    public class BookList : IBookList
    {
        public List<Book> Books {  get; set; } = new List<Book>();
    }
}
