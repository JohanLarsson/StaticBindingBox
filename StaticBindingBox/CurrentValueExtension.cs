using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace StaticBindingBox
{
    [MarkupExtensionReturnType(typeof(TemplateBindingExpression))]
    public class CurrentValueExtension :MarkupExtension
    {
        private static readonly PropertyPath ValuePath = new PropertyPath(nameof(CurrentValueProxy.Value));
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            var binding = new Binding()
            {
                Source = CurrentValueProxy.Instance,
                Path = ValuePath,
                UpdateSourceTrigger = UpdateSourceTrigger.PropertyChanged,
                Mode = BindingMode.OneWay
            };

            return binding.ProvideValue(serviceProvider);
        }

        private class CurrentValueProxy : INotifyPropertyChanged
        {
            internal static readonly CurrentValueProxy Instance = new CurrentValueProxy();
            private CurrentValueProxy()
            {
                Foo.ValueChanged += (_, __) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }

            public event PropertyChangedEventHandler PropertyChanged;

            public int Value => Foo.Value;
        }
    }
}