using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Windows.MakeQuiz
{
    sealed class HomeModel : INotifyPropertyChanged
    {
        private Models.Quiz _quiz;

        public string QuizTitle
        {
            get
            {
                return _quiz.Title;
            }
            set
            {
                if (_quiz.Title != value)
                {
                    _quiz.Title = value;
                    OnPropertyChange("QuizTitle");
                }
            }
        }

        public bool? RandomOptionOrder
        {
            get
            {
                return _quiz.RandomOptionOrder;
            }
            set
            {
                if (_quiz.RandomOptionOrder != value)
                {
                    _quiz.RandomOptionOrder = value;
                    OnPropertyChange("RandomOptionOrder");
                }
            }
        }

        public bool? RandomQuestionOrder
        {
            get
            {
                return _quiz.RandomQuestionOrder;
            }
            set
            {
                if (_quiz.RandomQuestionOrder != value)
                {
                    _quiz.RandomQuestionOrder = value;
                    OnPropertyChange("RandomQuestionOrder");
                }
            }
        }

        public HomeModel(Models.Quiz quiz)
        {
            _quiz = quiz;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChange(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public Models.Quiz GetQuiz()
        {
            return _quiz;
        }
    }
}
