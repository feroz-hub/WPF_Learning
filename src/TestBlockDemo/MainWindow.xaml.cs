using System.Diagnostics;
using System.Windows;
using System.Windows.Navigation;

namespace TestBlockDemo;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow:Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void Hyperlink_OnRequestNavigate(object sender, RequestNavigateEventArgs e)
    {
        var psi = new ProcessStartInfo
        {
            FileName = e.Uri.AbsoluteUri,
            UseShellExecute = true
        };
        Process.Start(psi);
        e.Handled = true;
    }
}