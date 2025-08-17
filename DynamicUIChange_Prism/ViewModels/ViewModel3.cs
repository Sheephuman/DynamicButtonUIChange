using DynamicUIChange_Livet.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;

namespace DynamicUIChange_Livet.ViewModels
{
    internal class ViewModel3 : BindableBase
    {
        public DelegateCommand UiView3Command { get; }

        DataModel3 _datamodel;
        public ViewModel3()
        {

            _datamodel = new DataModel3()
            {
                UriPath = "https://www.microsoft.com/ja-jp/",
            };

            BrowserUri = new Uri(_datamodel.UriPath);


            UiView3Command = new DelegateCommand(() => BrowserView(URLstrings));

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

                    SetProperty(ref _URLstrings, value);
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
                    SetProperty(ref _BrowserUri, value);
                }
            }
        }



    }
}