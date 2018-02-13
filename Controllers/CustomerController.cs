using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using bankacademy.Models;
using System.Data.Entity;
using bankacademy.ViewModels;

namespace bankacademy.Controllers
{
    public class CustomerController : Controller
    {

        private ApplicationDbContext _context;

        public CustomerController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _context.CustomerSet.Include(c => c.MembershipType).ToList();


            return View(customer);
        }

        public ActionResult Details( int id)
        {
            var customerd = _context.CustomerSet.Include( c => c.MembershipType).SingleOrDefault( c => c.Id == id);


            return View(customerd);
         }

        public ActionResult Edit(int id)
        {
            var customerd = _context.CustomerSet.SingleOrDefault(c => c.Id == id);
            var eViewModel = new NewCustomerViewModel
            {
                customermodellist = customerd,
                MemberListType = _context.MemberTypeSet.ToList()
            };

            return View("CustomerForm", eViewModel);
        }

        public ActionResult New()
        {
            var membershipList = _context.MemberTypeSet.ToList();
            var cviewModel = new NewCustomerViewModel
            {
                MemberListType = membershipList
            };
            return View("CustomerForm",cviewModel);
        }

        [HttpPost]
        public ActionResult Save(Customermodel customeradd)
        {

            _context.CustomerSet.Add(customeradd);
            var customerInDb = _context.CustomerSet.Single(c => c.Id == customeradd.Id);
            customerInDb.Name = customeradd.Name;
            customerInDb.Birthdate = customeradd.Birthdate;
            customerInDb.MembershipTypeID = customeradd.MembershipTypeID;
            customerInDb.IsSubscribedToNewsletter = customeradd.IsSubscribedToNewsletter;
            _context.SaveChanges();

            return RedirectToAction("Index", "Customer");
        }
    }
}