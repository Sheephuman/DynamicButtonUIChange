using DynamicButtonUIChange.ViewModel;
using System.Windows;
using System.Windows.Input;

namespace DynamicButtonUIChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {

        private readonly Model1 _model;

        public MainView()
        {
            InitializeComponent();
            _model = new Model1();


        }

        private void CanExecuteUIView1(object sender, CanExecuteRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExecuteUIView1(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}