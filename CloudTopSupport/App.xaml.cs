﻿using CloudTopSupport.Entity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace CloudTopSupport
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            //System.Data.Entity.Database.SetInitializer<RetailContext>(null);
            //HeroDB heroDB = new HeroDB();
            var context = HeroConfigHelper.Context;
            MainWindow win = new MainWindow();
            win.WindowStartupLocation = WindowStartupLocation.Manual;
            win.Top = 0;
            win.Left = 0;
            win.Show();
        }
    }
}
