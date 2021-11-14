using Microsoft.AspNetCore.Components.WebView.WindowsForms;
using Microsoft.Extensions.DependencyInjection;
using System.Windows.Forms;

namespace BlazorTemplate.WebView.WinForms
{
    public partial class MainForm : Form
	{
		public MainForm()
		{
			var services = new ServiceCollection();
			services.AddBlazorWebView();

			InitializeComponent();

			blazorWebView.HostPage = @"wwwroot\index.html";
			blazorWebView.Services = services.BuildServiceProvider();
			blazorWebView.RootComponents.Add<Main>("#app");
		}
	}
}
