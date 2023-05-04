using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NuggetTiendaZapatillasJPL.Models
{
    public class ZapatillaCategoria
    {
        public List<VistaZapatillasCategoria> ZapatillasBasket { get; set; }
        public List<VistaZapatillasCategoria> ZapatillasFutbol { get; set; }
        public List<VistaZapatillasCategoria> ZapatillasSkate { get; set; }
        public List<VistaZapatillasCategoria> ZapatillasPremium { get; set; }
        
    }
}
