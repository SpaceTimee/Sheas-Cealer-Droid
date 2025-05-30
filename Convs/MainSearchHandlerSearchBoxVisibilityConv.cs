﻿using Microsoft.Maui.Controls;
using System;
using System.Globalization;

namespace Sheas_Cealer_Droid.Convs;

internal class MainSearchHandlerSearchBoxVisibilityConv : IValueConverter
{
    public object Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        bool isSearchEnabled = (bool)value!;

        return isSearchEnabled ? SearchBoxVisibility.Collapsible : SearchBoxVisibility.Hidden;
    }

    public object ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture) => throw new NotImplementedException();
}