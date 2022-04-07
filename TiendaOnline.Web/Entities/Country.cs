using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Entities
{
    public class Country
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public ICollection<Department> Departments { get; set; }//Llave foranea

        [DisplayName("Departments Number")]//NOS ARROJA EL MENSAJE CITIES NUMBER Y HACE CONTAEO DE LAS CIUDADES
        public int DepartmentsNumber => Departments == null ? 0 : Departments.Count;
    }
}
