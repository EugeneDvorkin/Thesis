using Teplo.BusinessLayer.Models;
using System.Windows.Forms;
using Teplo.AllCalcLogic;


namespace Teplo.Calculation
{
    public class SteamCalculation : CalculationParams
    {
        public ResClass SteamCalcM(int t_s, int t_e, int l, SteamM1994ViewModel d, bool check, string note)
        {

            DT_S = t_s - t_e;
            if ((DT_S >= 110) && (DT_S < 145))
            {
                Q_cU = (d.Q110_M + ((d.Q145_M - d.Q110_M) * (DT_S - 110) / (145 - 110)));
            }
            else if ((DT_S >= 145) && (DT_S < 195))
            {
                Q_cU = (d.Q145_M + ((d.Q195_M - d.Q145_M) * (DT_S - 145) / (195 - 145)));
            }
            else if ((DT_S >= 195) && (DT_S < 245))
            {
                Q_cU = (d.Q195_M + ((d.Q245_M - d.Q195_M) * (DT_S - 195) / (245 - 195)));
            }
            else if ((DT_S >= 245) && (DT_S < 295))
            {
                Q_cU = (d.Q245_M + ((d.Q295_M - d.Q245_M) * (DT_S - 245) / (295 - 245)));
            }
            else if ((DT_S >= 295) && (DT_S <= 345))
            {
                Q_cU = (d.Q295_M + ((d.Q345_M - d.Q295_M) * (DT_S - 295) / (345 - 295)));
            }
            else if ((DT_S < 110) || (DT_S > 345))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            T_c = (check == true) ? 0 : 100;
            Q_c = (check == true) ? 0 : d.Qk_M;

            Qres_s = Q_cU * l;
            Qres_c = Q_c * l;
            Qh_y_s = Qres_s * 1.15 * 3.6;
            Qh_y_c = Qres_c * 1.15 * 3.6;

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_cU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.Dp_M,
                D_C = d.Dk_M,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public ResClass SteamCalcU(int t_s, int t_e, int l, SteamU1994ViewModel d, bool check, string note)
        {
            DT_S = t_s - t_e;
            if ((DT_S >= 110) && (DT_S < 145))
            {
                Q_sU = (d.Q110_U + ((d.Q145_U - d.Q110_U) * (DT_S - 110) / (145 - 110)));
            }
            else if ((DT_S >= 145) && (DT_S < 195))
            {
                Q_sU = (d.Q145_U + ((d.Q195_U - d.Q145_U) * (DT_S - 145) / (195 - 145)));
            }
            else if ((DT_S >= 195) && (DT_S < 245))
            {
                Q_sU = (d.Q195_U + ((d.Q245_U - d.Q195_U) * (DT_S - 195) / (245 - 195)));
            }
            else if ((DT_S >= 245) && (DT_S < 295))
            {
                Q_sU = (d.Q245_U + ((d.Q295_U - d.Q245_U) * (DT_S - 245) / (295 - 245)));
            }
            else if ((DT_S >= 295) && (DT_S < 345))
            {
                Q_sU = (d.Q295_U + ((d.Q345_U - d.Q295_U) * (DT_S - 295) / (345 - 295)));
            }
            else if ((DT_S >= 345) && (DT_S < 395))
            {
                Q_sU = (d.Q345_U + ((d.Q395_U - d.Q345_U) * (DT_S - 345) / (395 - 345)));
            }
            else if ((DT_S >= 395) && (DT_S <= 445))
            {
                Q_sU = (d.Q395_U + ((d.Q445_U - d.Q395_U) * (DT_S - 395) / (445 - 395)));
            }
            else if ((DT_S < 110) || (DT_S > 445))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            T_c = (check == true) ? 0 : 100;
            Q_c = (check == true) ? 0 : d.Qk_U;

            Qres_s = Q_sU * l;
            Qres_c = Q_c * l;
            Qh_y_s = Qres_s * 1.15 * 3.6;
            Qh_y_c = Qres_c * 1.15 * 3.6;

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_sU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.Dp_U,
                D_C = d.Dk_U,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public ResClass SteamCalcU_C(int t_s, int t_e, int l, CanalU1994ViewModel d, CanalU1994ViewModel dc, string note)
        {

            DT_S = t_s - 40;
            if ((DT_S >= 10) && (DT_S < 60))
            {
                Q_cU = (d.Q10_CU + ((d.Q60_CU - d.Q10_CU) * (DT_S - 10) / (60 - 10)));
            }
            else if ((DT_S >= 60) && (DT_S < 160))
            {
                Q_cU = (d.Q60_CU + ((d.Q160_CU - d.Q60_CU) * (DT_S - 60) / (160 - 60)));
            }
            else if ((DT_S >= 160) && (DT_S < 260))
            {
                Q_cU = (d.Q160_CU + ((d.Q260_CU - d.Q160_CU) * (DT_S - 160) / (260 - 160)));
            }
            else if ((DT_S >= 260) && (DT_S <= 360))
            {
                Q_cU = (d.Q260_CU + ((d.Q360_CU - d.Q260_CU) * (DT_S - 260) / (360 - 260)));
            }
            else if ((DT_S < 10) || (DT_S > 360))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            if (t_e == 0)
            {
                T_c = 0;
                Q_c = 0;
            }
            else
            {
                DT_E = t_e - 40;
                if ((DT_E >= 10) && (DT_E < 60))
                {
                    Q_c = (dc.Q10_CU + ((dc.Q60_CU - dc.Q10_CU) * (DT_S - 10) / (60 - 10)));
                }
                else if ((DT_E >= 60) && (DT_E < 160))
                {
                    Q_c = (dc.Q60_CU + ((dc.Q160_CU - dc.Q60_CU) * (DT_S - 60) / (160 - 60)));
                }
                else if ((DT_E >= 160) && (DT_E < 260))
                {
                    Q_c = (dc.Q160_CU + ((dc.Q260_CU - dc.Q160_CU) * (DT_S - 160) / (260 - 160)));
                }
                else if ((DT_E >= 260) && (DT_E <= 360))
                {
                    Q_c = (dc.Q260_CU + ((dc.Q360_CU - dc.Q260_CU) * (DT_S - 260) / (360 - 260)));
                }
                else if ((DT_E < 10) || (DT_E > 360))
                {
                    MessageBox.Show("Разность введенных температур для конденсатопровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                    ResClass temp1 = new ResClass
                    {
                        T_S = 0,
                        T_C = 0,
                        L = 0,
                        Ql_S = 0,
                        Qres_S = 0,
                        Q_C = 0,
                        Qres_C = 0,
                        D_S = 0,
                        D_C = 0,
                        Qh_y_S = 0,
                        Qh_y_C = 0,
                        Note = ""
                    };
                    return temp1;
                }
            }
            Qres_s = Q_cU * l;
            Qres_c = Q_c * l;
            if (d.D_CU < 150)
            {
                Qh_y_s = Qres_s * 1.2 * 3.6;
            }
            else
            {
                Qh_y_s = Qres_s * 1.15 * 3.6;
            }
            if (dc.D_CU < 150)
            {
                Qh_y_c = Qres_c * 1.2 * 3.6;
            }
            else
            {
                Qh_y_c = Qres_c * 1.15 * 3.6;
            }

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_cU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.D_CU,
                D_C = dc.D_CU,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public ResClass SteamCalcU_R(int t_s, int t_e, int l, RoomU1994ViewModel d, RoomU1994ViewModel dc, string note)
        {

            DT_S = t_s - 15;
            if ((DT_S >= 35) && (DT_S < 85))
            {
                Q_cU = (d.Q35_RU + ((d.Q85_RU - d.Q35_RU) * (DT_S - 35) / (85 - 35)));
            }
            else if ((DT_S >= 85) && (DT_S < 185))
            {
                Q_cU = (d.Q85_RU + ((d.Q185_RU - d.Q85_RU) * (DT_S - 85) / (185 - 85)));
            }
            else if ((DT_S >= 185) && (DT_S < 285))
            {
                Q_cU = (d.Q185_RU + ((d.Q285_RU - d.Q185_RU) * (DT_S - 185) / (285 - 185)));
            }
            else if ((DT_S >= 285) && (DT_S <= 385))
            {
                Q_cU = (d.Q285_RU + ((d.Q385_RU - d.Q285_RU) * (DT_S - 285) / (385 - 285)));
            }
            else if ((DT_S < 10) || (DT_S > 360))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            if (t_e == 0)
            {
                T_c = 0;
                Q_c = 0;
            }
            else
            {
                DT_E = t_e - 15;
                if ((DT_E >= 35) && (DT_E < 85))
                {
                    Q_c = (dc.Q35_RU + ((dc.Q85_RU - dc.Q35_RU) * (DT_E - 35) / (85 - 35)));
                }
                else if ((DT_E >= 85) && (DT_E < 185))
                {
                    Q_c = (dc.Q85_RU + ((dc.Q185_RU - dc.Q85_RU) * (DT_E - 85) / (185 - 85)));
                }
                else if ((DT_E >= 185) && (DT_E < 285))
                {
                    Q_c = (dc.Q185_RU + ((dc.Q285_RU - dc.Q185_RU) * (DT_E - 185) / (285 - 185)));
                }
                else if ((DT_E >= 285) && (DT_E <= 385))
                {
                    Q_c = (dc.Q285_RU + ((dc.Q385_RU - dc.Q285_RU) * (DT_E - 285) / (385 - 285)));
                }
                else if ((DT_E < 10) || (DT_E > 360))
                {
                    MessageBox.Show("Разность введенных температур для конденсатопровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                    ResClass temp1 = new ResClass
                    {
                        T_S = 0,
                        T_C = 0,
                        L = 0,
                        Ql_S = 0,
                        Qres_S = 0,
                        Q_C = 0,
                        Qres_C = 0,
                        D_S = 0,
                        D_C = 0,
                        Qh_y_S = 0,
                        Qh_y_C = 0,
                        Note = ""
                    };
                    return temp1;
                }
            }
            Qres_s = Q_cU * l;
            Qres_c = Q_c * l;
            if (d.D_RU < 150)
            {
                Qh_y_s = Qres_s * 1.2 * 3.6;
            }
            else
            {
                Qh_y_s = Qres_s * 1.15 * 3.6;
            }
            if (dc.D_RU < 150)
            {
                Qh_y_c = Qres_c * 1.2 * 3.6;
            }
            else
            {
                Qh_y_c = Qres_c * 1.15 * 3.6;
            }

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_cU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.D_RU,
                D_C = dc.D_RU,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public ResClass SteamCalcM_R(int t_s, int t_e, int l, CanalM1994ViewModel d, CanalM1994ViewModel dc, string note)
        {

            DT_S = t_s - 15;
            if ((DT_S >= 35) && (DT_S < 85))
            {
                Q_cU = (d.Q35_10_CM + ((d.Q85_60_CM - d.Q35_10_CM) * (DT_S - 35) / (85 - 35)));
            }
            else if ((DT_S >= 85) && (DT_S < 135))
            {
                Q_cU = (d.Q85_60_CM + ((d.Q135_110_CM - d.Q85_60_CM) * (DT_S - 85) / (135 - 85)));
            }
            else if ((DT_S >= 135) && (DT_S < 185))
            {
                Q_cU = (d.Q135_110_CM + ((d.Q185_160_CM - d.Q135_110_CM) * (DT_S - 135) / (185 - 135)));
            }
            else if ((DT_S >= 185) && (DT_S < 235))
            {
                Q_cU = (d.Q185_160_CM + ((d.Q235_210_CM - d.Q185_160_CM) * (DT_S - 185) / (235 - 185)));
            }
            else if ((DT_S >= 235) && (DT_S < 285))
            {
                Q_cU = (d.Q235_210_CM + ((d.Q285_260_CM - d.Q235_210_CM) * (DT_S - 235) / (285 - 235)));
            }
            else if ((DT_S >= 285) && (DT_S < 335))
            {
                Q_cU = (d.Q285_260_CM + ((d.Q335_310_CM - d.Q285_260_CM) * (DT_S - 285) / (335 - 285)));
            }
            else if ((DT_S >= 335) && (DT_S <= 385))
            {
                Q_cU = (d.Q335_310_CM + ((d.Q385_360_CM - d.Q335_310_CM) * (DT_S - 335) / (385 - 335)));
            }
            else if ((DT_S < 35) || (DT_S > 385))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            if (t_e == 0)
            {
                T_c = 0;
                Q_c = 0;
            }
            else
            {
                DT_E = t_e - 15;
                if ((DT_E >= 35) && (DT_E < 85))
                {
                    Q_c = (dc.Q35_10_CM + ((dc.Q85_60_CM - dc.Q35_10_CM) * (DT_S - 35) / (85 - 35)));
                }
                else if ((DT_E >= 85) && (DT_E < 185))
                {
                    Q_c = (dc.Q85_60_CM + ((dc.Q185_160_CM - dc.Q85_60_CM) * (DT_S - 85) / (185 - 85)));
                }
                else if ((DT_E >= 185) && (DT_E < 235))
                {
                    Q_c = (dc.Q185_160_CM + ((dc.Q235_210_CM - dc.Q185_160_CM) * (DT_S - 185) / (235 - 185)));
                }
                else if ((DT_E >= 235) && (DT_E < 285))
                {
                    Q_c = (dc.Q235_210_CM + ((dc.Q285_260_CM - dc.Q235_210_CM) * (DT_S - 235) / (285 - 235)));
                }
                else if ((DT_E >= 285) && (DT_E < 335))
                {
                    Q_c = (dc.Q285_260_CM + ((dc.Q335_310_CM - dc.Q285_260_CM) * (DT_S - 285) / (335 - 285)));
                }
                else if ((DT_E >= 335) && (DT_E <= 385))
                {
                    Q_c = (dc.Q335_310_CM + ((dc.Q385_360_CM - dc.Q335_310_CM) * (DT_S - 335) / (385 - 335)));
                }
                else if ((DT_E < 35) || (DT_E > 385))
                {
                    MessageBox.Show("Разность введенных температур для конденсатопровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                    ResClass temp1 = new ResClass
                    {
                        T_S = 0,
                        T_C = 0,
                        L = 0,
                        Ql_S = 0,
                        Qres_S = 0,
                        Q_C = 0,
                        Qres_C = 0,
                        D_S = 0,
                        D_C = 0,
                        Qh_y_S = 0,
                        Qh_y_C = 0,
                        Note = ""
                    };
                    return temp1;
                }
            }
            Qres_s = Q_cU * l;
            Qres_c = Q_c * l;
            if (d.D_CM < 150)
            {
                Qh_y_s = Qres_s * 1.2 * 3.6;
            }
            else
            {
                Qh_y_s = Qres_s * 1.15 * 3.6;
            }
            if (dc.D_CM < 150)
            {
                Qh_y_c = Qres_c * 1.2 * 3.6;
            }
            else
            {
                Qh_y_c = Qres_c * 1.15 * 3.6;
            }

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_cU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.D_CM,
                D_C = dc.D_CM,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public ResClass SteamCalcM_С(int t_s, int t_e, int l, CanalM1994ViewModel d, CanalM1994ViewModel dc, string note)
        {

            DT_S = t_s - 40;
            if ((DT_S >= 10) && (DT_S < 60))
            {
                Q_cU = (d.Q35_10_CM + ((d.Q85_60_CM - d.Q35_10_CM) * (DT_S - 10) / (60 - 10)));
            }
            else if ((DT_S >= 60) && (DT_S < 110))
            {
                Q_cU = (d.Q85_60_CM + ((d.Q185_160_CM - d.Q85_60_CM) * (DT_S - 60) / (110 - 60)));
            }
            else if ((DT_S >= 110) && (DT_S < 160))
            {
                Q_cU = (d.Q135_110_CM + ((d.Q185_160_CM - d.Q135_110_CM) * (DT_S - 110) / (160 - 110)));
            }
            else if ((DT_S >= 160) && (DT_S < 210))
            {
                Q_cU = (d.Q185_160_CM + ((d.Q235_210_CM - d.Q185_160_CM) * (DT_S - 160) / (210 - 160)));
            }
            else if ((DT_S >= 210) && (DT_S < 260))
            {
                Q_cU = (d.Q235_210_CM + ((d.Q285_260_CM - d.Q235_210_CM) * (DT_S - 210) / (260 - 210)));
            }
            else if ((DT_S >= 260) && (DT_S < 310))
            {
                Q_cU = (d.Q285_260_CM + ((d.Q335_310_CM - d.Q285_260_CM) * (DT_S - 260) / (335 - 310)));
            }
            else if ((DT_S >= 310) && (DT_S <= 360))
            {
                Q_cU = (d.Q335_310_CM + ((d.Q385_360_CM - d.Q335_310_CM) * (DT_S - 310) / (360 - 310)));
            }
            else if ((DT_S < 10) || (DT_S > 360))
            {
                MessageBox.Show("Разность введенных температур для паропровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                ResClass temp1 = new ResClass
                {
                    T_S = 0,
                    T_C = 0,
                    L = 0,
                    Ql_S = 0,
                    Qres_S = 0,
                    Q_C = 0,
                    Qres_C = 0,
                    D_S = 0,
                    D_C = 0,
                    Qh_y_S = 0,
                    Qh_y_C = 0,
                    Note = ""
                };
                return temp1;
            }

            if (t_e == 0)
            {
                T_c = 0;
                Q_c = 0;
            }
            else
            {
                DT_E = t_e - 40;
                if ((DT_S >= 10) && (DT_S < 60))
                {
                    Q_c = (dc.Q35_10_CM + ((dc.Q85_60_CM - dc.Q35_10_CM) * (DT_S - 10) / (60 - 10)));
                }
                else if ((DT_S >= 60) && (DT_S < 110))
                {
                    Q_c = (dc.Q85_60_CM + ((dc.Q185_160_CM - dc.Q85_60_CM) * (DT_S - 60) / (110 - 60)));
                }
                else if ((DT_S >= 110) && (DT_S < 160))
                {
                    Q_c = (dc.Q135_110_CM + ((dc.Q185_160_CM - dc.Q135_110_CM) * (DT_S - 110) / (160 - 110)));
                }
                else if ((DT_S >= 160) && (DT_S < 210))
                {
                    Q_c = (dc.Q185_160_CM + ((dc.Q235_210_CM - dc.Q185_160_CM) * (DT_S - 160) / (210 - 160)));
                }
                else if ((DT_S >= 210) && (DT_S < 260))
                {
                    Q_c = (dc.Q235_210_CM + ((dc.Q285_260_CM - dc.Q235_210_CM) * (DT_S - 210) / (260 - 210)));
                }
                else if ((DT_S >= 260) && (DT_S < 310))
                {
                    Q_c = (dc.Q285_260_CM + ((dc.Q335_310_CM - dc.Q285_260_CM) * (DT_S - 260) / (335 - 310)));
                }
                else if ((DT_S >= 310) && (DT_S <= 360))
                {
                    Q_c = (dc.Q335_310_CM + ((dc.Q385_360_CM - dc.Q335_310_CM) * (DT_S - 310) / (360 - 310)));
                }
                else if ((DT_E < 10) || (DT_E > 360))
                {
                    MessageBox.Show("Разность введенных температур для конденсатопровода не подходит ни под один промежуток. Проверьте введенные данные", "Ошибка ввода данных", MessageBoxButtons.OK);
                    ResClass temp1 = new ResClass
                    {
                        T_S = 0,
                        T_C = 0,
                        L = 0,
                        Ql_S = 0,
                        Qres_S = 0,
                        Q_C = 0,
                        Qres_C = 0,
                        D_S = 0,
                        D_C = 0,
                        Qh_y_S = 0,
                        Qh_y_C = 0,
                        Note = ""
                    };
                    return temp1;
                }
            }
            Qres_s = Q_cU * l;
            Qres_c = Q_c * l;
            if (d.D_CM < 150)
            {
                Qh_y_s = Qres_s * 1.2 * 3.6;
            }
            else
            {
                Qh_y_s = Qres_s * 1.15 * 3.6;
            }
            if (dc.D_CM < 150)
            {
                Qh_y_c = Qres_c * 1.2 * 3.6;
            }
            else
            {
                Qh_y_c = Qres_c * 1.15 * 3.6;
            }

            ResClass temp = new ResClass
            {
                T_S = t_s,
                T_C = T_c,
                L = l,
                Ql_S = Q_cU,
                Qres_S = Qres_s,
                Q_C = Q_c,
                Qres_C = Qres_c,
                D_S = d.D_CM,
                D_C = dc.D_CM,
                Qh_y_S = Qh_y_s,
                Qh_y_C = Qh_y_c,
                Note = note
            };
            return temp;
        }

        public void Check(bool check, SteamM1994ViewModel D)
        {
            T_c = (check != true) ? 0 : 100;
            Q_c = (check != true) ? 0 : D.Qk_M;
        }
    }
}
