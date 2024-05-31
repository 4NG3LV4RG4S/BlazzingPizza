using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using NorthWind.BlazzingPizza.Frontend.RazorViews.Routing;

namespace NorthWind.BlazzinPizza.WinFormClient
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeBlazorWebView();
        }

        void InitializeBlazorWebView()
        {
            Text = "Blazzing Pizza";
            Bitmap bitmap = new Bitmap("wwwroot/images/icon-512.png");
            Icon = Icon.FromHandle(bitmap.GetHicon());

            BlazorWebView webViewControl = new BlazorWebView();
            webViewControl.Dock = DockStyle.Fill;
            Controls.Add(webViewControl);

            IServiceCollection services = new ServiceCollection();
            services.AddWindowsFormsBlazorWebView();
            services.AddBlazzingPizzaServices();

            webViewControl.HostPage = "wwwroot/index.html";
            webViewControl.Services = services.BuildServiceProvider();
            webViewControl.RootComponents.Add<App>("#app");
        }
    }
}
