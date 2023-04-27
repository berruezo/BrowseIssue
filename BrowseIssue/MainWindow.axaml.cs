using Avalonia.Controls;
using Avalonia.Platform.Storage;

namespace BrowseIssue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            CanResize = false;

            this.SizeToContent = SizeToContent.WidthAndHeight;

            mButton.Click += Button_Click;
        }

        private void Button_Click(object? sender, Avalonia.Interactivity.RoutedEventArgs e)
        {
            IStorageFolder storageFolder =
                this.StorageProvider.TryGetFolderFromPathAsync(new System.Uri("/")).Result;
        }
    }
}