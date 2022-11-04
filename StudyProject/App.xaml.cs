﻿using StudyProject.ViewModels.Abstract;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using StudyProject.ViewModels;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using StudyProject.Stores;

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
            NavStore navStore = new NavStore();
            MainWindow = new MainWindow()
            {
                DataContext = new MainViewModel(navStore)
            };
            MainWindow.Show();
            base.OnStartup(e);
        }
    }
}
