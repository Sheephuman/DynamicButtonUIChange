using DynamicUIChange_Livet.Views;
using Livet.Commands;
using System.Windows.Controls;
using static DynamicUIChange_Livet.ViewModels.ViewModel1;

namespace DynamicUIChange_Livet.ViewModels
{
    public class MainViewModel : Livet.ViewModel
    {
        private string _title = "Prism Application";
        public string Title
        {
            get { return _title; }
            set { RaisePropertyChanged(); }
        }




        private UserControl _currentView = null!;
        public UserControl CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value; //CurrentView　に値をSetしないとContentsControlに表示されない
                RaisePropertyChanged(nameof(CurrentView));
            }
        }
        //}

        //View1 _View1 { get; set; }
        //View2 _View2 { get; set; }
        //View3 _View3 { get; set; }

        public ViewModelCommand ShowViewCommand1
        { get; }

        public ViewModelCommand ShowViewCommand2 { get; }

        public ViewModelCommand ShowViewCommand3 { get; }


        ViewModel1 _ViewModel1 { get; }
        ViewModel2 _ViewModel2 { get; }
        ViewModel3 _ViewModel3 { get; set; }
        private readonly IImageLoader _imageLoader;



        public MainViewModel()
        {
            ///シングルトン
            _ViewModel1 = new ViewModel1();
            _ViewModel2 = new ViewModel2();
            _ViewModel3 = new ViewModel3();



            // 初期UIを設定
            ShowViewCommand1 = new ViewModelCommand(() => ShowView1(_imageLoader));
            ShowViewCommand2 = new ViewModelCommand(() => ShowView2());
            ShowViewCommand3 = new ViewModelCommand(() => ShowView3());

        }

        public MainViewModel(IImageLoader imageLoader)
        {
            _imageLoader = imageLoader;


            ///シングルトン
            _ViewModel1 = new ViewModel1(_imageLoader);
            _ViewModel2 = new ViewModel2();
            _ViewModel3 = new ViewModel3();

            //// 初期UIを設定
            ShowViewCommand1 = new ViewModelCommand(() => ShowView1(_imageLoader));
            ShowViewCommand2 = new ViewModelCommand(() => ShowView2());
            ShowViewCommand3 = new ViewModelCommand(() => ShowView3());
        }


        private void ShowView3()
        {

            CurrentView = new View3() { DataContext = _ViewModel3 };



        }

        private void ShowView2()
        {
            CurrentView = new View2() { DataContext = _ViewModel2 };


        }

        public void ShowView1(IImageLoader ImageLoader)
        {
            CurrentView = new View1(ImageLoader) { DataContext = _ViewModel1 };

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
