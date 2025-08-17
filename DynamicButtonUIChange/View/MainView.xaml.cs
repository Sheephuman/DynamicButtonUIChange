using DynamicUIChange.ViewModel;
using System.Windows;

namespace DynamicUIChange
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {

        public MainView()
        {
            InitializeComponent();

            DataContext = new MainViewModel(); // ← ここで ViewModel バインド
        }

    }
}