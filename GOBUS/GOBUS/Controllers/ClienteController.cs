using GOBUS.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GOBUS.Controllers
{
    public class ClienteController : Controller
    {
        private GOBUSContext dbCtx = new GOBUSContext();

        // GET: Cliente
        public ActionResult Index()
        {
            List<Cliente> Clientes = new List<Cliente>();

            Clientes = dbCtx.Clientes.OrderBy(x => x.Apellidos).ToList();
            return View(Clientes);
        }

        // GET: Cliente/Details/5
        public ActionResult Details(int id)
        {
            Cliente cliente = dbCtx.Clientes.Find(id);

            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // GET: Cliente/Create
        public ActionResult Create()
        {
            
            return View();
        }

        // POST: Cliente/Create
        [HttpPost]
        public ActionResult Create(Cliente cliente)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Clientes.Add(cliente);
                        dbCtx.SaveChanges();
                    }
                    catch(DbEntityValidationException e)
                    {
                        foreach(var eve in e.EntityValidationErrors)
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

        // GET: Cliente/Edit/5
        public ActionResult Edit(int id)
        {
            Cliente cliente = dbCtx.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Edit/5
        [HttpPost]
        public ActionResult Edit(Cliente cliente)
        {
            try
            {
                // TODO: Add update logic here
                if (ModelState.IsValid)
                {
                    try
                    {
                        dbCtx.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
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

        // GET: Cliente/Delete/5
        public ActionResult Delete(int? id)
        {
            Cliente cliente = dbCtx.Clientes.Find(id);
            if (cliente == null)
            {
                return HttpNotFound();
            }
            return View(cliente);
        }

        // POST: Cliente/Delete/5
        [HttpPost]
        public ActionResult Delete(int id)
        {
            try
            {
                try
                {
                    Cliente cliente = dbCtx.Clientes.Find(id);
                    dbCtx.Clientes.Remove(cliente);
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
