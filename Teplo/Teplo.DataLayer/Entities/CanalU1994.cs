using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teplo.DataLayer.Entities
{
    public class CanalU1994
    {
        [Key, Required, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID_CU { get; set; }
        [Required]
        public int D_CU { get; set; }
        [Required]
        public double Q10_CU { get; set; }
        [Required]
        public double Q60_CU { get; set; }
        [Required]
        public double Q160_CU { get; set; }
        [Required]
        public double Q260_CU { get; set; }
        [Required]
        public double Q360_CU { get; set; }
    }
}
