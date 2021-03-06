using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace Credi_Gestion.Models
{
    public class Cliente
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage="El nombre del cliente es requerido")]
        public string NombreCliente { get; set; }

        [Required(ErrorMessage="El número de cedula es requerido")]
        [StringLength(100,ErrorMessage ="La {0} debe tener al menos {2} y máximo {1} caracteres",MinimumLength =3)]
        [Display(Name="Cédula")]
        public string Cedula { get; set; }

        [Required(ErrorMessage="La dirección  es requerida")]
        [StringLength(100,ErrorMessage ="La {0} debe tener al menos {2} y máximo {1} caracteres",MinimumLength =3)]
        [Display(Name="Cédula")]
        public string Direccion { get; set; }

        [Required(ErrorMessage="Debe ingresar el número de teléfono")]
        [Display(Name ="Teléfono")]
        public string Telefono { get; set; }

        [Required(ErrorMessage="Debe ingresar el monto del préstamo")]
        [Display(Name="Préstamo")]
        public decimal Prestamo { get; set; }

        [Required(ErrorMessage="Debe ingresar el saldo")]
        public decimal Saldo { get; set; }

        [Required(ErrorMessage="Debe seleccionar la fecha")]
            // guardar en la base de datos con fecha y hora
        [DataType(DataType.Date)]
        [Display(Name="Fecha del registro")]
        public DateTime FechaReg { get; set; }

        [Display(Name="Usuario que registró")]
        public string UsuarioRe { get; set; }
        


        

    }
}
