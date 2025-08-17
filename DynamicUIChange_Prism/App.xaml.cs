using DryIoc;
using DynamicChange_Prism.Views;
using DynamicUIChange_Livet.Module;
using DynamicUIChange_Livet.ViewModels;
using DynamicUIChange_Livet.Views;
using Prism.DryIoc;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;


namespace DynamicUIChange_Livet
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    /// 

    ///PrismApplicationを継承：CreateShellの実装が必要
    public partial class App : PrismApplication
    {
        protected override Window CreateShell()
        {
            // アプリケーションのシェル（メインウィンドウ）としてMainViewを解決して返す 
            return Container.Resolve<MainView>();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            // モジュールカタログにModuleInitモジュールを追加して初期化
            moduleCatalog.AddModule<ModuleInit>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

            containerRegistry.RegisterConsoleLogger(); // コンソールロガーを登録


            // 必要ならViewとViewModelを明示的に登録
            // ViewとViewModelの関連付けを登録する
            containerRegistry.RegisterForNavigation<View1, ViewModel1>();
            containerRegistry.RegisterForNavigation<View2, ViewModel2>();
            containerRegistry.RegisterForNavigation<View3, ViewModel3>();

            // MainViewModelをコンテナに登録
            containerRegistry.Register<MainViewModel>();

            // MainViewのビューモデルとしてMainViewModelを解決する設定を登録
            Prism.Mvvm.ViewModelLocationProvider.Register<MainView>(() => Container.Resolve<MainViewModel>());


            // コマンドファクトリの登録(View2用)
            containerRegistry.Register<IRelayCommandFactory, RelayCommandFactory>(); // Add this line
        }
    }
}

