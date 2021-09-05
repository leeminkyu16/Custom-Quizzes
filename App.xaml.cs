using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CustomQuiz
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            Startup += new StartupEventHandler(AppStartUp);
        }
        void AppStartUp(object sender, StartupEventArgs e)
        {
            CustomQuiz.MainWindow.Instance.Show();
        }
    }
}
