using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace Teratail.Questions345835
{
    class NowData
    {
        public static Dictionary<string, SolidColorBrush> Colors { get; } =
            new Dictionary<string, SolidColorBrush>
            {
                {"Red", Brushes.Red },
                {"Blue", Brushes.Blue },
                {"Green", Brushes.Green },
                {"白", Brushes.White },
                {"黒", Brushes.Black },
                {"透明", Brushes.Transparent },
            };
    }
}
