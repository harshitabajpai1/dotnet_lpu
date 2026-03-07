using Assesment_7March_Repository_Pattern.Models;
using Assesment_7March_Repository_Pattern.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Assesment_7March_Repository_Pattern.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookRepository _repo;
        public BookController(IBookRepository repo)
        {
            _repo = repo;
        }
        // GET: BookController
        public ActionResult Index()
        {
            return View(_repo.GetAllBooks());
        }

        // GET: BookController/Details/5
        public ActionResult Details(int Id)
        {
            return View(_repo.GetBookById(Id));
        }

        // GET: BookController/Create
        public ActionResult Create()
        {
            return View();
        }
        //public IActionResult Create(Book book)
        //{
        //    bool result = _repo.AddBook(book);

        //    if (result)
        //    {
        //        return RedirectToAction("Index");
        //    }

        //    return View(book);
        //}

        // POST: BookController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        
        public ActionResult Create(Book book)
        {
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
            _repo.AddBook(book);
            return RedirectToAction("Index");
        }

        // GET: BookController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookController/Delete/5
        public ActionResult Delete(int Id)
        {
            var book = _repo.GetBookById(Id);
            return View(book);
        }

        // POST: BookController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Book book)
        {
            _repo.DeleteBook(id);
            return RedirectToAction(nameof(Index));
            //try
            //{
            //    return RedirectToAction(nameof(Index));
            //}
            //catch
            //{
            //    return View();
            //}
        }
    }
}
