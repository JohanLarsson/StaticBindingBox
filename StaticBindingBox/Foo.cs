using System.Windows;
using StaticBindingBox.Properties;

namespace StaticBindingBox
{
    using System;
    using System.ComponentModel;

    public static class Foo
    {
        private static int _value;
        public static event EventHandler ValueChanged;
        //public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;

        public static int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                Application.Current.Resources[Keys.CurrentValueKey] = _value;
                ValueChanged?.Invoke(null, EventArgs.Empty);
                //StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Value)));
            }
        }
    }
}