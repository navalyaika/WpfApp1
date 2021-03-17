using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace WpfApp1
{
    public class ModelFunctionTypes : INotifyPropertyChanged
    {
        private string typeFunction;
        private int coefficientA;
        private int coefficientB;
        private int coefficientC1;
        private int coefficientC2;
        private int coefficientC3;
        private int coefficientC4;
        private int coefficientC5;
        private int sc;
        public int SelectCoeficientC
        {
            get { return sc; }
            set
            {
                sc = value;
                OnPropertyChanged("GetAnswer");
            }
        }
        public string TypeFunction
        {
            get { return typeFunction; }
            set
            {
                typeFunction = value;
                OnPropertyChanged("F");
            }
        }
        public int C1
        {
            get { return coefficientC1; }
            set
            {
                coefficientC1 = value;
                OnPropertyChanged("SelectCoeficientC");
            }
        }
        public int C2
        {
            get { return coefficientC2; }
            set
            {
                coefficientC2 = value;
                OnPropertyChanged("SelectCoeficientC");
            }
        }
        public int C3
        {
            get { return coefficientC3; }
            set
            {
                coefficientC3 = value;
                OnPropertyChanged("SelectCoeficientC");
            }
        }
        public int C4
        {
            get { return coefficientC4; }
            set
            {
                coefficientC4 = value;
                OnPropertyChanged("SelectCoeficientC");
            }
        }
        public int C5
        {
            get { return coefficientC5; }
            set
            {
                coefficientC5 = value;
                OnPropertyChanged("SelectCoeficientC");
            }
        }
        public int Ca
        {
            get { return coefficientA; }
            set
            {
                coefficientA = value;
                OnPropertyChanged("GetAnswer");
            }
        }
        public int Cb
        {
            get { return coefficientB; }
            set
            {
                coefficientB = value;
                OnPropertyChanged("GetAnswer");
            }
        }

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }

        public event PropertyChangedEventHandler PropertyChanged;

    }
}
