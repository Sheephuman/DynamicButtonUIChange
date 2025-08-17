using DynamicUIChange.ViewModel;
using Microsoft.Web.WebView2.Core;
using System.Windows.Controls;

namespace DynamicUIChange.Views
{
    /// <summary>
    /// View3.xaml の相互作用ロジック
    /// </summary>
    public partial class View3 : UserControl
    {
        public View3()
        {
            InitializeComponent();


            var viewmodel = new ViewModel3();





            DataContext = viewmodel;

            webView.CoreWebView2InitializationCompleted += WebView_CoreWebView2InitializationCompleted;
        }


        private void WebView_CoreWebView2InitializationCompleted(object? sender, CoreWebView2InitializationCompletedEventArgs e)
        {
            if (e.IsSuccess)
            {
                //   webView.CoreWebView2.Navigate("https://www.google.com/");

            }
            else
            {
                // 初期化失敗時の処理
                Console.WriteLine("WebView2初期化に失敗しました: " + e.InitializationException);
            }
        }



    }
}
