using System.Windows;

namespace BeehiveManagementSystem
{
    public partial class MainWindow : Window
    {
        private readonly Queen queen;

        public MainWindow()
        {
            InitializeComponent();
            queen = Resources["queen"] as Queen;
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
