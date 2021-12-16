using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace EpamDashkevichLab3.ViewModels
{
    class MainWindowViewModel : INotifyPropertyChanged
    {
        private Page _Taylor;
        private Page _FunctionByChart;
        private Page _CurrentPage;

        public Page CurrentPage
        {
            get
            {
                return _CurrentPage;
            }
            set
            {
                _CurrentPage = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            _FunctionByChart = new Pages.FunctionByChart();
            _Taylor = new Pages.Page1();
            CurrentPage = _FunctionByChart;
            GoFunctionByChart = new Command(OnGoFunctionByChartExecuted, CanGoFunctionByChartExecute);
            GoTaylor = new Command(OnGoTaylorExecuted, CanGoTaylorExecute);
        }

        public ICommand GoFunctionByChart { get; }
        public void OnGoFunctionByChartExecuted(object parameter)
        {
            CurrentPage = _FunctionByChart;
        }
        public bool CanGoFunctionByChartExecute(object parameter)
        {
            if (CurrentPage == _FunctionByChart)
            {
                return false;
            }
            else return true;
        }
        public ICommand GoTaylor { get; }
        public void OnGoTaylorExecuted(object parameter)
        {
            CurrentPage = _Taylor;
        }
        public bool CanGoTaylorExecute(object parameter)
        {
            if (CurrentPage == _Taylor)
            {
                return false;
            }
            else return true;
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
