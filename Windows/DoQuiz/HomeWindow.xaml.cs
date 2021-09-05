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
using System.IO;
using CustomQuiz.Methods;

namespace CustomQuiz.Windows.DoQuiz
{
    /// <summary>
    /// Interaction logic for DoQuizHomeWindow.xaml
    /// </summary>
    public partial class HomeWindow : Window
    {
        private readonly string _dataDirectory = "./Data";

        private MainWindow _mainWindow;
        private string[] _listBoxItems;

        public HomeWindow(MainWindow mainWindow)
        {
            _mainWindow = mainWindow;

            InitializeComponent();

            _listBoxItems = Directory.GetFiles(_dataDirectory, "*.quiz", SearchOption.TopDirectoryOnly);

            for (int i = 0; i < _listBoxItems.Length; i++)
            {
                _listBoxItems[i] = _listBoxItems[i].Remove(0, _dataDirectory.Length + 1);
            }

            QuizListBox.ItemsSource = _listBoxItems;
        }

        private void Exit_Button_Click(object sender, RoutedEventArgs e)
        {
            _mainWindow.Show();
            this.Close();
        }

        private void Button_Do_Selected_Quiz_Click(object sender, RoutedEventArgs e)
        {
            if (QuizListBox.SelectedItem != null)
            {
                Models.Quiz selectedQuiz = BinaryFileIO.ReadFromBinaryFile<Models.Quiz>("./Data/" + QuizListBox.SelectedItem);
                if (selectedQuiz != null)
                {
                    selectedQuiz.QuizStartup();
                    DoQuiz.ContentWindow doQuizContentWindowVar = new DoQuiz.ContentWindow(selectedQuiz);

                    doQuizContentWindowVar.Show();
                    this.Close();
                }
            }
        }
    }
}
