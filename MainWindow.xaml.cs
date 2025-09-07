using System.Windows;

namespace CMCS
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
        }

        // Matches the Click event in MainWindow.xaml
        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            // Open the ClaimSubmission window
            ClaimSubmission claimWindow = new ClaimSubmission();
            claimWindow.ShowDialog();
        }
    }
}
