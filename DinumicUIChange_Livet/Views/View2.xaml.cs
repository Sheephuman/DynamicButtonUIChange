using DynamicUIChange_Livet.ViewModels;
using System.Windows.Controls;

namespace DynamicUIChange_Livet.Views
{
    /// <summary>
    /// View2.xaml の相互作用ロジック
    /// </summary>
    public partial class View2 : UserControl
    {
        public View2()
        {
            InitializeComponent();


            DataContext = new ViewModel2();
        }
    }
}
