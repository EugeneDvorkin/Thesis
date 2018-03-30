using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teplo.BusinessLayer.Interfaces;

namespace Teplo.BusinessLayer.Models
{
    public class SteamM1994ViewModel
    {
        public int ID_M { get; set; }
        public int Dp_M { get; set; }
        public int Dk_M { get; set; }
        public double Qk_M { get; set; }
        public double Q110_M { get; set; }
        public double Q145_M { get; set; }
        public double Q195_M { get; set; }
        public double Q245_M { get; set; }
        public double Q295_M { get; set; }
        public double Q345_M { get; set; }
        public double Q395_M { get; set; }
        public double Q445_M { get; set; }       
    }
}
