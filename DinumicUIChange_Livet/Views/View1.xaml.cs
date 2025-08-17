using DynamicUIChange_Livet.ViewModels;
using System.Windows.Controls;
using static DynamicUIChange_Livet.ViewModels.ViewModel1;

namespace DynamicUIChange_Livet.Views
{
    /// <summary>
    /// View1.xaml の相互作用ロジック
    /// </summary>
    public partial class View1 : UserControl
    {
        public View1(IImageLoader imageLoader)
        {
            InitializeComponent();
            System.Diagnostics.Debug.WriteLine($"View1 DataContext: {this.DataContext}");



            DataContext = new ViewModel1(imageLoader);
        }
    }
}
