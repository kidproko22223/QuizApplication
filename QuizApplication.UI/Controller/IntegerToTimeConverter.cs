﻿using System;
using System.Globalization;
using System.Windows.Data;
namespace QuizApplication.UI
{
    class IntegerToTimeConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is int))
                throw new ArgumentException("Value must be of type integer.");

            int time = (int)value;
            if (parameter != null && int.Parse(parameter.ToString()) == 1)
                return ControlMethods.GetTimeInClockFormat(time);
            else
                return ControlMethods.GetTimeInHumanLanguage(time);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}