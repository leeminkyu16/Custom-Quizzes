using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Windows.MakeQuiz
{
    sealed class ContentModel : INotifyPropertyChanged
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

        public string QuestionText
        {
            get
            {
                return _quiz.GetSelectedQuestionText();
            }
            set
            {
                if (_quiz.GetSelectedQuestionText() != value)
                {
                    _quiz.SetSelectedQuestionText(value);
                    OnPropertyChange("QuestionText");
                }
            }
        }
        
        public string Answer1
        {
            get
            {
                return _quiz.GetSelectedQuestionOption(0);
            }
            set
            {
                if (_quiz.GetSelectedQuestionOption(0) != value)
                {
                    _quiz.SetSelectedQuestionOption(value, 0);
                    OnPropertyChange("Answer1");
                    OnPropertyChange("AnswerArray");
                }
            }
        }
        
        public string Answer2
        {
            get
            {
                return _quiz.GetSelectedQuestionOption(1);
            }
            set
            {
                if (_quiz.GetSelectedQuestionOption(1) != value)
                {
                    _quiz.SetSelectedQuestionOption(value, 1);
                    OnPropertyChange("Answer2");
                    OnPropertyChange("AnswerArray");
                }
            }
        }
        
        public string Answer3
        {
            get
            {
                return _quiz.GetSelectedQuestionOption(2);
            }
            set
            {
                if (_quiz.GetSelectedQuestionOption(2) != value)
                {
                    _quiz.SetSelectedQuestionOption(value, 2);
                    OnPropertyChange("Answer3");
                    OnPropertyChange("AnswerArray");
                }
            }
        }
        
        public string Answer4
        {
            get
            {
                return _quiz.GetSelectedQuestionOption(3);
            }
            set
            {
                if (_quiz.GetSelectedQuestionOption(3) != value)
                {
                    _quiz.SetSelectedQuestionOption(value, 3);
                    OnPropertyChange("Answer4");
                    OnPropertyChange("AnswerArray");
                }
            }
        }
        
        public string[] AnswerArray
        {
            get
            {
                return new[] { _quiz.GetSelectedQuestionOption(0), _quiz.GetSelectedQuestionOption(1), _quiz.GetSelectedQuestionOption(2), _quiz.GetSelectedQuestionOption(3) };
            }
        }
        
        public int CorrectOption
        {
            get
            {
                return _quiz.GetSelectedQuestionCorrectOption();
            }
            set
            {
                if (_quiz.GetSelectedQuestionCorrectOption() != value)
                {
                    _quiz.SetSelectedQuestionCorrectOption(value);
                    OnPropertyChange("CorrectOption");
                }
            }
        }
        
        public bool? RandomizeAnswerOrder
        {
            get
            {
                return _quiz.IsSelectedQuestionAnswerRandom();
            }
            set
            {
                if (_quiz.IsSelectedQuestionAnswerRandom() != value)
                {
                    _quiz.SetSelectedQuestionAnswerRandom(value);
                    OnPropertyChange("RandomizeAnswerOrder");
                }
            }
        }
        
        public ContentModel(Models.Quiz quiz)
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

        private void OnIndexChange()
        {
            OnPropertyChange("QuestionText");
            OnPropertyChange("Answer1");
            OnPropertyChange("Answer2");
            OnPropertyChange("Answer3");
            OnPropertyChange("Answer4");
            OnPropertyChange("AnswerArray");
            OnPropertyChange("CorrectOption");
            OnPropertyChange("RandomizeAnswerOrder");
        }

        public Models.Quiz GetQuiz()
        {
            return _quiz;
        }
        
        public int GetQuestionCount()
        {
            return _quiz.GetQuestionCount();
        }

        public void AddQuestionToQuiz(Models.Question question = null)
        {
            if (question != null)
            {
                _quiz.AddQuestion(question);
            }
            else
            {
                Models.Question questionTemp = new Models.Question(options: new[] { "Answer Text 1", "Answer Text 2", "Answer Text 3", "Answer Text 4" });
                _quiz.AddQuestion(questionTemp);
            }
        }

        public int GetQuizSelectedIndex()
        {
            return _quiz.SelectedQuestionIndex;
        }

        public void SetQuizSelectedIndex(int index)
        {
            _quiz.SelectedQuestionIndex = index;
            OnIndexChange();
        }

        public void IncrementQuizSelectedIndex()
        {
            _quiz.SelectedQuestionIndex++;
            OnIndexChange();
        }

        public void DecrementQuizSelectedIndex()
        {
            _quiz.SelectedQuestionIndex--;
            OnIndexChange();
        }
    }
}
