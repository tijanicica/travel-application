﻿using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace BookingApp.WPF.View.TouristPages;

public class InverseBooleanToVisibilityConverter: IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        bool flag = false;
        if (value is bool)
        {
            flag = (bool)value;
        }
        return flag ? Visibility.Collapsed : Visibility.Visible;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}