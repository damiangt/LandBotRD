using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LandBotRD.Web.Data.Entities
{
    public class Estado
    {

        public int Id { get; set; }


        [MaxLength(20, ErrorMessage = "El campo {0} no puede tener mas de {1} caracteres")]
        [Required]
        public string Descripcion { get; set; }




    }
}
