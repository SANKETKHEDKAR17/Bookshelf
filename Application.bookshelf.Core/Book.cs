using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.bookshelf.Core
{
    public class Book
    {
        public int Id { get; set; }

        [Required]
        public string BookName { get; set; }
      
        [Required]
        public string BookGenere { get; set; }
        [Required]
        public string BookEdition { get; set; }

        public DateTime Created { get; set; }

        public DateTime Modified { get; set; }

        [Required]
        public string BookAutherName { get; set; }
    }
}
