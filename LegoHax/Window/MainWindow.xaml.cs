using System.IO;
using System.Windows;

namespace LegoHax
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            foreach(string dir in new[] { "workspace", "autoexec" })
            {
                if (Directory.Exists(dir))
                {
                    continue;
                }
                Directory.CreateDirectory(dir);
            }
        }
    }
}
