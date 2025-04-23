using CommunityToolkit.Mvvm.Input;
using MauiXamlSourceGen.Models;

namespace MauiXamlSourceGen.PageModels;

public interface IProjectTaskPageModel
{
	IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
	bool IsBusy { get; }
}