using DynamicUIChange_Livet.ViewModels;
using Moq;
using System.IO;
using System.Windows.Media.Imaging;


namespace DynamicUIChange_Livet.Test
{
    public class ViewModel1Tests
    {
        Mock<ViewModel1.IImageLoader> mockImageLoader = new();

        [Fact]
        public void LoadImage1_正常系_画像が設定される()
        {
            var fakeImage = new BitmapImage();


            // Moq を使って ImageLoader の LoadImage メソッドをモック
            // 引数に関係なく常に fakeImage を返すよう設定
            mockImageLoader.Setup(m => m.LoadImage(It.IsAny<string>())).Returns(fakeImage);

            // ViewModel1 にモックの ImageLoader を注入してインスタンス化
            var vm = new ViewModel1(mockImageLoader.Object);


            // Arrange
            string current = Directory.GetCurrentDirectory();


            string path = Path.Combine(AppContext.BaseDirectory, "Image", "test.png");

            ViewModel1.IImageLoader imageLoader = ViewModel1.IImage;
            vm.BackImage = vm.LoadImage1(path, imageLoader);

            Console.WriteLine(path);
            Console.WriteLine(vm.ToString());
            // Assert
            Assert.Equal(fakeImage, vm.BackImage);

            mockImageLoader.Verify(m => m.LoadImage(path), Times.Once);
        }
        //[Fact]
        //public void LoadImage1()
        //{
        //    // Arrange
        //    var mockImageLoader = new Mock<IImageLoader>();


        //    mockImageLoader.Setup(m => m.LoadImage2(It.IsAny<string>())).Throws(new Exception("失敗"));

        //    var vm = new ViewModel1(mockImageLoader.Object);

        //    string current = Directory.GetCurrentDirectory();

        //    // Act
        //    vm.LoadImage1(Path.Combine(AppContext.BaseDirectory, @"Image\\test.png"));

        //    // Assert
        //    Assert.Null(vm.BackImage);
        //    // mockMessageService.Verify(m => m.ShowError(It.Is<string>(s => s.Contains("失敗"))), Times.Once);
        //}
    }

}
