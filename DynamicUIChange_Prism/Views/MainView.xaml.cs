using System.Windows;

namespace DynamicUIChange_Prism.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            // DataContext = new MainViewModel(); // ←
            //Prismでは不要になる

        }
    }
}
