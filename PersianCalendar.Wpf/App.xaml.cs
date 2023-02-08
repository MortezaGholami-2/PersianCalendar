﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Microsoft.Extensions.Hosting;
using PersianCalendar.Wpf.Views;
using Windows.ApplicationModel.Activation;

namespace PersianCalendar.Wpf;
/// <summary>
/// Interaction logic for App.xaml
/// </summary>
public partial class App : Application
{
    protected override void OnStartup(StartupEventArgs e)
    {
        Window window = new ShellWindow();
        window.Show();
        base.OnStartup(e);
    }
}
