using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetTiendaZapatillasJPL.Models
{
    [Table("VENTAS")]
    public class Venta
    {
        [Key]
        [Column("IDVENTA")]
        public int IdVenta { get; set; }

        [Column("IDZAPATILLA")]
        public int IdZapatilla { get; set; }

        [Column("IDUSUARIO")]
        public int IdUsuario { get; set; }

        [Column("NUMEROCOMPROBANTE")]
        public string NumeroComprobante { get; set; }

        [Column("FECHA")]
        public DateTime Fecha { get; set; }

        [Column("IMPUESTO")]
        public int Impuesto { get; set; }

        [Column("TOTAL")]
        public int Total { get; set; }

        [Column("NOMBREZAPATILLA")]
        public string NombreZapatilla { get; set; }
    }
}
