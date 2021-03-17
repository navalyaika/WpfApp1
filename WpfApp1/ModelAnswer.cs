using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    public class ModelAnswer : INotifyPropertyChanged
    {
        private int x;
        private int y;
        private int rez;
        private ModelFunctionTypes tf = new ModelFunctionTypes();



        public ModelFunctionTypes TF
        {
            get { return tf; }
            set
            {
                tf = value;
                OnPropertyChanged("TF");
            }
        }

        public int X
        {
            get { return x; }
            set
            {
                x = value;
                OnPropertyChanged("GetAnswer");
            }
        }
        public int Y
        {
            get { return y; }
            set
            {
                y = value;
                OnPropertyChanged("GetAnswer");
            }
        }
        public int Rez
        {
            get 
            {
                return rez;
            }
            set
            {
                rez = value;
                OnPropertyChanged("Rez");
            }
        }

        public int GetAnswer
        {
            get 
            {
                if (tf.TypeFunction == "линейная")
                    rez = (tf.Ca * x) + tf.Cb + tf.SelectCoeficientC;
                else if(tf.TypeFunction == "квадратичная")
                    rez = (tf.Ca * (x^2)) + (tf.Cb*y) + tf.SelectCoeficientC;
                else if (tf.TypeFunction == "кубическая")
                    rez = (tf.Ca * (x ^ 3)) + (tf.Cb * (y^2)) + tf.SelectCoeficientC;
                else if (tf.TypeFunction == "4-ой степени")
                    rez = (tf.Ca * (x ^ 4)) + (tf.Cb * (y^3)) + tf.SelectCoeficientC;
                else if (tf.TypeFunction == "5-ой степени")
                    rez = (tf.Ca * (x ^ 5)) + (tf.Cb * (y^4)) + tf.SelectCoeficientC;
                return rez;
            }
            set
            {
                rez = value;
                OnPropertyChanged("GetAnswer");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
