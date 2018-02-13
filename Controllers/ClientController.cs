using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bankacademy.Models;
using System.Data.Entity;

namespace bankacademy.Controllers
{
    public class ClientController : Controller
    {

        private ApplicationDbContext _context;

        public ClientController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }


        // GET: Client
        public ActionResult Index()
        {
            var clientlists = _context.ClientSet.Include(c => c.ClientType).ToList();

            return View(clientlists);
        }


        public ActionResult Details(int id)
        {
            var clienttransaction = _context.ClientSet.Include(c => c.ClientType).SingleOrDefault( c => c.Id == id);

            return View(clienttransaction);
        }
    }
}