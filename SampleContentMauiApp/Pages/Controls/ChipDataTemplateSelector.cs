using MauiXamlSourceGen.Models;

namespace MauiXamlSourceGen.Pages.Controls;

public class ChipDataTemplateSelector : DataTemplateSelector
{
	public DataTemplate? SelectedTagTemplate { get; set; }
	public DataTemplate? NormalTagTemplate { get; set; }

	protected override DataTemplate OnSelectTemplate(object item, BindableObject container)
	{
		return (item as Tag)?.IsSelected ?? false ? SelectedTagTemplate : NormalTagTemplate;
	}
}