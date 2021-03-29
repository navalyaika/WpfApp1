using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Controls;

namespace WpfApp1
{
    /// <summary>
    /// перечисление типов функции
    /// </summary>
    public enum TypeFunction
    {
        линейная,
        квадратичная,
        кубическая,
        четвертой_степени,
        пятой_степени
    }
    /// <summary>
    /// класс описывающий тип функции и список возможных коэффициентов c
    /// </summary>
    public class ModelFunctionTypes
    {
        //список возможных коэффициентов c
        public List<int> CoefficientsC { get; set; }
        //тип функции
        public string TypeFunction { get; set; }

    }
}
