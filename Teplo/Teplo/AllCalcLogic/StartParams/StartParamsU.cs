using System;
using System.Collections.Generic;
using System.Linq;
using Teplo.BusinessLayer.Models;

namespace Teplo.AllCalcLogic
{
    public class StartParamsU
    {
        public int T_S { get; set; }
        public int T_E { get; set; }
        public int L { get; set; }
        //public SteamM1994ViewModel D_M { get; set; }
        public SteamU1994ViewModel D_U { get; set; }
        public bool Check { get; set; }
        public string Note { get; set; }
    }
}
