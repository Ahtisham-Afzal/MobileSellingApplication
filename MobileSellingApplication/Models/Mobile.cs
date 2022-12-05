using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MobileSellingApplication.Models
{
    public class Mobile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Url { get; set; }
        [Required]
        public int Price { get; set; }
        [ForeignKey("MobileManufacturer")]
        public int ManufacturerID { get; set; }
        public virtual Manufacturer MobileManufacturer { get; set; }
    }
}
