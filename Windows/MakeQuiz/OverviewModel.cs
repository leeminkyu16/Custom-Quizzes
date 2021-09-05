using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Windows.MakeQuiz
{
    sealed class OverviewModel : INotifyPropertyChanged
    {
        private Models.Quiz _quiz;

        public OverviewModel(Models.Quiz quiz)
        {
            _quiz = quiz;
        }

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

        public ObservableCollection<Models.Question> Questions
        {
            get
            {
                return _quiz.Questions;
            }
            set
            {
                if (_quiz.Questions.Equals(value))
                {
                    _quiz.Questions = value;
                    OnPropertyChange("Questions");
                }
            }
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

        public void SwapQuestions(int leftIndex, int rightIndex)
        {
            _quiz.SwapQuestions(leftIndex, rightIndex);
        }

        public int GetQuestionCount()
        {
            return _quiz.GetQuestionCount();
        }
    }
}
