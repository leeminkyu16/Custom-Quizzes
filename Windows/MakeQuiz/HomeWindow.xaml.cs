using System;
using System.Collections.Generic;
using System.IO;
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
    /// Interaction logic for MakeQuizHomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private HomeModel _homeModel;

        private bool _saved;

        public HomeWindow(Models.Quiz quizVar = null)
        {
            InitializeComponent();
            
            if (quizVar == null)
            {
                quizVar = new Models.Quiz();
            }

            _homeModel = new HomeModel(quizVar);

            DataContext = _homeModel;

            _saved = false;
        }
        private void Button_Go_Next_Click(object sender, RoutedEventArgs e)
        {
            ContentWindow makeQuizContentWindowVar = new ContentWindow(_homeModel.GetQuiz());
            makeQuizContentWindowVar.Show();
            this.Close();
        }
        private void Button_Go_Back_Click(object sender, RoutedEventArgs e)
        {
            if (!_saved)
            {
                if (MessageBox.Show(this, "You have not saved yet. Are you sure you want to exit?", "Confirmation", MessageBoxButton.YesNo, MessageBoxImage.Exclamation) == MessageBoxResult.No)
                {
                    return;
                }
            }

            MainWindow.Instance.Show();
            this.Close();
        }

        private void Button_Save_Click(object sender, RoutedEventArgs e)
        {
            if (_homeModel.GetQuiz() != null)
            {
                BinaryFileIO.WriteToBinaryFile<Models.Quiz>("./Data/" + _homeModel.QuizTitle + ".quiz", _homeModel.GetQuiz());
                _saved = true;
            }
        }
    }
}
