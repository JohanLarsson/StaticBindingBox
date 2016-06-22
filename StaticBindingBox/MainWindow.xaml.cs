namespace StaticBindingBox
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnIncreaseClick(object sender, RoutedEventArgs e)
        {
            Foo.Value++;
            CurrentValueBox.Text = $"Current value: {Foo.Value}";
        }
    }
}
