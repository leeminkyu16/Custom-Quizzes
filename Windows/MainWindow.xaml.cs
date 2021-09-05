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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CustomQuiz
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        private static Random _randomVar = new Random();
        public static Random RandomVar
        {
            get
            {
                return _randomVar;
            }
        }
        public static MainWindow Instance { get; } = new MainWindow();
        private MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Do_Quizzes_Click(object sender, RoutedEventArgs e)
        {
            Windows.DoQuiz.HomeWindow doQuizHomeWindowVar = new Windows.DoQuiz.HomeWindow(this);
            doQuizHomeWindowVar.Show();
            this.Hide();
        }
        private void Button_Make_Quizzes_Click(object sender, RoutedEventArgs e)
        {
            Windows.MakeQuiz.HomeWindow makeQuizHomeWindowVar = new Windows.MakeQuiz.HomeWindow();
            makeQuizHomeWindowVar.Show();
            this.Hide();
        }
        private void Button_Exit_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Application.Current.Shutdown();
        }

        private void Button_Edit_Click(object sender, RoutedEventArgs e)
        {
            Windows.EditQuiz.HomeWindow editQuizHomeWindowVar = new Windows.EditQuiz.HomeWindow();
            editQuizHomeWindowVar.Show();
            this.Hide();
        }
    }
}
