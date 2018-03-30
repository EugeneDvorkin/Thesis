using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;

namespace Teplo.AllCalcLogic
{
    public class ResClass
    { 
        public int T_C { get; set; }//температура конденсата
        public int T_S { get; set; }//температура пара
        public int L { get; set; }//длина учатка
        public double Q_C { get; set; }//тепловой поток от конденсата удельный
        public double Qres_S { get; set; }//тепловой поток от пара 
        public double Ql_S { get; set; }//удельный тепловой поток от пара
        public double Qres_C { get; set; } //тепловой поток от конденсата
        public int D_S { get; set; }//Диаметр паропровода
        public int D_C { get; set; }//Диаметр конденсатопровода
        public double Qh_y_S { get; set; }//Часовые среднегодовые нормативные тепловые потери паропровода
        public double Qh_y_C { get; set; }//Часовые среднегодовые нормативные тепловые потери конденсатопровода
        public string Note { get; set; }//примечание
    }
}
