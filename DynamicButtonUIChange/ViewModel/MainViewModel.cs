using DynamicUIChange.Command;
using DynamicUIChange.Views;
using System.ComponentModel;
using System.Windows.Controls;
using System.Windows.Input;

namespace DynamicUIChange.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        View1 _View1 { get; set; }
        View2 _View2 { get; set; }
        View3 _View3 { get; set; }

        private UserControl? _currentView;
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand ShowViewCommand1 { get; }

        public ICommand ShowViewCommand2 { get; }

        public ICommand ShowViewCommand3 { get; }

        ViewModel1 _ViewModel1 { get; }
        ViewModel2 _ViewModel2 { get; }
        ViewModel3 _ViewModel3 { get; }

        public MainViewModel()
        {

            ///シングルトン
            _View1 = new View1();
            _View2 = new View2();
            _View3 = new View3();

            _ViewModel1 = new ViewModel1();
            _ViewModel2 = new ViewModel2();
            _ViewModel3 = new ViewModel3();

            // 初期UIを設定
            ShowViewCommand1 = new RelayCommand(_ => ShowView1());
            ShowViewCommand2 = new RelayCommand(_ => ShowView2());
            ShowViewCommand3 = new RelayCommand(_ => ShowView3());
        }

        private void ShowView3()
        {

            _View3 = new View3();
            CurrentView = _View3;
            CurrentView.DataContext = _ViewModel3;

        }

        private void ShowView2()
        {
            CurrentView = _View2;
            CurrentView.DataContext = _ViewModel2;
        }

        private void ShowView1()
        {
            CurrentView = _View1;
            CurrentView.DataContext = _ViewModel1;

        }

        public UserControl? CurrentView
        {
            get => _currentView;
            set
            {
                _currentView = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(CurrentView)));

            }
        }


    }
}
