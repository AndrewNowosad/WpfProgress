using System.Timers;
using System.Windows;

namespace WpfProgress
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Timer timer = new Timer(10);
            timer.Elapsed += TimerElapsed;
            timer.Start();
            Closing += (s, e) => timer.Stop();
        }

        double delta = 0.1;
        private void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            Dispatcher.Invoke(() =>
            {
                ProgressBar1.Value += delta;
                if (ProgressBar1.Value >= ProgressBar1.Maximum ||
                    ProgressBar1.Value <= ProgressBar1.Minimum) delta = -delta;
            });
        }
    }
}