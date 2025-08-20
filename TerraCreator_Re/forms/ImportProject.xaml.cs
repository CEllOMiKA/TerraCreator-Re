using System.Windows;

namespace TerraCreator_Re_Insider.forms
{
    /// <summary>
    /// ImportProject.xaml 的交互逻辑
    /// </summary>
    public partial class ImportProject : Window
    {
        public ImportProject()
        {
            InitializeComponent();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string ProjectNamespace = ModNamespaceTextBox.Text;
             
        }

        private void ChooseFolderButton_Click(object sender, RoutedEventArgs e)
        {
            var ChooseFolderDialog = new Microsoft.Win32.OpenFolderDialog();
            ChooseFolderDialog.Title = "选择文件夹";
            ChooseFolderDialog.Multiselect = false;
            bool? ChooseFolderDialogResult = ChooseFolderDialog.ShowDialog();
            if(ChooseFolderDialogResult==true)
            {
                ChooseFolderTextBox.Text = ChooseFolderDialog.FolderName;
            }

        }

    }
}
