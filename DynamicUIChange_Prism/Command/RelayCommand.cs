using System;
using System.Windows.Input;

namespace DynamicUIChange_Prism.Command
{

    class RelayCommand : ICommand
    {

        /// <summary>
        /// コマンドが実行された際に呼び出されるアクション。
        /// </summary>
        private readonly Action<object> _execute;

        /// <summary>
        /// コマンドが実行可能かどうかを判定する関数。null の場合は常に実行可能とみなされる。
        /// </summary>
        private readonly Func<object, bool> _canExecute;



        /// <summary>
        /// コマンドが実行可能かどうかを判定する。
        /// View（例えばボタンなど）はこのメソッドを参照して、操作の可否を制御する。
        /// </summary>
        /// <param name="parameter">コマンドに渡されるパラメータ（バインドされているオブジェクトなど）</param>
        /// <returns>コマンドが現在有効であれば true、無効であれば false</returns>
        public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;


        /// <summary>
        /// コマンドが実行されたときに呼び出される。
        /// </summary>
        /// <param name="parameter">コマンドに渡されるパラメータ</param>
        public void Execute(object parameter) => _execute(parameter);


        //コマンドの実行内容および実行可否判定を受け取る。
        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

        /// <summary>
        /// WPF のコマンドシステムがコマンドの状態（CanExecute）を再評価する際に使用されるイベント。
        /// このイベントが発火すると、View 側のコントロール（例：Button）は CanExecute を再評価し、ボタンの有効/無効状態を更新する。
        /// 
        /// 通常、CommandManager.RequerySuggested イベントに委譲することで、
        /// フォーカス変更や入力などのタイミングで自動的に状態が更新される。
        /// </summary>
        public event EventHandler CanExecuteChanged
        {

            add => CommandManager.RequerySuggested += value;
            remove => CommandManager.RequerySuggested -= value;
        }

    }
}
