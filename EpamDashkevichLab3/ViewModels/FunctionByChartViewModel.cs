using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using EpamDashkevichLab3.Models;

namespace EpamDashkevichLab3.ViewModels
{
    class FunctionByChartViewModel : INotifyPropertyChanged
    {
        private double _X;
        private double _Y;
        public FunctionCalculator _Calculator;

        public double X
        {
            get
            {
                return _X;
            }
            set
            {
                if(_X != value)
                {
                    _X = value;
                    OnPropertyChanged();
                }
            }
        }
        public double Y
        {
            get
            {
                return _Y;
            }
            set
            {
                _Y = value;
                OnPropertyChanged();
            }
        }
        public FunctionByChartViewModel()
        {
            X = 0;
            _Calculator = new FunctionCalculator();
            Calculate = new Command(OnCalculateExecuted, CanCalculateExecute);
        }

        public ICommand Calculate { get; }
        public void OnCalculateExecuted(object parameter)
        {
            Y = _Calculator.F(X);
        }
        public bool CanCalculateExecute(object parameter)
        {
            if (X >= -4 && X <= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
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
