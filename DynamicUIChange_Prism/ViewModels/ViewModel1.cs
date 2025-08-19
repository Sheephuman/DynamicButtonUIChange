using DynamicUIChange_Prism.Models;
using Prism.Commands;
using Prism.Mvvm;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DynamicUIChange_Prism.ViewModels
{
    public class ViewModel1 : BindableBase
    {
        private ImageSource _backImageSource;
        public ImageSource BackImage
        {
            get => _backImageSource;
            set => SetProperty(ref _backImageSource, value);
        }

        private ImageSource _backImageSource2;
        public ImageSource BackImage2
        {
            get => _backImageSource2;
            set => SetProperty(ref _backImageSource2, value);
        }

        public DelegateCommand Button1Command { get; }
        public DelegateCommand Button2Command { get; }


        DataModel1 _dataModel1;

        public ViewModel1()
        {
            string current = System.IO.Directory.GetCurrentDirectory();

            Button1Command = new DelegateCommand(() => LoadImage1(System.IO.Path.Combine(current, "Image", "test.png")));
            Button2Command = new DelegateCommand(() => LoadImage2(System.IO.Path.Combine(current, "Image", "test2.png")));
        }

        private void LoadImage1(string path)
        {
            try
            {
                _dataModel1 = new DataModel1()
                {
                    ModelBackImage = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute)),
                };

                BackImage = _dataModel1.ModelBackImage;


            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}", "エラー", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }

        private void LoadImage2(string path)
        {
            try
            {
                _dataModel1 = new DataModel1()
                {
                    ModelBackImage2 = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute)),
                };

                BackImage2 = _dataModel1.ModelBackImage2;

            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}", "エラー", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
            }
        }
    }
}