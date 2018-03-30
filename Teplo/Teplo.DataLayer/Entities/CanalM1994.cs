using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teplo.DataLayer.Entities
{
    public class CanalM1994
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CM { get; set; }
        [Required]
        public int D_CM { get; set; }
        [Required]
        public double Q35_10_CM { get; set; }
        [Required]
        public double Q85_60_CM { get; set; }
        [Required]
        public double Q135_110_CM { get; set; }
        [Required]
        public double Q185_160_CM { get; set; }
        [Required]
        public double Q235_210_CM { get; set; }
        [Required]
        public double Q285_260_CM { get; set; }
        [Required]
        public double Q335_310_CM { get; set; }
        [Required]
        public double Q385_360_CM { get; set; }        
    }
}
