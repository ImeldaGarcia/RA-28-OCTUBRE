using GOBUS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOBUS.Controllers
{
    public class SucursaleController : Controller
    {
        private GOBUSContext dbCtx = new GOBUSContext();
        // GET: Sucursale
        public ActionResult Index()
        {
            List<Sucursale> Sucursales = new List<Sucursale>();

            Sucursales = dbCtx.Sucursales.OrderBy(x => x.Nombre).ToList();
            return View(Sucursales);

        }

        // GET: Sucursale/Details/5
        public ActionResult Details(int id)
        {
            Sucursale sucursale = dbCtx.Sucursales.Find(id);

            if (sucursale == null)
            {
                return HttpNotFound();
            }
            return View(sucursale);
        }

        // GET: Sucursale/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sucursale/Create
        [HttpPost]
        public ActionResult Create(Sucursale sucursale)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Sucursales.Add(sucursale);
                        dbCtx.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }

                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursale/Edit/5
        public ActionResult Edit(int id)
        {
            Sucursale sucursale = dbCtx.Sucursales.Find(id);
            if (sucursale == null)
            {
                return HttpNotFound();
            }
            return View(sucursale);
        }

        // POST: Sucursale/Edit/5
        [HttpPost]
        public ActionResult Edit(Sucursale sucursale)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Entry(sucursale).State = System.Data.Entity.EntityState.Modified;
                        dbCtx.SaveChanges();
                    }
                    catch (DbEntityValidationException e)
                    {
                        foreach (var eve in e.EntityValidationErrors)
                        {
                            Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                                eve.Entry.Entity.GetType().Name, eve.Entry.State);
                            foreach (var ve in eve.ValidationErrors)
                            {
                                Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                            }
                        }
                        throw;
                    }
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sucursale/Delete/5
        public ActionResult Delete(int? id)
        {
            Sucursale sucursale = dbCtx.Sucursales.Find(id);
            if (sucursale == null)
            {
                return HttpNotFound();
            }
            return View(sucursale);
        }

        // POST: Sucursale/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                try
                {
                    Sucursale sucursale = dbCtx.Sucursales.Find(id);
                    dbCtx.Sucursales.Remove(sucursale);
                    dbCtx.SaveChanges();
                }
                catch (DbEntityValidationException e)
                {
                    foreach (var eve in e.EntityValidationErrors)
                    {
                        Console.WriteLine("Entity of type \"{0}\" in state \"{1}\" has the following validation errors:",
                            eve.Entry.Entity.GetType().Name, eve.Entry.State);
                        foreach (var ve in eve.ValidationErrors)
                        {
                            Console.WriteLine("- Property: \"{0}\", Error: \"{1}\"", ve.PropertyName, ve.ErrorMessage);
                        }
                    }
                    throw;
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
