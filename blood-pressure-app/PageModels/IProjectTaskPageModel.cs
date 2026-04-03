using blood_pressure_app.Models;
using CommunityToolkit.Mvvm.Input;

namespace blood_pressure_app.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}