using Microsoft.Web.WebView2.Core;
using Prism.Regions;
using System;
using System.Diagnostics;
using System.Windows.Controls;

namespace DynamicUIChange_Livet.Views
{   /// <summary>
    /// View3.xaml の相互作用ロジック
    /// </summary>
    public partial class View3 : UserControl, IRegionMemberLifetime
    {
        public View3()
        {
            InitializeComponent();


            Debug.WriteLine("View3 インスタンス生成: " + DateTime.Now);


        }

        public bool KeepAlive => false;



        private void WebView_CoreWebView2InitializationCompleted(object sender, CoreWebView2InitializationCompletedEventArgs e)
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
