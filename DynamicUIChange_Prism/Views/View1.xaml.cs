using System.Windows.Controls;

namespace DynamicUIChange_Livet.Views
{
    /// <summary>
    /// View1.xaml の相互作用ロジック
    /// </summary>
    public partial class View1 : UserControl
    {
        public View1()
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine($"View1 DataContext: {this.DataContext}");


        }
    }
}
