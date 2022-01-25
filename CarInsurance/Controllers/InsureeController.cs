using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,Caryear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            var baseQuote = 50.0;
            var today = DateTime.Now;
            var age = today.Year - insuree.DateofBirth.Year;
            var getQuoteValue = 0.0;
            var ageTracker = 0.0;
            var carYearTracker = 0.0;
            var speedTicketTracker = 0.0;
            var duiTracker = 0.0;
            var fullCoveage = 0.0;
            var quoteResult = 0.0;


            if (ModelState.IsValid)
            {
                 if (age < 19 && insuree.CarMake.Equals("Porsche") && insuree.CarModel.Equals("911 Carrera")
                        && insuree.Caryear > 2015 || insuree.Caryear < 2000 )
                {
                    ageTracker = 100;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType) {
                    fullCoveage = quoteResult / 100 * 50;
                     }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;

                }
                 if (age < 19 && insuree.CarMake.Equals("Porsche")
                 && insuree.CarModel.Equals("911 Carrera") && insuree.Caryear >= 2000 || insuree.Caryear <= 2015 )
                {
                    ageTracker = 100;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age < 19 && insuree.CarMake.Equals("Porsche") && insuree.Caryear > 2015 || insuree.Caryear < 2000 )
                {
                    ageTracker = 100;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age < 19 && insuree.CarMake.Equals("Porsche") && insuree.Caryear >= 2000 || insuree.Caryear <= 2015 )
                {
                    ageTracker = 100;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                if (age < 19 && insuree.Caryear > 2015 || insuree.Caryear < 2000)
                {
                    ageTracker = 100;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age < 19 && insuree.Caryear >= 2000 || insuree.Caryear <= 2015)
                {
                    ageTracker = 100;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                /////////////////////////////////////////////////////////////////
                 if (age > 18 && age <= 25 && insuree.CarMake.Equals("Porsche")
                && insuree.CarModel.Equals("911 Carrera") && age <= 25 && insuree.Caryear > 2015 || insuree.Caryear < 2000  )
                {
                    ageTracker = 50;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age > 18 && age <= 25 && insuree.CarMake.Equals("Porsche") && insuree.CarModel.Equals("911 Carrera")
                && insuree.Caryear >= 2000 || insuree.Caryear <= 2015)
                {
                    ageTracker = 50;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age > 18 && age <= 25 && insuree.CarMake.Equals("Porsche") && insuree.Caryear > 2015 || insuree.Caryear < 2000 )
                {
                    ageTracker = 50;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age > 18 && age <= 25 && insuree.CarMake.Equals("Porsche") && insuree.Caryear >= 2000 || insuree.Caryear <= 2015 )
                {
                    ageTracker = 50;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age > 18 && age <= 25 && insuree.Caryear > 2015 || insuree.Caryear < 2000)
                {
                    ageTracker = 50;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age > 18 && age <= 25 && insuree.Caryear >= 2000 || insuree.Caryear <= 2015)
                {
                    ageTracker = 50;
                    carYearTracker = 0;
                    quoteResult = baseQuote + ageTracker + carYearTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                //////////////////////////////////////////////////////////////////

                 if (age > 25 && insuree.CarMake == "Porsche"
                    && insuree.CarModel.Equals("911 Carrera") && insuree.Caryear > 2015 || insuree.Caryear < 2000 )
                {
                    ageTracker = 25;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age > 25 && insuree.CarMake.Equals("Porsche") && insuree.CarModel.Equals("911 Carrera") 
                && insuree.Caryear >= 2000 || insuree.Caryear <= 2015 )
                {
                    ageTracker = 25;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 50 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age > 25 && insuree.CarMake.Equals("Porsche") && insuree.Caryear > 2015 || insuree.Caryear < 2000)
                {
                    ageTracker = 25;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age > 25 && insuree.CarMake.Equals("Porsche") && insuree.Caryear >= 2000 || insuree.Caryear <= 2015 )
                {
                    ageTracker = 25;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = 25 + baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }

                 if (age > 25 && insuree.Caryear > 2015 || insuree.Caryear < 2000)
                {
                    ageTracker = 25;
                    carYearTracker = 25;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;
                }
                 if (age > 25 && insuree.Caryear >= 2000 || insuree.Caryear <= 2015)
                {
                    ageTracker = 25;
                    carYearTracker = 0;
                    speedTicketTracker = insuree.SpeedingTickets * 10;
                    quoteResult = baseQuote + ageTracker + carYearTracker + speedTicketTracker;
                    if (insuree.DUI)
                    {
                        duiTracker = quoteResult / 100 * 25;
                    }
                    if (insuree.CoverageType)
                    {
                        fullCoveage = quoteResult / 100 * 50;
                    }

                    getQuoteValue = quoteResult + duiTracker + fullCoveage;

                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateofBirth,Caryear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
