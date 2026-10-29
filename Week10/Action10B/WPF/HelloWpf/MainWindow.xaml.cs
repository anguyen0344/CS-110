using System.Windows;
using HelloInvestigation;

namespace HelloWpf
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SayHello_Click(object sender, RoutedEventArgs e)
        {
            Greeting greeting = new Greeting();
            greeting.Name = "Ari";
            MessageText.Text = greeting.BuildMessage();
        }
    }
}