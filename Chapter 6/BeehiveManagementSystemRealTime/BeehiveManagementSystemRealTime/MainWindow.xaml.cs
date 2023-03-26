using System;
using System.Windows;
using System.Windows.Threading;

namespace BeehiveManagementSystemRealTime
{
    public partial class MainWindow : Window
    {
        private Queen queen = new Queen();
        private DispatcherTimer timer = new DispatcherTimer();

        public MainWindow()
        {
            InitializeComponent();
            statusReport.Text = queen.StatusReport;
            timer.Tick += Timer_Tick;
            timer.Interval = TimeSpan.FromSeconds(1.5);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Workshift_Click(this, new RoutedEventArgs());
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            queen.AssingBee(jobSelector.Text);
            statusReport.Text = queen.StatusReport;
        }

        private void Workshift_Click(object sender, RoutedEventArgs e)
        {
            queen.WorkTheNextShift();
            statusReport.Text = queen.StatusReport;
        }
    }
}
