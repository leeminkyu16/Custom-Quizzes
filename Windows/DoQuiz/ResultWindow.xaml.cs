using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace CustomQuiz.Windows.DoQuiz
{
    /// <summary>
    /// Interaction logic for DoQuizResultWindow.xaml
    /// </summary>
    public partial class ResultWindow : Window
    {
        private Models.Quiz _quizVar;

        public ResultWindow(Models.Quiz quizVar)
        {
            InitializeComponent();

            _quizVar = quizVar;

            int _numberOfCorrectAnswers = 0;
            for (int i = 0; i < _quizVar.Questions.Count; i++)
            {
                if (_quizVar.Questions[i].IsSelectedOptionCorrect())
                {
                    _numberOfCorrectAnswers++;
                }
            }

            TextBlockQuizName.Text = _quizVar.Title;
            TextBlockFraction.Text = _numberOfCorrectAnswers.ToString() + '/' + _quizVar.Questions.Count;
            TextBlockPercentage.Text = Math.Round((double)_numberOfCorrectAnswers / _quizVar.Questions.Count * 100).ToString() + '%';
        }

        private void Go_To_Menu_Button(object sender, RoutedEventArgs e)
        {
            MainWindow.Instance.Show();
            this.Close();
        }
    }
}
