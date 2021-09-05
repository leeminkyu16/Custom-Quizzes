using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CustomQuiz.Windows.DoQuiz
{
    sealed class ContentModel : INotifyPropertyChanged
    {
        private bool _changingQuestions;

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

        public string Answer1Text
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
                    OnPropertyChange("Answer1Text");
                }
            }
        }

        public string Answer2Text
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
                    OnPropertyChange("Answer2Text");
                }
            }
        }

        public string Answer3Text
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
                    OnPropertyChange("Answer3Text");
                }
            }
        }

        public string Answer4Text
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
                    OnPropertyChange("Answer4Text");
                }
            }
        }

        public bool IsAnswer1Checked
        {
            get
            {
                return _quiz.GetSelectedAnswerIndex() == 0;
            }
            set
            {
                if (_quiz.GetSelectedAnswerIndex() != 0 && !_changingQuestions)
                {
                    _quiz.SetSelectedAnswerIndex(0);
                    OnCheckedAnswerChange();
                }
            }
        }

        public bool IsAnswer2Checked
        {
            get
            {
                return _quiz.GetSelectedAnswerIndex() == 1;
            }
            set
            {
                if (_quiz.GetSelectedAnswerIndex() != 1 && !_changingQuestions)
                {
                    _quiz.SetSelectedAnswerIndex(1);
                    OnCheckedAnswerChange();
                }
            }
        }

        public bool IsAnswer3Checked
        {
            get
            {
                return _quiz.GetSelectedAnswerIndex() == 2;
            }
            set
            {
                if (_quiz.GetSelectedAnswerIndex() != 2 && !_changingQuestions)
                {
                    _quiz.SetSelectedAnswerIndex(2);
                    OnCheckedAnswerChange();
                }
            }
        }

        public bool IsAnswer4Checked
        {
            get
            {
                return _quiz.GetSelectedAnswerIndex() == 3;
            }
            set
            {
                if (_quiz.GetSelectedAnswerIndex() != 3 && !_changingQuestions)
                {
                    _quiz.SetSelectedAnswerIndex(3);
                    OnCheckedAnswerChange();
                }
            }
        }

        public ContentModel(Models.Quiz quiz)
        {
            _changingQuestions = false;
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

        private void OnCheckedAnswerChange()
        {
            OnPropertyChange("IsAnswer1Checked");
            OnPropertyChange("IsAnswer2Checked");
            OnPropertyChange("IsAnswer3Checked");
            OnPropertyChange("IsAnswer4Checked");
        }

        private void OnIndexChange()
        {
            OnPropertyChange("QuestionText");
            OnPropertyChange("Answer1Text");
            OnPropertyChange("Answer2Text");
            OnPropertyChange("Answer3Text");
            OnPropertyChange("Answer4Text");
            OnCheckedAnswerChange();
        }

        public Models.Quiz GetQuiz()
        {
            return _quiz;
        }

        public void SetSelectedQuestionIndex(int index)
        {
            _changingQuestions = true;
            _quiz.SelectedQuestionIndex = index;
            OnIndexChange();
            _changingQuestions = false;
        }

        public int GetSelectedQuestionIndex()
        {
            return _quiz.SelectedQuestionIndex;
        }

        public int GetQuestionCount()
        {
            return _quiz.Questions.Count;
        }

        public void IncrementQuizSelectedIndex()
        {
            _changingQuestions = true;
            _quiz.SelectedQuestionIndex++;
            OnIndexChange();
            _changingQuestions = false;
        }

        public void DecrementQuizSelectedIndex()
        {
            _changingQuestions = true;
            _quiz.SelectedQuestionIndex--;
            OnIndexChange();
            _changingQuestions = false;
        }
    }
}
