using Teplo.BusinessLayer.Models;

namespace Teplo.AllCalcLogic
{
    public class StartParams
    {
        public int T_S { get; set; }
        public int T_E { get; set; }
        public int L { get; set; }
        public SteamM1994ViewModel D_M { get; set; }
        public SteamU1994ViewModel D_U { get; set; }
        public bool Check { get; set; }
    }
}
