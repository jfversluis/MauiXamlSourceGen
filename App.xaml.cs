namespace MauiXamlSourceGen;

public partial class App : Application
{
	public App()
	{
		InitializeComponentSourceGen();
	}

	protected override Window CreateWindow(IActivationState? activationState)
	{
		return new Window(new AppShell());
	}
}