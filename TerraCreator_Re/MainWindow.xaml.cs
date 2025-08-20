using System.Diagnostics;
using System.IO;
using System.Windows;
using TerraCreator_Re_Insider.forms;

namespace TerraCreator_Re_Insider
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenProjectButton_Click(object sender, RoutedEventArgs e)
        {
            ImportProject ImportProjectCode = new ImportProject();
            ImportProjectCode.ShowDialog();
        }

        private void OpenGitHubButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://github.com/CEllOMiKA/TerraCreator-Re");
        }

        private void OpenOriginButton_Click(object sender, RoutedEventArgs e)
        {
            string OriginApplicationPath = Path.Combine("origin", "TerraCreator.exe");
            Process.Start(OriginApplicationPath);
        }

    }
}