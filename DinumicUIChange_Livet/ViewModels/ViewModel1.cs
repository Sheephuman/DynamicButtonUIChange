using DynamicUIChange_Livet.Models;
using Livet.Commands;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace DynamicUIChange_Livet.ViewModels
{
    public class ViewModel1 : Livet.ViewModel
    {
        public interface IImageLoader
        {
            public ImageSource LoadImage(string path);

            public ImageSource LoadImage2(string path);
        }

        public interface IMessageService
        {
            void ShowError(string message);
        }


        private readonly IImageLoader _imageLoader;

        public static IImageLoader IImage { get; set; }



        private ImageSource _backImageSource;
        public ImageSource BackImage
        {
            get => _backImageSource;
            set
            {
                _backImageSource = value;
                RaisePropertyChanged();
            }
        }

        private ImageSource _backImageSource2;
        public ImageSource BackImage2
        {
            get => _backImageSource2;
            set
            {
                _backImageSource2 = value;
                RaisePropertyChanged();
            }
        }

        public ViewModelCommand Button1Command { get; }
        public ViewModelCommand Button2Command { get; }


        DataModel1 _dataModel1;
        public ViewModel1()
        {
            string current = System.IO.Directory.GetCurrentDirectory();
            Button1Command = new ViewModelCommand(() => LoadImage1(System.IO.Path.Combine(current, "Image", "test.png")));
            Button2Command = new ViewModelCommand(() => LoadImage2(System.IO.Path.Combine(current, "Image", "test2.png")));
        }

        public ViewModel1(IImageLoader imageLoader)
        {
            //Dependency Injection
            _imageLoader = imageLoader;
            IImage = imageLoader;

            string current = System.IO.Directory.GetCurrentDirectory();
            Button1Command = new ViewModelCommand(() => _imageLoader.LoadImage(System.IO.Path.Combine(current, "Image", "test.png")));
            Button2Command = new ViewModelCommand(() => _imageLoader.LoadImage2(System.IO.Path.Combine(current, "Image", "test2.png")));
        }
        public ImageSource LoadImage1(string path)
        {
            try
            {
                _dataModel1 = new DataModel1()
                {
                    ModelBackImage = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute)),
                };

                return BackImage = _dataModel1.ModelBackImage;
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}", "エラー", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);
                return null;
            }
        }


        /// <summary>
        /// testプロジェクトでDI経由で呼ばれる
        /// </summary>
        /// <param name="path"></param>
        /// <param name="imageLoader"></param>
        /// <returns></returns>
        public ImageSource LoadImage1(string path, IImageLoader imageLoader)
        {
            try
            {

                //_imageLoader はすでにインターフェースとして抽象化してあるので、
                //テストでは Mock に置き換える
                //{
                //    _dataModel1 = new DataModel1()
                //    {
                //        ModelBackImage = new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute)),
                //    };

                return BackImage = imageLoader.LoadImage(path);
            }
            catch (Exception ex)
            {
                System.Windows.MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}", "エラー", System.Windows.MessageBoxButton.OK, System.Windows.MessageBoxImage.Error);

                return null;
            }
        }

        public void LoadImage2(string path)
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