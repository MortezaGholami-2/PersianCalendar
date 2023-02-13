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
using System.Drawing;
using Brush = Microsoft.UI.Xaml.Media.Brush;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace PersianCalendar.WinUI3.Controls;

public sealed partial class CalendarDay : UserControl
{


    public string DayNumber
    {
        get => (string)GetValue(DayNumberProperty);
        set => SetValue(DayNumberProperty, value);
    }

    // Using a DependencyProperty as the backing store for DayNumber.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty DayNumberProperty =
        DependencyProperty.Register("DayNumber", typeof(string), typeof(CalendarDay), new PropertyMetadata(string.Empty));



    public Brush BorderBrush
    {
        get
        {
            return (Brush)GetValue(BorderBrushProperty);
        }
        set
        {
            SetValue(BorderBrushProperty, value);
        }
    }

    // Using a DependencyProperty as the backing store for BorderBrush.  This enables animation, styling, binding, etc...
    public static readonly DependencyProperty BorderBrushProperty =
        DependencyProperty.Register("BorderBrush", typeof(Brush), typeof(CalendarDay), new PropertyMetadata(Brushes.Transparent));






    public CalendarDay()
    {
        this.InitializeComponent();
        this.DataContext = this;
    }
}
