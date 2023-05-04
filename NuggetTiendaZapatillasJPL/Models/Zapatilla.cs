using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetTiendaZapatillasJPL.Models
{
    [Table("ZAPATILLAS")]
    public class Zapatilla
    {
        [Key]
        [Column("IDZAPATILLA")]
        public int IdZapatilla { get; set; }

        [Column("IDCATEGORIA")]
        public int IdCategoria { get; set; }

        [Column("NOMBRE")]
        public string Nombre { get; set; }

        [Column("TALLA")]
        public decimal Talla { get; set; }

        [Column("UNIDADESTOCK")]
        public int UnidadesStock { get; set; }

        [Column("DESCRIPCION")]
        public string Descripcion { get; set; }

        [Column("IMAGEN")]
        public string Imagen { get; set; }

        [Column("PRECIO")]
        public decimal Precio { get; set; }
    }
}
