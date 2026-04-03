using CommunityToolkit.Mvvm.Input;
using delivery_rider_app.Models;

namespace delivery_rider_app.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}