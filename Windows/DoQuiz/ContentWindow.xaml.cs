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
    /// Interaction logic for DoQuizContentWindow.xaml
    /// </summary>
    public partial class ContentWindow : Window
    {
        private ContentModel _contentModel;

        public ContentWindow(Models.Quiz quizVar)
        {
            InitializeComponent();

            _contentModel = new ContentModel(quizVar);
            _contentModel.SetSelectedQuestionIndex(0);

            DataContext = _contentModel;
        }
        
        private void Button_Next_Click(object sender, RoutedEventArgs e)
        {
            if (_contentModel.GetSelectedQuestionIndex() + 1 < _contentModel.GetQuestionCount())
            {
                _contentModel.IncrementQuizSelectedIndex();
            }
        }
        private void Button_Submit_Click(object sender, RoutedEventArgs e)
        {
            ResultWindow doQuizResultWindowVar = new ResultWindow(_contentModel.GetQuiz());
            doQuizResultWindowVar.Show();

            this.Close();
        }
        private void Button_Previous_Click(object sender, RoutedEventArgs e)
        {
            if (_contentModel.GetSelectedQuestionIndex() > 0)
            {
                _contentModel.DecrementQuizSelectedIndex();
            }
        }
    }
}
