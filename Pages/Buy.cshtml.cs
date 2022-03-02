using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bilton.Infrastructure;
using Bilton.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Bilton.Infrastructure;

namespace Bilton.Pages
{
    public class BuyModel : PageModel
    {
        private IBookRepository repo { get; set; }

        public BuyModel (IBookRepository temp, Basket b)
        {
            repo = temp;
            basket = b;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket.addItem(b, 1);


            return RedirectToPage(new { ReturnUrl = returnUrl});
        }

        public IActionResult OnPostRemove(int bookId, string returnUrl)
        {
            basket.RemoveItem(basket.Items.First(x => x.Book.BookId == bookId).Book);
            return RedirectToPage(new { ReturnUrl = returnUrl });
        }
    }
}
