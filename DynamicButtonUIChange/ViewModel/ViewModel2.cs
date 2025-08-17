using DynamicUIChange.Command;
using DynamicUIChange.Model;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace DynamicUIChange.ViewModel
{
    internal class ViewModel2 : INotifyPropertyChanged
    {
        /// <summary>
        /// Command
        /// </summary>
        public ICommand UIViewCommand2 { get; }
        public event PropertyChangedEventHandler? PropertyChanged;


        /// <summary>
        ///ViewModel における「プロパティの定義」 
        /// </summary>
        private ObservableCollection<DataModel2> _people = null!;
        public ObservableCollection<DataModel2> People
        {
            get => _people;
            set
            {
                if (_people != value)
                {
                    _people = value;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(People)));
                }
            }
        }




        public ViewModel2()
        {
            ////ObservableCollection:項目が追加または削除されたとき、またはリスト全体が更新されたときに通知を提供する動的データ コレクション
            _people = new ObservableCollection<DataModel2>();



            UIViewCommand2 = new RelayCommand(_ => Change_UI());


        }

        private void Change_UI()
        {  // サンプルデータ初期化
            _people.Add(new DataModel2 { Id = 1, Name = "ひつじ太郎", Age = 25 });
            _people.Add(new DataModel2 { Id = 2, Name = "ひつじ花子", Age = 30 });
            _people.Add(new DataModel2 { Id = 3, Name = "ひつじ次郎", Age = 21 });
            _people.Add(new DataModel2 { Id = 4, Name = "ひつじ長老", Age = 70 });



        }

    }
}