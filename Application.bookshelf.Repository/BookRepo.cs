using Application.bookshelf.Core;
using Application.bookshelf.Infractructure;
using Dapper;

namespace Application.bookshelf.Repository
{
    public class BookRepo : IBookRepo
    {
        private readonly BookShelfDbContext _context;

        #region SQLQueries
        private string queryBookList = "SELECT * FROM Book";
        #endregion

        public BookRepo(BookShelfDbContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            using (var connection = _context.CreateConnection())
            {
                var bookList = await connection.QueryAsync<Book>(queryBookList);
                return bookList.ToList();
            }
        }
    }
}
