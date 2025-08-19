using DynamicUIChange_Prism.Views;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Regions;
using System.Windows.Controls;

namespace DynamicUIChange_Prism.ViewModels
{
    public class MainViewModel : BindableBase
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        private readonly IRegionManager _regionManager;


        private UserControl _currentView;
        public UserControl CurrentView
        {
            get => _currentView;
            set
            {
                SetProperty(ref _currentView, value);
            }
        }
        //}

        //View1 _View1 { get; set; }
        //View2 _View2 { get; set; }
        //View3 _View3 { get; set; }

        public DelegateCommand ShowViewCommand1 { get; }

        public DelegateCommand ShowViewCommand2 { get; }

        public DelegateCommand ShowViewCommand3 { get; }


        //ViewModel1 _ViewModel1 { get; }
        //ViewModel2 _ViewModel2 { get; }
        //ViewModel3 _ViewModel3 { get; set; }






        public MainViewModel(IRegionManager regionManager)
        {
            _regionManager = regionManager;

            ///シングルトン
            //_View1 = new View1();
            //_View2 = new View2();

            //_ViewModel1 = new ViewModel1();
            //_ViewModel2 = new ViewModel2();


            // 初期UIを設定
            ShowViewCommand1 = new DelegateCommand(() => Navigate(nameof(View1)));
            ShowViewCommand2 = new DelegateCommand(() => Navigate(nameof(View2)));
            ShowViewCommand3 = new DelegateCommand(() => Navigate2(nameof(View3)));

        }



        private void Navigate(string viewName)
        {
            if (string.IsNullOrEmpty(viewName))
                return;

            _regionManager.RequestNavigate("MainRegion", viewName);
        }
        private void Navigate2(string viewName)
        {

            _regionManager.RequestNavigate("MainRegion", viewName);
        }

        ////private void ShowView3()
        ////{

        ////    _View3 = new View3();
        ////    CurrentView = _View3;
        ////    CurrentView.DataContext = _ViewModel3;

        ////}

        ////private void ShowView2()
        ////{
        ////    CurrentView = _View2;
        ////    CurrentView.DataContext = _ViewModel2;
        ////}

        ////private void ShowView1()
        ////{
        ////    CurrentView = _View1;
        ////    CurrentView.DataContext = _ViewModel1;

        ////}
    }
}
