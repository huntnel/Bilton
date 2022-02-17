using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bilton.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalNumBooks { get; set; }
        public int BooksPerPage { get; set; }
        public int currentPage { get; set; }
        public int totalPages => (int)Math.Ceiling((double)TotalNumBooks / BooksPerPage);
    }
}
