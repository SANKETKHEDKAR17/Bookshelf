using Application.bookshelf.Core;
using Application.bookshelf.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Application.bookshelf.Applications.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {

            _bookService = bookService;
        }


        [HttpGet("GetAllBooks")]

        public async Task<IActionResult> GetAllBooks()
        {
            var list = await _bookService.GetAllBooks();
            if (list == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(list);
            }



        }


        [HttpGet("GetBooksByID")]
        public async Task<IActionResult> GetBooksByID()
        {
            return NotFound();
        }

        //[Route("{EmployeeId:int:max(1000)}")]
        //[Route("{EmployeeId:int:min(100):max(1000)}")]	

        //[Route("{EmployeeName:regex(a(b|c))}")]	
        //To validate the value of a particular variable by using the regex route constraint.
        //The regex takes one parameter; you can specify an expression or pattern to validate

        // [Route("{Bookid:alpha:maxlength(2)}")]

        //[HttpGet]

        // public string SearchBook()
        //{ 
        //    var BookName = HttpContext.Request.Query["Bookname"].ToString();
        //    var Genere = HttpContext.Request.Query["Genere"].ToString();
        //    return $"Return Employee With Department ";
        // }

        [Route("api/BookDetails")]
        [HttpGet]


        public IEnumerable<Book> GetBookDetails()
        {
            return new List<Book>()
            {
                new Book()
                {
                    Id = 1,
                    BookName = "Rising Stars",
                    BookAutherName = "Kane Willam",
                    BookGenere = "Biopic",
                    BookEdition = "First Edition",

                },
                new Book()
                {
                    Id = 2,
                    BookName = "Rising little champ",
                    BookAutherName = "Kane Willam",
                    BookGenere = "horror",
                    BookEdition = "First Edition",

                },
            };
        }
    }
}

