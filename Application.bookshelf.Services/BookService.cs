using Application.bookshelf.Core;
using Application.bookshelf.Repository;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Application.bookshelf.Services
{
    public class BookService : IBookService
    {
        private readonly IBookRepo _bookRepo;

        public BookService(IBookRepo bookRepo)
        {
            _bookRepo = bookRepo;
        }

        public async Task<List<Book>> GetAllBooks()
        {
            try
            {
                var booklist = await _bookRepo.GetAllBooks();
                return booklist ?? new List<Book>();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
