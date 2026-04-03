using CommunityToolkit.Mvvm.Input;
using delivery_consumer_app.Models;

namespace delivery_consumer_app.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}