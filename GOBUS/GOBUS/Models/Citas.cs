using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace GOBUS.Models
{
    public class Citas
    {
        [Key]
        [Required (ErrorMessage = "Ingrese el campo Id")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Ingrese el campo PlacaNumero")]
        [StringLength (10, ErrorMessage = ("La cantidad maxima de caracteres es de 10"))]
        public String PlacaNumero { get; set; }

        [Required(ErrorMessage = "Ingrese el campo FechaCita")]
        [StringLength(8, ErrorMessage = ("La cantidad maxima de caracteres es de 8"))]
        public DateTime FechaCita { get; set; }

        [ForeignKey ("Clientes")]
        [Required(ErrorMessage = "Ingrese el campo IdCliente")]
        public int IdCliente { get; set; }
        public Clientes Clientes { get; set; }

        [ForeignKey ("Sucursales")]
        [Required(ErrorMessage = "Ingrese el campo IdSucursal")]
        public int IdSucursal { get; set; }
        public Sucursales Sucursales { get; set; }
    }
}