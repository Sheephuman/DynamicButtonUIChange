using DynamicUIChange_Livet.Models;       // データモデルを使用
using Prism.Commands;                   // Prismのコマンド機能（DelegateCommandなど）を使用
using Prism.Mvvm;                       // PrismのMVVM基盤（BindableBaseなど）を使用
using System;
using System.Collections.ObjectModel;   // ObservableCollectionを使用
using System.Windows.Input;             // ICommandインターフェースを使用

namespace DynamicUIChange_Livet.ViewModels
{
    internal class ViewModel2 : BindableBase
    {
        private ObservableCollection<DataModel2> _people; // バックフィールドを初期化なしで宣言
        public ObservableCollection<DataModel2> People
        {
            get => _people;                             // プロパティゲッター
            set => SetProperty(ref _people, value);     // プロパティセッターで変更通知をトリガー
        }

        public ICommand UIViewCommand2 { get; }         // コマンドプロパティ

        public ViewModel2(IRelayCommandFactory commandFactory) // コンストラクタでコマンドファクトリを注入
        {
            _people = new ObservableCollection<DataModel2>(); // ObservableCollectionの初期化
            UIViewCommand2 = commandFactory.Create(() => Change_UI()); // コマンドをファクトリで生成
            InitializeSampleData(); // サンプルデータの初期化を呼び出し
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

    // コマンドファクトリインターフェース（依存性注入用）
    public interface IRelayCommandFactory
    {
        DelegateCommand Create(Action execute); // ICommandを返す

    }

    // コマンドファクトリのデフォルト実装
    public class RelayCommandFactory : IRelayCommandFactory
    {
        public DelegateCommand Create(Action execute)
        {
            return new DelegateCommand(execute); // ICommandとしてDelegateCommandを返す
        }


    }
}