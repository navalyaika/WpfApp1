using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    /// <summary>
    /// класс описывающий функции типа F=ax+by+c
    /// </summary>
    public class ModelAnswer
    {
        //конструктор по умолчанию
        public ModelAnswer()
        {
            X = 0;
            Y = 0;
            A = 0;
            B = 0;
            C = 1;
            F = 0;
            TF = new ModelFunctionTypes { TypeFunction = TypeFunction.линейная.ToString(), CoefficientsC = new List<int>() { 1, 2, 3, 4, 5 } };
        }
        //тип функции и возможные коэффициенты c
        public ModelFunctionTypes TF { get; set; }
        //параметр x
        public int X { get; set; }
        //параметр y
        public int Y { get; set; }
        //значение функции
        public int F { get; set; }
        //коэффициент a
        public int A { get; set; }
        //коэффициент b
        public int B { get; set; }
        //коэффициент c
        public int C { get; set; }
        
    }
}
