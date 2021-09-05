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
using CustomQuiz.Methods;

namespace CustomQuiz.Windows.MakeQuiz
{
    /// <summary>
    /// Interaction logic for MakeQuizOverviewWindow.xaml
    /// </summary>
    public partial class OverviewWindow : Window
    {
        private readonly OverviewModel _overviewModel;

        private bool _saved;

        public OverviewWindow(Models.Quiz quizVar)
        {
            InitializeComponent();
            _overviewModel = new OverviewModel(quizVar);

            DataContext = _overviewModel;

            _saved = false;
        }

        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            if (! _saved)
            {
                if (MessageBox.Show(this, "You have not saved yet. Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.No)
                {
                    return;
                }
            }

            MainWindow.Instance.Show();
            this.Close();
        }

        private void Button_Move_Up_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionListBox.SelectedIndex > 0)
            {
                _overviewModel.SwapQuestions(QuestionListBox.SelectedIndex, QuestionListBox.SelectedIndex - 1);
            }
        }
        private void Button_Move_Down_Click(object sender, RoutedEventArgs e)
        {
            if (QuestionListBox.SelectedIndex < _overviewModel.GetQuestionCount() - 1)
            {
                _overviewModel.SwapQuestions(QuestionListBox.SelectedIndex, QuestionListBox.SelectedIndex + 1);
            }
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            ContentWindow _makeQuizContentWindowVar = new ContentWindow(_overviewModel.GetQuiz(), QuestionListBox.SelectedIndex);
            _makeQuizContentWindowVar.Show();
            this.Close();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            BinaryFileIO.WriteToBinaryFile("./Data/" + _overviewModel.QuizTitle + ".quiz", _overviewModel.GetQuiz());
            _saved = true;
        }
    }
}
