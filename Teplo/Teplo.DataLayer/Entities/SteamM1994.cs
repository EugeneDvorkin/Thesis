using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teplo.DataLayer.Entities
{
    public class SteamM1994
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]     
        public int ID_M { get; set; }
        [Required]
        public int Dp_M { get; set; }
        [Required]
        public int Dk_M { get; set; }
        [Required]
        public double Qk_M { get; set; }
        [Required]
        public double Q110_M { get; set; }
        [Required]
        public double Q145_M { get; set; }
        [Required]
        public double Q195_M { get; set; }
        [Required]
        public double Q245_M { get; set; }
        [Required]
        public double Q295_M { get; set; }
        [Required]
        public double Q345_M { get; set; }
        [Required]
        public double Q395_M { get; set; }
        [Required]
        public double Q445_M { get; set; }
    }
}
