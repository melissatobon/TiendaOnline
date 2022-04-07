using System.ComponentModel.DataAnnotations;

namespace TiendaOnline.Web.Entities
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
    }
}
