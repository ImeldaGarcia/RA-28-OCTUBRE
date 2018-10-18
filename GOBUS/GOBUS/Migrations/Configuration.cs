namespace GOBUS.Migrations
{
    using GOBUS.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Data.Entity.Validation;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GOBUS.Models.GOBUSContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GOBUS.Models.GOBUSContext dbCtx)
        {
            //try
            //{

            //    #region Servicios
            //    List<Servicio> servicios = new List<Servicio>();
            //    servicios.Add(new Servicio()
            //    {
            //        NombreServicio = "Cambio de aceite",
            //        Descripcion = "Se necesita cambiar el aceite al carro",
            //        Costo = 150.90
            //    });

            //    servicios.Add(new Servicio()
            //    {
            //        NombreServicio = "Cambio de balatas",
            //        Descripcion = "Se neceita urgente un cambio de balatas al carro",
            //        Costo = 56.70
            //    });

            //    dbCtx.Servicios.AddRange(servicios);
            //    dbCtx.SaveChanges();
            //    #endregion

            //    #region Clientes
            //    List<Cliente> clientes = new List<Cliente>();
            //    clientes.Add(new Cliente()
            //    {
            //        Nombre = "Abdeel Esau",
            //        Apellidos = "Martinez Moreno",
            //        Direccion = "ETzatlan #114 Noria Norte",
            //        Telefono = "818366453",
            //        Email = "mtzab6@gmail.com"

            //    });

            //    clientes.Add(new Cliente()
            //    {
            //        Nombre = "Imelda Abigail",
            //        Apellidos = "Garcia Segovia",
            //        Direccion = "San Juan #110 Col. San Martin",
            //        Telefono = "8291025071",
            //        Email = "imeldasegovia1@gmail.com"
            //    });

            //    dbCtx.Clientes.AddRange(clientes);
            //    dbCtx.SaveChanges();
            //    #endregion

            //    #region Surcursales
            //    List<Sucursale> sucursales = new List<Sucursale>();
            //    sucursales.Add(new Sucursale()
            //    {
            //        Nombre = "AutoZone",
            //        Direcion = "Aaron Villarreal #220 Col. Miguel Hidalgo",
            //        Telefono = "8292861766",
            //        Encargado = "Sarahi Erasto"
            //    });

            //    sucursales.Add(new Sucursale()
            //    {
            //        Nombre = "Valentines",
            //        Direcion = "San Antonio #100 Col. San Martin",
            //        Telefono = "8292860516",
            //        Encargado = "Samuel Arriaga"
            //    });

            //    dbCtx.Sucursales.AddRange(sucursales);
            //    dbCtx.SaveChanges();
            //    #endregion

            //    #region Citas
            //    List<Cita> citas = new List<Cita>();
            //    citas.Add(new Cita()
            //    {
            //        PlacaNumero = "ABCDE12345",
            //        FechaCita = DateTime.Now,
            //        IdCliente = 1,
            //        IdSucursal = 1
            //    });

            //    citas.Add(new Cita()
            //    {
            //        PlacaNumero = "QRSTU54321",
            //        FechaCita = DateTime.Now,
            //        IdCliente = 2,
            //        IdSucursal = 2
            //    });

            //    dbCtx.Citas.AddRange(citas);
            //    dbCtx.SaveChanges();
            //    #endregion

            //}
            //catch (DbEntityValidationException dbEx)
            //{
            //    foreach (DbEntityValidationResult entityErr in dbEx.EntityValidationErrors)
            //    {
            //        foreach (DbValidationError error in entityErr.ValidationErrors)
            //        {
            //            Console.WriteLine("Error Property Name {0} : Error Message: {1}",
            //                                error.PropertyName, error.ErrorMessage);
            //        }
            //    }
            //}
        }
    }
}
