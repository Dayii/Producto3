using System.ComponentModel.DataAnnotations;

namespace api2.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [Display(Name = "Nombre del Producto")]
        public string Nombre { get; set; }

        public double Precio { get; set; }

    }
}