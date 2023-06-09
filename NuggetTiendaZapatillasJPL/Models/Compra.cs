﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetTiendaZapatillasJPL.Models
{
    [Table("COMPRAS")]
    public class Compra
    {
		[Key]
		[Column("NUMEROTARJETA")]
		public string NumeroTarjeta { get; set; }

		[Column("NOMBRE")]
		public string Nombre { get; set; }

		[Column("APELLIDOS")]
		public string Apellidos { get; set; }

		[Column("DIRECCION")]
		public string Direccion { get; set; }

		[Column("EMAIL")]
		public string Email { get; set; }

		[Column("NUMEROTELEFONO")]
		public string NumeroTelefono { get; set; }

		[Column("CODIGOPOSTAL")]
		public int CodigoPostal { get; set; }
	}
}
