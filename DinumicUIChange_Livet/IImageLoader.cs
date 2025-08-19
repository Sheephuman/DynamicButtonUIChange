using DynamicUIChange_Livet.ViewModels;
using System;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace DynamicUIChange_Livet
{
    public class ImageLoaderClass : ViewModel1.IImageLoader
    {
        public ImageSource LoadImage(string path)
        {

            // 実際に BitmapImage を生成して返す
            return new BitmapImage(new Uri(path, UriKind.RelativeOrAbsolute));
        }

        public ImageSource LoadImage(string path, ViewModel1.IImageLoader imageLoader)
        {
            throw new NotImplementedException();
        }

        public ImageSource LoadImage2(string path)
        {
            throw new System.NotImplementedException();
        }
    }
}
