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

namespace CustomQuiz.Windows.MakeQuiz
{
    /// <summary>
    /// Interaction logic for MakeQuizContentWindow.xaml
    /// </summary>
    public partial class ContentWindow : Window
    {
        private ContentModel _contentModel;

        public ContentWindow(Models.Quiz quizVar, int startingIndex = 0)
        {
            //_quizVar = quizVar;
            _contentModel = new ContentModel(quizVar);
            InitializeComponent();

            if (_contentModel.GetQuestionCount() <= 0)
            {
                _contentModel.AddQuestionToQuiz();
                _contentModel.SetQuizSelectedIndex(0);
            }
            else
            {
                _contentModel.SetQuizSelectedIndex(startingIndex);
            }

            DataContext = _contentModel;
        }
        
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            if (_contentModel.GetQuizSelectedIndex() + 1 < _contentModel.GetQuestionCount())
            {
                _contentModel.IncrementQuizSelectedIndex();
            }
            else
            {
                _contentModel.AddQuestionToQuiz();
                _contentModel.IncrementQuizSelectedIndex();
            }
        }
        
        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            if (_contentModel.GetQuizSelectedIndex() > 0)
            {
                _contentModel.DecrementQuizSelectedIndex();
            }
            else if (_contentModel.GetQuizSelectedIndex() == 0)
            {
                HomeWindow homeWindowVar = new HomeWindow(_contentModel.GetQuiz());
                homeWindowVar.Show();
                this.Close();
            }
        }
        
        private void Button_Overview_Click(object sender, RoutedEventArgs e)
        {
            Windows.MakeQuiz.OverviewWindow makeQuizOverviewWindowVar = new Windows.MakeQuiz.OverviewWindow(_contentModel.GetQuiz());
            makeQuizOverviewWindowVar.Show();
            this.Close();
        }
    }
}
