using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class VehiculosModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public string NoChasis { get; set; }
        public string NoPlaca { get; set; }
        public string TipoVehiculo { get; set; }
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoCombustible { get; set; }
        public string Estado { get; set; }
    }
}
