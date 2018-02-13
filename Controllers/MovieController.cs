using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using bankacademy.Models;
using bankacademy.ViewModels;

namespace bankacademy.Controllers
{
    public class MovieController : Controller
    {

        private ApplicationDbContext _context;

        public MovieController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Movie
        public ActionResult Index()
        {
            var movielists = _context.MovieSet.Include(m => m.Genrelist).ToList();

            return View(movielists);
        }


        public ActionResult Details( int id)
        {
            var movielists = _context.MovieSet.Include(m => m.Genrelist).SingleOrDefault( m => m.Id == id);

            return View(movielists);
        }


        public ActionResult Edit(int id)
        {
            var movielists = _context.MovieSet.SingleOrDefault(m => m.Id == id);

            if (movielists == null)
                return HttpNotFound();

            var eViewModel = new MovieViewModel()
            {
                Moviemodel = movielists,
                Genrelist = _context.GenreSet.ToList()
            };
            return View("CustomerMovieForm", eViewModel);
        }


        public ActionResult Delete(int id)
        {
            var movielists = _context.MovieSet.SingleOrDefault(m => m.Id == id);
            var eViewModel = new MovieViewModel
            {
                Moviemodel = movielists,
                Genrelist = _context.GenreSet
            };
            return View("Delete", eViewModel);
        }

        public ActionResult New()
        {
            var GenreTypes = _context.GenreSet.ToList();

            var nViewModel = new MovieViewModel(){

                Moviemodel = new Moviemodel(),
                Genrelist = GenreTypes

            };
            return View("CustomerMovieForm",nViewModel);
        }


   


        [HttpPost]
        public ActionResult Save(Moviemodel moviemodel)
        {
            if(!ModelState.IsValid)
            {
                var mviewModel = new MovieViewModel
                {
                    Moviemodel = moviemodel,
                    Genrelist = _context.GenreSet.ToList()
                };
                return View("CustomerMovieForm", mviewModel);
            }



            if (moviemodel.Id == 0)
            _context.MovieSet.Add(moviemodel);
            else
            { 
                var movieInDb = _context.MovieSet.Single(c => c.Id == moviemodel.Id);

                movieInDb.Name = moviemodel.Name;
                movieInDb.ReleaseDate = moviemodel.ReleaseDate;
                movieInDb.NumberInStock = moviemodel.NumberInStock;
                movieInDb.Description = moviemodel.Description;
              
              
            } 
            _context.SaveChanges();
            return RedirectToAction("Index","Movie");
        }
    }
}