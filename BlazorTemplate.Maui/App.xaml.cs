using Application = Microsoft.Maui.Controls.Application;

namespace BlazorTemplate.Maui
{
    public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			MainPage = new MainPage();
		}
	}
}
