using System.Windows.Input;

namespace DynamicButtonUIChange.ViewModel
{
    public class Model1
    {
        public string CurrentUI { get; private set; } = null!;



        public Model1()
        {
            // 初期UIを設定

            var ButtonCommand1 = new CommandBinding
            (ButtonCommand.ButtonCommand.UIView1, ExecuteUIView1, CanExecuteUIView1);

        }

        private void CanExecuteUIView1(object sender, CanExecuteRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ExecuteUIView1(object sender, ExecutedRoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        public void ChangeUI(string uiName)
        {
            CurrentUI = uiName;
        }



    }
}
