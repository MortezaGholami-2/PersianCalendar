// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PersianCalendar.WinUI3.Controls
{
    public sealed partial class ShamsiCalendar : UserControl
    {
        public ShamsiCalendar()
        {
            this.InitializeComponent();
            DataContext = this;
        }



        public string Content2
        {
            get
            {
                return (string)GetValue(Content2Property);
            }
            set
            {
                SetValue(Content2Property, value);
            }
        }

        // Using a DependencyProperty as the backing store for Content2.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty Content2Property =
            DependencyProperty.Register("Content2", typeof(string), typeof(ShamsiCalendar), new PropertyMetadata(string.Empty));


    }
}
