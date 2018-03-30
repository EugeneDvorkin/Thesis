using Teplo.BusinessLayer.Models;

namespace Teplo.AllCalcLogic
{
    public class StartParamsCU
    {
        public int T_S { get; set; }
        public int T_E { get; set; }
        public int L { get; set; }
        public CanalU1994ViewModel D_U { get; set; }
        //public SteamU1994ViewModel D_U { get; set; }
        public CanalU1994ViewModel DC_U { get; set; }
        public string Note { get; set; }
    }
}
