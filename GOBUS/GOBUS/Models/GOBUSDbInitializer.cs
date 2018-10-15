using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace GOBUS.Models
{
    public class GOBUSDbInitializer : CreateDatabaseIfNotExists<GOBUSContext>
    {

        protected override void Seed(GOBUSContext dbCtx)
        {
            #region Servicios
            List<Servicios> servicio = new List<Servicios>();
            servicio.Add(new Servicios()
            {
                NombreServicio = "Cambio de aceite",
                Descripcion = "Se necesita cambiar el aceite al carro",
                Costo = 150.90
            });

            servicio.Add(new Servicios()
            {
                NombreServicio = "Cambio de balatas",
                Descripcion = "Se neceita urgente un cambio de balatas al carro",
                Costo = 56.70
            });
            #endregion

            #region Clientes
            List<Clientes> cliente = new List<Clientes>();
            cliente.Add(new Clientes()
            {
                Nombre = "Abdeel Esau",
                Apellidos = "Martinez Moreno",
                Direccion = "ETzatlan #114 Noria Norte",
                Telefono = "818366453",
                Email = "mtzab6@gmail.com"

            });

            cliente.Add(new Clientes()
            {
                Nombre = "Imelda Abigail",
                Apellidos = "Garcia Segovia",
                Direccion = "San Juan #110 Col. San Martin",
                Telefono = "8291025071",
                Email = "imeldasegovia1@gmail.com"
            });
            #endregion

            #region Surcursales
            List<Sucursales> sucursale = new List<Sucursales>();
            sucursale.Add(new Sucursales()
            {
                Nombre = "AutoZone",
                Direcion = "Aaron Villarreal #220 Col. Miguel Hidalgo",
                Telefono = "8292861766",
                Encargado = "Sarahi Erasto"
            });

            sucursale.Add(new Sucursales()
            {
                Nombre = "Valentines",
                Direcion = "San Antonio #100 Col. San Martin",
                Telefono = "8292860516",
                Encargado = "Samuel Arriaga"
            });
            #endregion

            #region Citas
            List<Citas> cita = new List<Citas>();
            cita.Add(new Citas()
            {
                PlacaNumero = "ABCDE12345",
                FechaCita = DateTime.Now
            });
            #endregion
        }

    }
}