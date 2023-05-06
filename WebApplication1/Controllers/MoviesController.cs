using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;


namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        public IActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" }; //from database
            return View(movie);//ekvivalentno reutn new ViewResult() ali kako ako    je ovo interferjs
        }                      //prosledili smo MODEL pogledu 
                               // postoje jos dva nacina viewDataDictionary i viewBag oba losa
        public IActionResult PoDatumuPustanja(int godina, int mesec)
        {
            return Content(godina + "/" + mesec);
        }
        
    }
}
