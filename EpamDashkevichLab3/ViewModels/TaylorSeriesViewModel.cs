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
    class TaylorSeriesViewModel : INotifyPropertyChanged
    {
        private int _PrecisionPower;
        private TaylorCalculator _Calculator;
        private double _X;
        private double _Y;
        public int PrecisionPower
        {
            get
            {
                return _PrecisionPower;
            }
            set
            {
                _PrecisionPower = value;
                OnPropertyChanged();
            }
        }
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
        public TaylorSeriesViewModel()
        {
            X = 0;
            PrecisionPower = -6;
            Calculate = new Command(OnCalculateExecuted, CanCalculateExecute);
            _Calculator = new TaylorCalculator();
        }
        public ICommand Calculate { get; }

        public void OnCalculateExecuted(object parameter)
        {
            Y = _Calculator.Calculate(X,0,PrecisionPower,0);
        }
        public bool CanCalculateExecute(object parameter)
        {
            if (X < 1 && X > -1)
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
