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
using Microsoft.AspNetCore.Components.WebView.Wpf;
using Microsoft.Extensions.DependencyInjection;

namespace NorthWind.BlazzingPizza.WPFClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            InitializeBlazorWebView();
        }

        void InitializeBlazorWebView()
        {
            Title = "Blazzing Pizza";
            string iconScheme = "pack://application:,,,";
            string iconRelativeUri = "wwwroot/images/icon-512.png";
            Uri iconUri = new Uri($"{iconScheme}/{iconRelativeUri}", UriKind.RelativeOrAbsolute);

            Icon = BitmapFrame.Create(iconUri);

            var services = new ServiceCollection();
            services.AddWpfBlazorWebView();

            services.AddBlazorWebViewDeveloperTools();

            services.AddBlazzingPizzaServices();

            var blazorWebViewControl = new BlazorWebView();
            blazorWebViewControl.HostPage = "wwwroot/index.html";
            blazorWebViewControl.Services = services.BuildServiceProvider();
            blazorWebViewControl.RootComponents.Add(
                new RootComponent
                    {
                        ComponentType = typeof(Frontend.RazorViews.Routing.App),
                        Selector = "#app"
                    }
                );
            Content = blazorWebViewControl;
        }
    }
}