using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teplo.DataLayer.Entities
{
    public class RoomU1994
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_RU { get; set; }
        [Required]
        public int D_RU { get; set; }
        [Required]
        public double Q35_RU { get; set; }
        [Required]
        public double Q85_RU { get; set; }
        [Required]
        public double Q185_RU { get; set; }
        [Required]
        public double Q285_RU { get; set; }
        [Required]
        public double Q385_RU { get; set; }
    }
}
