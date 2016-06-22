using System;
using System.ComponentModel;

namespace StaticBindingBox
{
    public static class Foo
    {
        private static int _value;
        public static event EventHandler<PropertyChangedEventArgs> StaticPropertyChanged;

        public static int Value
        {
            get { return _value; }
            set
            {
                _value = value;
                StaticPropertyChanged?.Invoke(null, new PropertyChangedEventArgs(nameof(Value)));
            }
        }
    }
}