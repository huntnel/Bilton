using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilton.Models
{
    public class EFBooksRepository : IBookRepository
    {
        private BookstoreContext context { get; set; }
        public EFBooksRepository(BookstoreContext temp)
        {
            context = temp;
        }
        public IQueryable<Book> Books => context.Books;
    }
}
