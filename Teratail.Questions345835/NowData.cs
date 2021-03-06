using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Media;

namespace Teratail.Questions345835
{
    public class NowData : INotifyPropertyChanged // Binding 対応するために INofityPropertyChanged を実装
    {
        // 今回はここの NowData の static 変数でデータを管理するようにしています。
        public static NowData Instance { get; } = new NowData();

        // Dictionary ではなく ColorInfo の配列にしました。
        public ColorInfo[] Colors { get; } = new ColorInfo[]
        {
            new ColorInfo("Red", Brushes.Red ),
            new ColorInfo("Blue", Brushes.Blue ),
            new ColorInfo("Green", Brushes.Green ),
            new ColorInfo("白", Brushes.White ),
            new ColorInfo("黒", Brushes.Black ),
            new ColorInfo("透明", Brushes.Transparent ),
        };

        // 選択された ColorInfo を保持するプロパティ
        private ColorInfo _colorInfo;
        public ColorInfo SelectedColor
        {
            get => _colorInfo;
            set
            {
                _colorInfo = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(SelectedColor)));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

    public class ColorInfo
    {
        public ColorInfo(string name, Brush brush)
        {
            Name = name;
            Brush = brush;
        }
        public string Name { get; }
        public Brush Brush { get; }
    }
}
