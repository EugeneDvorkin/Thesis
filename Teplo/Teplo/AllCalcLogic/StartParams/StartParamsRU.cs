using Teplo.BusinessLayer.Models;

namespace Teplo.AllCalcLogic
{
    public class StartParamsRU
    {
        public int T_S { get; set; }
        public int T_E { get; set; }
        public int L { get; set; }
        public RoomU1994ViewModel D_U { get; set; }        
        public RoomU1994ViewModel DC_U { get; set; }
        public string Note { get; set; }
    }
}
