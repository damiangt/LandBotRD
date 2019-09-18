using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandBotRD.Web.Data.Entities
{
    public class Cliente
    {
        public int Id { get; set; }


        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required]
        public string Identificacion { get; set; }



        [MaxLength(50, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required]
        public string Nombres { get; set; }


        [MaxLength(10)]
        [Required]
        public string Celular { get; set; }




        [MaxLength(20)]
        public string IdentificacionLinea { get; set; }




        [MaxLength(50)]
        public string NombresLinea { get; set; }




        [MaxLength(10)]
        public string CelularLinea { get; set; }




        [MaxLength(8)]
        public string HoraLinea { get; set; }






        public DateTime FechaRegistro { get; set; }




        [MaxLength(20)]
        public string Estado { get; set; }




        [MaxLength(500)]
        public string Observaciones { get; set; }

    }
}
