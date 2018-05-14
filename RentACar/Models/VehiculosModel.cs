using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RentACar.Models
{
    class VehiculosModel
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        [DisplayName("Numero Chasis")]
        public string NoChasis { get; set; }
        [DisplayName("Numero Placa")]
        public string NoPlaca { get; set; }
        [DisplayName("Numero Motor")]
        public string NoMotor { get; set; }
        public string TipoVehiculo { get; set; }
        public string  Marca { get; set; }
        public string Modelo { get; set; }
        public string TipoCombustible { get; set; }
        public string Estado { get; set; }
    }
}
