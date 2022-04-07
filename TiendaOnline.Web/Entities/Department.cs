using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Entities
{
    public class Department
    {
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public ICollection<City>Cities { get; set; }//Llave foranea

        [DisplayName("Cities Number")]//NOS ARROJA EL MENSAJE CITIES NUMBER Y HACE CONTAEO DE LAS CIUDADES
        public int CitiesNumber => Cities == null ? 0 : Cities.Count;
    }
}
