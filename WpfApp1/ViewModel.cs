using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace WpfApp1
{
    public class ViewModel : INotifyPropertyChanged
    {
        private ModelAnswer Answer = new ModelAnswer();


        public ObservableCollection<ModelFunctionTypes> FunctionTypes { get; set; }
        public ObservableCollection<ModelAnswer> Answers { get; set; }

        public ModelAnswer SelectedAnswer
        {
            get { return Answer; }
            set
            {
                Answer = value;
                OnPropertyChanged("SelectedAnswer");
            }
        }
        public ModelFunctionTypes SelectedFunctionType
        {
            get { return Answer.TF; }
            set
            {
                Answer.TF = value;
                OnPropertyChanged("SelectedFunctionType");
            }
        }

        public ViewModel()
        {
            FunctionTypes = new ObservableCollection<ModelFunctionTypes>
            {
                new ModelFunctionTypes { TypeFunction="линейная", C1=1, C2=2, C3=3, C4=4, C5=5, Ca=0, Cb=0 },
                new ModelFunctionTypes { TypeFunction="квадратичная", C1=10, C2=20, C3=30, C4=40, C5=50 ,  Ca=0, Cb=0 },
                new ModelFunctionTypes { TypeFunction="кубическая", C1=100, C2=200, C3=300, C4=400, C5=500 ,  Ca=0, Cb=0 },
                new ModelFunctionTypes { TypeFunction="4-ой степени", C1=1000, C2=2000, C3=3000, C4=4000, C5=5000 ,  Ca=0, Cb=0 },
                new ModelFunctionTypes { TypeFunction="5-ой степени", C1=10000, C2=20000, C3=30000, C4=40000, C5=50000 ,  Ca=0, Cb=0 }
            };
            Answers = new ObservableCollection<ModelAnswer>
            { };
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
