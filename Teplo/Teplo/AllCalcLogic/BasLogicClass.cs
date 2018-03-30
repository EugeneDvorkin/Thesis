using System.Collections.ObjectModel;
using Teplo.Command;
using Teplo.Calculation;

namespace Teplo.AllCalcLogic
{
    public class BasLogicClass : SteamCalculation
    {        
        private RelayCommand calcCommandM = null;
        private RelayCommand calcCommandU = null;
        private RelayCommand deleteCommand = null ;
        private RelayCommand calcCommandCU = null;
        private RelayCommand calcCommandRU = null;
        private RelayCommand calcCommandCM = null;
        private RelayCommand calcCommandRM = null;
        private RelayCommand excelImport = null;
        //private bool CanDelete(ResClass resClass) => resClass != null;
        public StartParamsM StartParamsM = new StartParamsM();
        public StartParamsU StartParamsU = new StartParamsU();
        public StartParamsCU StartParamsCU = new StartParamsCU();
        public StartParamsRU StartParamsRU = new StartParamsRU();
        public StartparamsCM StartparamsCM = new StartparamsCM();
        public StartParamsRM StartParamsRM = new StartParamsRM();
        private ExcelLogic ExcelLogic = new ExcelLogic();
        public ObservableCollection<ResClass> resClass = new ObservableCollection<ResClass>();
        public ResClass select = new ResClass();

        public RelayCommand CalcCommandM
        {
            get
            {
                return calcCommandM ??
                    (calcCommandM = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcM(StartParamsM.T_S, StartParamsM.T_E, StartParamsM.L, StartParamsM.D_M, StartParamsM.Check, StartParamsM.Note));
                    }));
            }
        }        

        public RelayCommand CalcCommandU
        {
            get
            {
                return calcCommandU ??
                    (calcCommandU = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcU(StartParamsU.T_S, StartParamsU.T_E, StartParamsU.L, StartParamsU.D_U, StartParamsU.Check, StartParamsU.Note));
                    }));
            }
        }

        public RelayCommand CalcCommandCU
        {
            get
            {
                return calcCommandCU ??
                    (calcCommandCU = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcU_C(StartParamsCU.T_S, StartParamsCU.T_E, StartParamsCU.L, StartParamsCU.D_U, StartParamsCU.DC_U, StartParamsCU.Note));
                    }));
            }
        }

        public RelayCommand CalcCommandCM
        {
            get
            {
                return calcCommandCM ??
                    (calcCommandCM = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcM_С(StartparamsCM.T_S, StartparamsCM.T_E, StartparamsCM.L, StartparamsCM.D_U, StartparamsCM.DC_U, StartparamsCM.Note));
                    }));
            }
        }

        public RelayCommand CalcCommandRM
        {
            get
            {
                return calcCommandRM ??
                    (calcCommandRM = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcM_R(StartParamsRM.T_S, StartParamsRM.T_E, StartParamsRM.L, StartParamsRM.D_U, StartParamsRM.DC_U, StartParamsRM.Note));
                    }));
            }
        }

        public RelayCommand CalcCommandRU
        {
            get
            {
                return calcCommandRU ??
                    (calcCommandRU = new RelayCommand(obj =>
                    {
                        resClass.Add(SteamCalcU_R(StartParamsRU.T_S, StartParamsRU.T_E, StartParamsRU.L, StartParamsRU.D_U, StartParamsRU.DC_U, StartParamsRU.Note));
                    }));
            }
        }

        public RelayCommand DeleteCommand
        {
            get
            {
                return deleteCommand ??
                    (deleteCommand = new RelayCommand(obj =>
                    {
                        resClass.Remove(select);
                    }));
            }
        }

        public RelayCommand ExcelImport
        {
            get
            {
                return excelImport ??
                    (excelImport = new RelayCommand(obj =>
                    {
                          ExcelLogic.Save(resClass);
                    }));
            }
        }

        public BasLogicClass()
        { }        
    }
}
