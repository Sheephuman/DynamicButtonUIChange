using DynamicUIChange_Livet.ViewModels;

using System;
using System.Diagnostics;
using System.Windows.Controls;

namespace DynamicUIChange_Livet.Views
{   /// <summary>
    /// View3.xaml の相互作用ロジック
    /// </summary>
    public partial class View3 : UserControl
    {
        public View3()
        {
            InitializeComponent();


            Debug.WriteLine("View3 インスタンス生成: " + DateTime.Now);
            DataContext = new ViewModel3();

        }

    }
}
