using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Teplo.BusinessLayer.Models;

namespace Teplo.Calculation
{
    public class CalculationParams
    {
        //protected int T_S { get; set; }//должна была быть температура пара, но упростил
        //protected int T_E { get; set; }//должна была быть температура конденсата/среды, но упростил        
        protected int DT_S { get; set; }//разность температур
        protected int DT_E { get; set; }//разность температур
        protected double Q_cU { get; set; }//тепловой поток табличный от пара
        protected double Q_sU { get; set; }
        //public double Q_E { get; set; }//тепловой поток от среды должен быть такбличный, но не нужен
        protected double Q_c { get; set; }//тепловой поток конденсата табличный
        //protected int L { get; set; }//длина учатка
        //protected SteamM1994ViewModel d { get; set; }//передаваемый объект с уровня представления, строка из таблицы, выбранный элемент в комбобоксе
        protected int T_c { get; set; }//температура конденсата
        protected double Qres_c { get; set; }//тепловой поток от конденсата
        protected double Qres_s { get; set; }//тепловой поток от пара 
        protected double Qh_y_s { get; set; }//Часовые среднегодовые нормативные тепловые потери паропровода
        protected double Qh_y_c { get; set; }//Часовые среднегодовые нормативные тепловые потери конденсатопровода
        //protected bool Check { get; set; }
        //protected double[] Result_Q_S;//результирующая коллекция с тепловым потоком от пара. Перенес на уровень представления в класс ResClass
    }
}
