using System.Security.Policy;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Threading;
using System.Windows.Threading;


namespace WpfApp3;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();

        TextBlock content = new TextBlock()
        {
            Text = "Memory Allocation: detecting...",
            FontFamily = new System.Windows.Media.FontFamily("Consolas"),
            FontSize = 40,
            TextWrapping = TextWrapping.Wrap
        };

        this.Content = content;
        this.Title = "Executor: Allocation Detection";

        DispatcherTimer timer = new DispatcherTimer
        {
            Interval = TimeSpan.FromSeconds(12)
        };
        timer.Tick += (sender, e) =>
        {
            content.Text = "Memory Allocation: true";
            ((DispatcherTimer)sender).Stop(); 
        };
        timer.Start();

    }
}
