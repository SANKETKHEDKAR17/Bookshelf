using Application.bookshelf.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.bookshelf.Repository
{
    public interface IBookRepo
    {
        Task<List<Book>> GetAllBooks();
    }
}
