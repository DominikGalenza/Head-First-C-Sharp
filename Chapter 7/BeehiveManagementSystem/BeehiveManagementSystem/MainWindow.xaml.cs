using System.Windows;

namespace BeehiveManagementSystem
{
    public partial class MainWindow : Window
    {
        private Queen queen = new Queen();

        public MainWindow()
        {
            InitializeComponent();
            statusReport.Text = queen.StatusReport;
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
