using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomQuiz.Models
{
    [Serializable]
    public class Question
    {
        public string QuestionText { get; set; }
        private string[] Options;
        public int CorrectOption { get; set; }
        private int _selectedOption;
        public int SelectedOption {
            get
            {
                if (_selectedOption == -1)
                {
                    return _selectedOption;
                }
                return RevOptionIndexMap[_selectedOption];
            }
            set
            {
                if (value == -1)
                {
                    _selectedOption = -1;
                }
                else
                {
                    this._selectedOption = OptionIndexMap[value];
                }
            }
        }
        public bool? RandomizeAnswerOrder { get; set; }

        private int[] OptionIndexMap;
        private int[] RevOptionIndexMap;
        public Question(string questionText = "Question Text", string[] options = null, int correctOption = 0, int selectedOption = -1)
        {
            this.QuestionText = questionText;
            if (options == null)
            {
                this.Options = new[] { "", "", "", "" };
            }
            else
            {
                this.Options = options;
            }

            this.OptionIndexMap = new int[this.Options.Length];
            this.RevOptionIndexMap = new int[this.Options.Length];
            for (int i = 0; i < this.OptionIndexMap.Length; i++)
            {
                this.OptionIndexMap[i] = i;
                this.RevOptionIndexMap[i] = i;
            }

            this.CorrectOption = correctOption;
            this.SelectedOption = selectedOption;
            this.RandomizeAnswerOrder = null;
        }
        
        public void SetOptionString(string value, int index)
        {
            Options[Array.IndexOf(OptionIndexMap, index)] = value;
        }

        public string GetOptionString(int index)
        {
            return Options[OptionIndexMap[index]];
        }

        private void SwapOptionIndexMap(int leftIndex, int rightIndex)
        {
            int tempInt = OptionIndexMap[leftIndex];
            OptionIndexMap[leftIndex] = OptionIndexMap[rightIndex];
            OptionIndexMap[rightIndex] = tempInt;
        }

        private void SwapRevOptionIndexMap(int leftIndex, int rightIndex)
        {
            int tempInt = RevOptionIndexMap[leftIndex];
            RevOptionIndexMap[leftIndex] = RevOptionIndexMap[rightIndex];
            RevOptionIndexMap[rightIndex] = tempInt;
        }

        private void ShuffleOptionIndexMap()
        {
            int[] indicesSwapped = new int[OptionIndexMap.Length - 1];
            for (int i = OptionIndexMap.Length - 1; i > 0; i--)
            {
                int j = MainWindow.RandomVar.Next(i);
                SwapOptionIndexMap(i, j);
                indicesSwapped[i - 1] = j;
            }
            for (int i = 0; i < OptionIndexMap.Length - 1; i++)
            {
                SwapRevOptionIndexMap(i + 1, indicesSwapped[i]);
            }
        }

        public void QuestionStartup()
        {
            this.SelectedOption = -1;
            if (RandomizeAnswerOrder == true)
            {
                ShuffleOptionIndexMap();
            }
        }

        public bool IsSelectedOptionCorrect()
        {
            return _selectedOption == CorrectOption;
        }        
    }
}
