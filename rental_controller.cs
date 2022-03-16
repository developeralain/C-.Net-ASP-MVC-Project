using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;

using System.Web;
using System.Web.Mvc;
using TheatreCMS3.Areas.Rent.Models;
using TheatreCMS3.Models;

namespace TheatreCMS3.Areas.Rent.Controllers
{
    public class RentalsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Rent/Rentals

        public ActionResult Index(string searchString = null , string lessSearchString = null)
        {
            

            //LINQ syntax to do SQL-like query for all items in Rentals table
            var rentals = from r in db.Rentals
                          select r;
            //catches an integer from user string parameter, if any, and is the output of isInteger variable
            int costFilterValue = 0;
            int costFilterValue2 = 0;

            //isInteger is a boolean that states if the string is an integer. If it is, stores integer in costFilterValue above
            bool isInteger = int.TryParse(searchString, out costFilterValue);
            bool isInteger2 = int.TryParse(lessSearchString, out costFilterValue2);

            if (!string.IsNullOrEmpty(searchString))
            {
                //if search string is not null and is not an integer, filter by RentalName
                if (!String.IsNullOrEmpty(searchString) && !isInteger)
                {
                    rentals = rentals.Where(r => r.RentalName.ToUpper().Contains(searchString.ToUpper()));

                }

                //if search string is not null and is an integer, filter by rentals with Cost > integer value
                if (!String.IsNullOrEmpty(searchString) && isInteger)
                {
                    rentals = rentals.Where(r => r.RentalCost > costFilterValue);

                }
                ViewBag.searchType = "X";
                
            }
            if (!string.IsNullOrEmpty(lessSearchString))
            {
                //if search string is not null and is not an integer, filter by RentalName
                if (!String.IsNullOrEmpty(lessSearchString) && !isInteger2)
                {
                    rentals = rentals.Where(r => r.RentalName.ToUpper().Contains(lessSearchString.ToUpper()));

                }

                //if search string is not null and is an integer, filter by rentals with Cost > integer value
                if (!String.IsNullOrEmpty(lessSearchString) && isInteger2)
                {
                    rentals = rentals.Where(r => r.RentalCost < costFilterValue2);

                }
                ViewBag.searchType = "Y";
            }
            return View(rentals.ToList());


        }     

        public ActionResult LessThan()
        {
            TempData["searchType"] = "Y";
            return RedirectToAction("Index");
        }

        public ActionResult GreaterThan()
        {
            TempData["searchType"] = "X";
            return RedirectToAction("Index");
        }

        // GET: Rent/Rentals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            if (rental.SuffocationHazard != null || rental.ChokingHazard != null || rental.PurchasePrice != null)
            {
                ViewData["rentaltype"] = "rentalequipment";
                return View(rental);
            }
            if (rental.SquareFootage != null || rental.RoomNumber != null || rental.MaxOccupancy != null)
            {
                ViewData["rentaltype"] = "rentalroom";
                return View(rental);
            }
            return View(rental);
        }

        // GET: Rent/Rentals/Create
        public ActionResult Create()
        {
            
            return View();
            
        }

        //The logic of using TempData/ViewData (as appropriate) and passing in a given KVP is applied to Edit, Details, and Delete
        //actions as well. It is used to control what the corresponding view displays to the user in the way of fields. We only want 
        //relevant/applicable fields to display, depending on what exactly it is they are looking at (Rental, Rental Equipment, Rental Room)
        
        // POST: Rent/Rentals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,ChokingHazard,SuffocationHazard,PurchasePrice,RoomNumber,SquareFootage,MaxOccupancy")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Rentals.Add(rental);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(rental);
        }

        public ActionResult CreateRentalEquipment()
        {
            TempData["rentaltype"] = "rentalequipment";
            return RedirectToAction("Create");
        }


        public ActionResult CreateRentalRoom()
        {
            TempData["rentaltype"] = "rentalroom";
            return RedirectToAction("Create");
        }

        // GET: Rent/Rentals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            if (rental.SuffocationHazard != null || rental.ChokingHazard != null || rental.PurchasePrice != null)
            {
                ViewData["rentaltype"] = "rentalequipment";
                return View(rental);
            }
            if (rental.SquareFootage != null || rental.RoomNumber != null || rental.MaxOccupancy != null)
            {
                ViewData["rentaltype"] = "rentalroom";
                return View(rental);
            }
            return View(rental);
        }

        // POST: Rent/Rentals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "RentalId,RentalName,RentalCost,FlawsAndDamages,ChokingHazard,SuffocationHazard,PurchasePrice,RoomNumber,SquareFootage,MaxOccupancy")] Rental rental)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rental).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(rental);
        }


        // GET: Rent/Rentals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Rental rental = db.Rentals.Find(id);
            if (rental == null)
            {
                return HttpNotFound();
            }
            if (rental.SuffocationHazard != null || rental.ChokingHazard != null || rental.PurchasePrice != null)
            {
                ViewData["rentaltype"] = "rentalequipment";
                return View(rental);
            }
            if (rental.SquareFootage != null || rental.RoomNumber != null || rental.MaxOccupancy != null)
            {
                ViewData["rentaltype"] = "rentalroom";
                return View(rental);
            }
            return View(rental);
        }

        // POST: Rent/Rentals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Rental rental = db.Rentals.Find(id);
            db.Rentals.Remove(rental);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
