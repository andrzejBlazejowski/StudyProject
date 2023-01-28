using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using StudyProject.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;


using StudyProject.ViewModels.List;
using StudyProject.ViewModels;
using StudyProject.View.Add;
using StudyProject.ViewModels.BuisnesLogic;

namespace StudyProject
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 
    #region Fields
    #endregion
    public partial class App : Application
    {

        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel()
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}

