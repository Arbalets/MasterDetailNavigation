using MasterDetailNavigation.ViewModels.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;

namespace MasterDetailNavigation.ViewModels
{
    public class MyMasterDetailPageViewModel : ViewModelBase
    {
        public MyMasterDetailPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base(navigationService)
        {
            NavigateCommand = new DelegateCommand(async () => await NavigationService.NavigateAsync("NavigationPage/MainPage"));
            eventAggregator.GetEvent<NavigateEvent>().Subscribe(() => NavigateCommand.Execute());
        }

        public DelegateCommand NavigateCommand { get; }
    }
}
