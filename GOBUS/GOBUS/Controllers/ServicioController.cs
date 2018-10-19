using GOBUS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOBUS.Controllers
{
    public class ServicioController : Controller
    {
        private GOBUSContext dbCtx = new GOBUSContext();
        // GET: Servicio
        public ActionResult Index()
        {
            List<Servicio> Servicios = new List<Servicio>();

            Servicios = dbCtx.Servicios.OrderBy(x => x.Id).ToList();
            return View(Servicios);
        }

        // GET: Servicio/Details/5
        public ActionResult Details(int id)
        {
            Servicio servicio = dbCtx.Servicios.Find(id);

            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // GET: Servicio/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Servicio/Create
        [HttpPost]
        public ActionResult Create(Servicio servicio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Servicios.Add(servicio);
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

        // GET: Servicio/Edit/5
        public ActionResult Edit(int id)
        {
            Servicio servicio = dbCtx.Servicios.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Servicio/Edit/5
        [HttpPost]
        public ActionResult Edit(Servicio servicio)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Entry(servicio).State = System.Data.Entity.EntityState.Modified;
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

        // GET: Servicio/Delete/5
        public ActionResult Delete(int? id)
        {
            Servicio servicio = dbCtx.Servicios.Find(id);
            if (servicio == null)
            {
                return HttpNotFound();
            }
            return View(servicio);
        }

        // POST: Servicio/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                try
                {
                    Servicio servicio = dbCtx.Servicios.Find(id);
                    dbCtx.Servicios.Remove(servicio);
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
