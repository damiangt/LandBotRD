using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace LandBotRD.Web.Data.Entities
{
    public class User : IdentityUser
    {
        [Display(Name = "Nombres")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener más de {1} catacteres.")]
        [Required(ErrorMessage = "El campo {0} es mandatorio.")]
        public string FirstName { get; set; }

        [Display(Name = "Apellidos")]
        [MaxLength(50, ErrorMessage = "El campo {0} no puede contener más de {1} catacteres.")]
        [Required(ErrorMessage = "El campo {0} es mandatorio.")]
        public string LastName { get; set; }

        public string FullName => $"{FirstName} {LastName}";
    }
}
