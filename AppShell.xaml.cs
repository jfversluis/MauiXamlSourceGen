namespace MauiXamlSourceGen;

[XamlProcessing(XamlInflator.SourceGen)]
public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponentSourceGen();
	}
}
