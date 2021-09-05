using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Models
{
    [Serializable]
    public class Quiz
    {
        public string Title { get; set; }
        public ObservableCollection<Question> Questions { get; set; }
        public int SelectedQuestionIndex { get; set; }
        public bool? RandomOptionOrder { get; set; }
        public bool? RandomQuestionOrder { get; set; }
        public Quiz(string title = "", int selectedQuestionIndex = 0, bool? randomOptionOrder = false, bool? randomQuestionOrder = false)
        {
            this.Title = title;
            Questions = new ObservableCollection<Question>();
            this.SelectedQuestionIndex = selectedQuestionIndex;
            this.RandomOptionOrder = randomOptionOrder;
            this.RandomQuestionOrder = randomQuestionOrder;
        }

        private void ShuffleQuestions()
        {
            for (int i = Questions.Count - 1; i > 0; i--)
            {
                int j = MainWindow.RandomVar.Next(i);
                SwapQuestions(i, j);
            }
        }

        public void QuizStartup()
        {
            this.SelectedQuestionIndex = 0;
            if (this.RandomQuestionOrder == true)
            {
                ShuffleQuestions();
            }
            if (this.RandomOptionOrder == true)
            {
                for (int i = 0; i < Questions.Count; i++)
                {
                    if (Questions[i].RandomizeAnswerOrder == null)
                    {
                        Questions[i].RandomizeAnswerOrder = true;
                    }
                    Questions[i].QuestionStartup();
                }
            }
        }

        public void SwapQuestions(int leftIndex, int rightIndex)
        {
            Question tempQuestion = Questions[leftIndex];
            Questions[leftIndex] = Questions[rightIndex];
            Questions[rightIndex] = tempQuestion;
        }

        public void AddQuestion(Question questionVar)
        {
            this.Questions.Add(questionVar);
        }

        private Question GetSelectedQuestion()
        {
            return Questions[this.SelectedQuestionIndex];
        }

        public int GetSelectedQuestionCorrectOption()
        {
            return this.GetSelectedQuestion().CorrectOption;
        }

        public void SetSelectedQuestionCorrectOption(int correctOptionIndex)
        {
            this.GetSelectedQuestion().CorrectOption = correctOptionIndex;
        }

        public bool? IsSelectedQuestionAnswerRandom()
        {
            return this.GetSelectedQuestion().RandomizeAnswerOrder;
        }

        public void SetSelectedQuestionAnswerRandom(bool? isAnswerOrderRandom)
        {
            this.GetSelectedQuestion().RandomizeAnswerOrder = isAnswerOrderRandom;
        }

        public string GetSelectedQuestionOption(int index)
        {
            return this.GetSelectedQuestion().GetOptionString(index);
        }

        public void SetSelectedQuestionOption(string value, int index)
        {
            this.GetSelectedQuestion().SetOptionString(value, index);
        }

        public int GetQuestionCount()
        {
            return this.Questions.Count;
        }

        public void SetSelectedQuestionText(string questionText)
        {
            this.GetSelectedQuestion().QuestionText = questionText;
        }

        public string GetSelectedQuestionText()
        {
            return this.GetSelectedQuestion().QuestionText;
        }

        public int GetSelectedAnswerIndex()
        {
            return this.GetSelectedQuestion().SelectedOption;
        }

        public void SetSelectedAnswerIndex(int index)
        {
            this.GetSelectedQuestion().SelectedOption = index;
        }
    }
}
