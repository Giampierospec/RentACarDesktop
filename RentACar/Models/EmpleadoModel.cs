using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class EmpleadoModel
    {
        public string Nombre { get; set; }
        public string Cedula { get; set; }
        [DisplayName("Tanda Labor")]
        public string Tanda { get; set; }
        [DisplayName("Porciento Comision")]
        public decimal? Comision { get; set; }
        [DisplayName("Fecha Ingreso")]
        public DateTime? FechaIngreso { get; set; }
        public string Estado { get; set; }
    }
}
