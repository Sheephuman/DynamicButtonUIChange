using DynamicUIChange.Command;
using DynamicUIChange.Model;
using System.ComponentModel;
using System.Windows.Input;

namespace DynamicUIChange.ViewModel
{
    internal class ViewModel3 : INotifyPropertyChanged
    {
        public ICommand UiView3Command { get; }

        DataModel3 _datamodel;
        public ViewModel3()
        {

            _datamodel = new DataModel3()
            {
                UriPath = "https://www.microsoft.com/ja-jp/",
            };

            BrowserUri = new Uri(_datamodel.UriPath);


            UiView3Command = new RelayCommand(_ => BrowserView());

        }

        private void BrowserView()
        {
            BrowserUri = new Uri(_datamodel.UriPath);
        }


        public string URLstrings
        {
            get => _datamodel.UriPath;
            set
            {
                if (_datamodel.UriPath != value)
                {
                    _datamodel.UriPath = value;
                    OnPropertyChanged(nameof(URLstrings));
                }
            }
        }

        private Uri _BrowserUri = null!;

        public Uri BrowserUri
        {
            get => _BrowserUri;
            set
            {
                if (_BrowserUri != value)
                {
                    _BrowserUri = value;
                    OnPropertyChanged(nameof(BrowserUri));
                }
            }
        }

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public event PropertyChangedEventHandler? PropertyChanged;


    }
}