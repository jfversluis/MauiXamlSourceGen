using MauiXamlSourceGen.Models;
using MauiXamlSourceGen.PageModels;

namespace MauiXamlSourceGen.Pages;

public partial class MainPage : ContentPage
{
	public MainPage(MainPageModel model)
	{
		InitializeComponent();
		BindingContext = model;
	}
}