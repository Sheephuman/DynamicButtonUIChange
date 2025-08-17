using DynamicUIChange_Livet.Models;       // データモデルを使用
using Livet.Commands;
using System.Collections.ObjectModel;   // ObservableCollectionを使用
using System.Windows.Input;             // ICommandインターフェースを使用

namespace DynamicUIChange_Livet.ViewModels
{
    internal class ViewModel2 : Livet.ViewModel
    {
        private ObservableCollection<DataModel2> _people; // バックフィールドを初期化なしで宣言
        public ObservableCollection<DataModel2> People
        {
            get => _people;                             // プロパティゲッター
            set => RaisePropertyChanged();  // プロパティセッターで変更通知をトリガー
        }

        public ICommand UIViewCommand2 { get; }         // コマンドプロパティ

        public ViewModel2() // コンストラクタでコマンドファクトリを注入
        {
            _people = new ObservableCollection<DataModel2>(); // ObservableCollectionの初期化
            UIViewCommand2 = new ViewModelCommand(() => Change_UI()); // コマンドをファクトリで生成

        }

        private void InitializeSampleData() // サンプルデータの初期化を別メソッドに分離
        {
            // サンプルデータ初期化
            _people.Add(new DataModel2 { Id = 1, Name = "ひつじ太郎", Age = 25 });
            _people.Add(new DataModel2 { Id = 2, Name = "ひつじ花子", Age = 30 });
            _people.Add(new DataModel2 { Id = 3, Name = "ひつじ次郎", Age = 21 });
            _people.Add(new DataModel2 { Id = 4, Name = "ひつじ長老", Age = 70 });
        }

        private void Change_UI() // UI変更ロジック
        {

            InitializeSampleData(); // 新しいサンプルデータを追加
        }
    }

}

//    // コマンドファクトリインターフェース（依存性注入用）
//    public interface IRelayCommandFactory
//    {
//        ViewModelCommand Create(Action execute); // ICommandを返す

//    }

//    // コマンドファクトリのデフォルト実装
//    public class RelayCommandFactory : IRelayCommandFactory
//    {
//        public ViewModelCommand Create(Action execute)
//        {
//            return new ViewModelCommand(execute); // ICommandとしてDelegateCommandを返す
//        }


//    }
//}