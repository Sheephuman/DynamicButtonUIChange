using DynamicUIChange.ViewModel;
using System.Windows.Controls;

namespace DynamicUIChange.Views
{
    /// <summary>
    /// View1.xaml の相互作用ロジック
    /// </summary>
    public partial class View1 : UserControl
    {
        public View1()
        {
            InitializeComponent();

            DataContext = new ViewModel1(); // ViewModel1をDataContextに設定
        }
    }
}
