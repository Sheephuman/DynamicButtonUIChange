using DynamicUIChange_Livet.ViewModels;
using System.Windows;
using static DynamicUIChange_Livet.ViewModels.ViewModel1;

namespace DynamicUIChange_Livet.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();


            DataContext = new MainViewModel();
        }

        public MainView(
        IImageLoader IimageLoader)
        {
            InitializeComponent();


            DataContext = new MainViewModel(IimageLoader);
        }
    }
}
