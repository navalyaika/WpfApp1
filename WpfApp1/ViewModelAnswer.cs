using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace WpfApp1
{
    /// <summary>
    /// класс описывающий модель просмотра функции
    /// </summary>
    public class ViewModelAnswer:VM
    {
        private ModelAnswer _Answer = new ModelAnswer();
        public ModelAnswer Answer
        {
            get { return _Answer; }
            set
            {
                _Answer = value;
                OnPropertyChanged("Answer");
                
            }
        }
        public int X { get => _Answer.X; set { _Answer.X = value; OnPropertyChanged("X"); } }
        public int Y { get => _Answer.Y; set { _Answer.Y = value; OnPropertyChanged("Y"); } }
        public int F { get => _Answer.F; set { _Answer.F = value; OnPropertyChanged("F"); } }
        public int A { get => _Answer.A; set { _Answer.A = value; OnPropertyChanged("A"); } }
        public int B { get => _Answer.B; set { _Answer.B = value; OnPropertyChanged("B"); } }
        public int C { get => _Answer.C; set { _Answer.C = value; OnPropertyChanged("C"); } }
        public ModelFunctionTypes TF { get => _Answer.TF; set { _Answer.TF = value; OnPropertyChanged("TF"); } }

        //метод получения значения функции
        public void GetF()
        {
            if (TF.TypeFunction == TypeFunction.линейная.ToString())
                F = (int)((A * Math.Pow(X, 1)) + (B * Math.Pow(Y, 0)) + C);
            else if (TF.TypeFunction == TypeFunction.квадратичная.ToString())
                F = (int)((A * Math.Pow(X, 2)) + (B * Math.Pow(Y, 1)) + C);
            else if (TF.TypeFunction == TypeFunction.кубическая.ToString())
                F = (int)((A * Math.Pow(X, 3)) + (B * Math.Pow(Y, 2)) + C);
            else if (TF.TypeFunction == TypeFunction.четвертой_степени.ToString())
                F = (int)((A * Math.Pow(X, 4)) + (B * Math.Pow(Y, 3)) + C);
            else if (TF.TypeFunction == TypeFunction.пятой_степени.ToString())
                F = (int)((A * Math.Pow(X, 5)) + (B * Math.Pow(Y, 4)) + C);
        }
    }
}
