using System.Windows.Input;

namespace DynamicUIChange_Prism.ButtonCommandManager
{
    static class ButtonCommand
    {

        public static readonly RoutedUICommand UIView1 = new RoutedUICommand(
     "Display UI1", // コマンドの名前
     "Change_UI1", // コマンドの識別名
     typeof(ButtonCommand)); // コマンドが定義されているクラス

        public static readonly RoutedUICommand UIView2 = new RoutedUICommand(
     "Display UI2", // コマンドの名前
     "Change_UI2", // コマンドの識別名
     typeof(ButtonCommand)); // コマンドが定義されているクラス

        public static readonly RoutedUICommand UIView3 = new RoutedUICommand(
     "Display UI3", // コマンドの名前
     "Change_UI3", // コマンドの識別名
     typeof(ButtonCommand)); // コマンドが定義されているクラス
    }
}
