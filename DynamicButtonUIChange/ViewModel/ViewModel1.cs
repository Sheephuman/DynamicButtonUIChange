using DynamicUIChange.Command;
using DynamicUIChange.Model;
using System.ComponentModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace DynamicUIChange.ViewModel
{
    public class ViewModel1 : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler? PropertyChanged;


        public ICommand Button1Command { get; }
        public ICommand Button2Command { get; }

        readonly DataModel1 _datamodel1;

        public ViewModel1()
        {
            // 初期UIを設定

            //var ButtonCommand1 = new CommandBinding
            //(ButtonCommandManager.ButtonCommand.UIView1, ExecuteUIView1, CanExecuteUIView1);

            string current = Directory.GetCurrentDirectory();
            _datamodel1 = new DataModel1()
            {
                BackImage = new Image(),
                BackImage2 = new Image(),

                Width = 300,
            };
            BackImage = _datamodel1.BackImage;
            BackImage2 = _datamodel1.BackImage2;

            Button1Command = new RelayCommand(_ => DisplayImage(current + "\\image\\test.png"));
            Button2Command = new RelayCommand(_ => DisplayImage2(current + "\\image\\test2.png"));

            //C:\TestCode\DynamicButtonUIChange\DynamicButtonUIChange\bin\Debug\net9.0-windows7.0\Image
        }


        private Image _backImage = null!;
        public Image BackImage
        {
            get => _backImage;
            set
            {
                _backImage = value;
                OnPropertyChanged(nameof(BackImage));
            }
        }



        private Image _backImage2 = null!;
        public Image BackImage2
        {
            get => _backImage2;
            set
            {
                _backImage2 = value;
                OnPropertyChanged(nameof(BackImage2));
            }
        }

        private void OnPropertyChanged(string v)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(v));
        }

        private void DisplayImage(string imgName)
        {
            try
            {



                BackImage.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(imgName, System.UriKind.RelativeOrAbsolute));
                BackImage.Width = 300;
                BackImage.Height = 200;

            }

            catch (Exception ex)
            {
                MessageBox.Show($"画像の読み込みに失敗しました: {ex.Message}", "エラー", MessageBoxButton.OK, MessageBoxImage.Error);

            }

        }

        private void DisplayImage2(string imgName)
        {
            BackImage2.Source = new System.Windows.Media.Imaging.BitmapImage(new System.Uri(imgName, System.UriKind.RelativeOrAbsolute));
            BackImage2.Width = 300;
            BackImage2.Height = 200;

        }

    }


}








