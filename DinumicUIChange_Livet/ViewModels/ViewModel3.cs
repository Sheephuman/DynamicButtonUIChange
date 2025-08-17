using DynamicUIChange_Livet.Models;
using Livet.Commands;
using System;

namespace DynamicUIChange_Livet.ViewModels
{
    internal class ViewModel3 : Livet.ViewModel
    {
        public ViewModelCommand UiView3Command { get; }

        DataModel3 _datamodel;
        public ViewModel3()
        {

            _datamodel = new DataModel3()
            {
                UriPath = "https://www.microsoft.com/ja-jp/",
            };

            BrowserUri = new Uri(_datamodel.UriPath);


            UiView3Command = new ViewModelCommand(() => BrowserView(URLstrings));

        }

        private void BrowserView(string url)
        {


            if (string.IsNullOrEmpty(url))
                return;

            BrowserUri = new Uri(url);
        }

        private string _URLstrings = null!;
        public string URLstrings
        {
            get => _URLstrings;
            set
            {
                if (_URLstrings != value)
                {
                    _URLstrings = value;
                    RaisePropertyChanged(nameof(BrowserUri));
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
                    RaisePropertyChanged(nameof(BrowserUri));
                }
            }
        }



    }
}