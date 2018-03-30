using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teplo.DataLayer.Entities
{
    public class SteamU1994
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_U { get; set; }
        [Required]
        public int Dp_U { get; set; }
        [Required]
        public int Dk_U { get; set; }
        [Required]
        public double Qk_U { get; set; }
        [Required]
        public double Q110_U { get; set; }
        [Required]
        public double Q145_U { get; set; }
        [Required]
        public double Q195_U { get; set; }
        [Required]
        public double Q245_U { get; set; }
        [Required]
        public double Q295_U { get; set; }
        [Required]
        public double Q345_U { get; set; }
        [Required]
        public double Q395_U { get; set; }
        [Required]
        public double Q445_U { get; set; }
    }
}
