using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Windows.Input;
using System;

namespace WpfApp1
{
    /// <summary>
    /// класс описывающий модель просмотра окна программы
    /// </summary>
    public class MainViewModel :VM
    {
        private ViewModelAnswer _Answer = new ViewModelAnswer();
        //коллекция возможных типов функций
        public ObservableCollection<ModelFunctionTypes> FunctionTypes { get; set; }
        //коллекция функций
        public ObservableCollection<ViewModelAnswer> Answers { get; set; }
        //выбранная функция
        public ViewModelAnswer SelectedAnswer
        {
            get { return _Answer; }
            set
            {
                _Answer = value;
                OnPropertyChanged("SelectedAnswer");
            }
        }


        //конструктор модели просмотра окна программы
        public MainViewModel()
        {
            FunctionTypes = new ObservableCollection<ModelFunctionTypes>
            {
                new ModelFunctionTypes { TypeFunction=TypeFunction.линейная.ToString(), CoefficientsC=new List<int>(){1,2,3,4,5 } },
                new ModelFunctionTypes { TypeFunction=TypeFunction.квадратичная.ToString(), CoefficientsC=new List<int>(){10,20,30,40,50 } },
                new ModelFunctionTypes { TypeFunction=TypeFunction.кубическая.ToString(), CoefficientsC=new List<int>(){100,200,300,400,500 } },
                new ModelFunctionTypes { TypeFunction=TypeFunction.четвертой_степени.ToString(), CoefficientsC=new List<int>(){1000,2000,3000,4000,5000 } },
                new ModelFunctionTypes { TypeFunction=TypeFunction.пятой_степени.ToString(), CoefficientsC=new List<int>(){10000,20000,30000,40000,50000 } }
            };
            Answers = new ObservableCollection<ViewModelAnswer> { };
            Answers.CollectionChanged += Answers_CollectionChanged;

        }
        //метод изменения элемента коллекции функций
        private void Answers_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (e.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (ViewModelAnswer item in e.NewItems)
                {
                    item.PropertyChanged += Item_PropertyChanged;
                }
            }
        }
        //метод изменения выбранной функции из коллекции
        private void Item_PropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            ViewModelAnswer answer = sender as ViewModelAnswer;
            if(e.PropertyName!="F" && e.PropertyName!="TF")
            {
                answer.GetF();
            }
        }
    }
}
