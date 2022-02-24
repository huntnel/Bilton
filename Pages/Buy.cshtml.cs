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

        public BuyModel (IBookRepository temp)
        {
            repo = temp;
        }
        public Basket basket { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
        }

        public IActionResult OnPost(int bookId, string returnUrl)
        {
            Book b = repo.Books.FirstOrDefault(x => x.BookId == bookId);

            basket = HttpContext.Session.GetJson<Basket>("basket") ?? new Basket();
            basket.addItem(b, 1);

            HttpContext.Session.setJson("basket", basket);

            return RedirectToPage(new { ReturnUrl = returnUrl});
        }
    }
}
