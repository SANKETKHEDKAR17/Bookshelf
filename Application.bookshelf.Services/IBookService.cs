using Application.bookshelf.Core;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.bookshelf.Services
{
    public interface IBookService
    {
        Task<List<Book>> GetAllBooks();
    }
}
