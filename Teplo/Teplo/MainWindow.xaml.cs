using System.Windows;
using System.Windows.Controls;
using System.Collections.ObjectModel;
using Teplo.BusinessLayer.Models;
using Teplo.BusinessLayer.Service;
using Teplo.AllCalcLogic;

namespace Teplo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<SteamM1994ViewModel> steamM1994;
        ObservableCollection<SteamU1994ViewModel> steamU1994;
        ObservableCollection<CanalM1994ViewModel> canalM1994;
        ObservableCollection<CanalU1994ViewModel> canalU1994;
        ObservableCollection<RoomU1994ViewModel> roomU1994;
        SteamM1994Service steamM1994Service;
        SteamU1994Service steamU1994Service;
        CanalM1994Service canalM1994Service;
        CanalU1994Service canalU1994Service;
        RoomU1994Service roomU1994Service;
        public MainWindow()
        {
            InitializeComponent();
            steamM1994Service = new SteamM1994Service("DBase_1");
            steamU1994Service = new SteamU1994Service("DBase_1");
            canalM1994Service = new CanalM1994Service("DBase_1");
            canalU1994Service = new CanalU1994Service("DBase_1");
            roomU1994Service = new RoomU1994Service("DBase_1");
            steamM1994 = steamM1994Service.GetAll();
            steamU1994 = steamU1994Service.GetAll();
            canalM1994 = canalM1994Service.GetAll();
            canalU1994 = canalU1994Service.GetAll();
            roomU1994 = roomU1994Service.GetAll();
            D_M_List.ItemsSource = steamM1994;
            D_U_List.ItemsSource = steamU1994;
            D_U_T_R_List.ItemsSource = roomU1994;
            D_U_W_R_List.ItemsSource = roomU1994;
            D_U_W_C_List.ItemsSource = canalU1994;
            D_U_T_C_List.ItemsSource = canalU1994;
            D_M_T_R_List.ItemsSource = canalM1994;
            D_M_W_R_List.ItemsSource = canalM1994;
            D_M_T_C_List.ItemsSource = canalM1994;
            D_M_W_C_List.ItemsSource = canalM1994;
            Res_Grid.ItemsSource = BasLogicClass.resClass;
            //Grid_M.DataContext = BasLogicClass.StartParamsM;
            //Grid_U.DataContext = BasLogicClass.StartParamsU;
        }

        public BasLogicClass BasLogicClass { get; set; } = new BasLogicClass();

        private void CalcBtnU_Click(object sender, RoutedEventArgs e)
        {
            if ((TEU_Text.Text.Length > 0) & (TSU_Text.Text.Length > 0) & (LU_Text.Text.Length > 0))
            {
                BasLogicClass.StartParamsU.T_E = int.Parse(TEU_Text.Text);
                BasLogicClass.StartParamsU.T_S = int.Parse(TSU_Text.Text);
                BasLogicClass.StartParamsU.L = int.Parse(LU_Text.Text);
                BasLogicClass.StartParamsU.D_U = D_U_List.SelectedItem as SteamU1994ViewModel;
                BasLogicClass.StartParamsU.Check = (T_C_U.IsChecked == true) ? true : false;
                BasLogicClass.StartParamsU.Note = NoteU_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void CalcBtnM_Click(object sender, RoutedEventArgs e)
        {
            if ((TEM_Text.Text.Length>0)&(TSM_Text.Text.Length>0)&(L_Text.Text.Length>0))
            {
                BasLogicClass.StartParamsM.T_E = int.Parse(TEM_Text.Text);
                BasLogicClass.StartParamsM.T_S = int.Parse(TSM_Text.Text);
                BasLogicClass.StartParamsM.L = int.Parse(L_Text.Text);
                BasLogicClass.StartParamsM.D_M = D_M_List.SelectedItem as SteamM1994ViewModel;
                BasLogicClass.StartParamsM.Check = (T_C_M.IsChecked == true) ? true : false;
                BasLogicClass.StartParamsM.Note = NoteM_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void CalcBtnU_R_Click(object sender, RoutedEventArgs e)
        {
            if ((T_C_R_U.Text.Length > 0) & (TSU_R_Text.Text.Length > 0) & (LU_R_Text.Text.Length > 0))
            {
                BasLogicClass.StartParamsRU.T_E = int.Parse(T_C_R_U.Text);
                BasLogicClass.StartParamsRU.T_S = int.Parse(TSU_R_Text.Text);
                BasLogicClass.StartParamsRU.L = int.Parse(LU_R_Text.Text);
                BasLogicClass.StartParamsRU.D_U = D_U_T_R_List.SelectedItem as RoomU1994ViewModel;
                BasLogicClass.StartParamsRU.DC_U = D_U_W_R_List.SelectedItem as RoomU1994ViewModel;
                BasLogicClass.StartParamsRU.Note = NoteM_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void CalcBtnU_C_Click(object sender, RoutedEventArgs e)
        {
            if ((T_C_C_U.Text.Length > 0) & (TSU_C_Text.Text.Length > 0) & (LU_C_Text.Text.Length > 0))
            {
                BasLogicClass.StartParamsCU.T_E = int.Parse(T_C_C_U.Text);
                BasLogicClass.StartParamsCU.T_S = int.Parse(TSU_C_Text.Text);
                BasLogicClass.StartParamsCU.L = int.Parse(LU_C_Text.Text);
                BasLogicClass.StartParamsCU.D_U = D_U_T_C_List.SelectedItem as CanalU1994ViewModel;
                BasLogicClass.StartParamsCU.DC_U = D_U_W_C_List.SelectedItem as CanalU1994ViewModel;
                BasLogicClass.StartParamsCU.Note = NoteM_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void CalcBtnM_R_Click(object sender, RoutedEventArgs e)
        {
            if ((T_C_R_M.Text.Length > 0) & (TSM_R_Text.Text.Length > 0) & (LM_R_Text.Text.Length > 0))
            {
                BasLogicClass.StartParamsRM.T_E = int.Parse(T_C_R_M.Text);
                BasLogicClass.StartParamsRM.T_S = int.Parse(TSM_R_Text.Text);
                BasLogicClass.StartParamsRM.L = int.Parse(LM_R_Text.Text);
                BasLogicClass.StartParamsRM.D_U = D_M_T_R_List.SelectedItem as CanalM1994ViewModel;
                BasLogicClass.StartParamsRM.DC_U = D_M_T_R_List.SelectedItem as CanalM1994ViewModel;
                BasLogicClass.StartParamsRM.Note = NoteM_R_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void CalcBtnM_C_Click(object sender, RoutedEventArgs e)
        {
            if ((T_C_C_M.Text.Length > 0) & (TSM_C_Text.Text.Length > 0) & (LM_C_Text.Text.Length > 0))
            {
                BasLogicClass.StartparamsCM.T_E = int.Parse(T_C_C_M.Text);
                BasLogicClass.StartparamsCM.T_S = int.Parse(TSM_C_Text.Text);
                BasLogicClass.StartparamsCM.L = int.Parse(LM_C_Text.Text);
                BasLogicClass.StartparamsCM.D_U = D_M_T_C_List.SelectedItem as CanalM1994ViewModel;
                BasLogicClass.StartparamsCM.DC_U = D_M_W_C_List.SelectedItem as CanalM1994ViewModel;
                BasLogicClass.StartparamsCM.Note = NoteM_C_Text.Text;
            }
            else
            {
                MessageBox.Show("Вы ввели не все обязательные параметры", "Ошибка ввода данных", MessageBoxButton.OK);
            }
        }

        private void DeleteBtn_Click(object sender, RoutedEventArgs e)
        {
            ResClass temp = Res_Grid.SelectedItem as ResClass;
            BasLogicClass.select = temp;
        }

        private void DGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private new void PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (e.Handled = "0123456789".IndexOf(e.Text) < 0)
            {
                MessageBox.Show("Допускается вводить только цифры", "Ошибка ввода данных", MessageBoxButton.OK);
            }            
        }
    }
}
