using MasterDetailNavigation.ViewModels.Events;
using Prism.Commands;
using Prism.Events;
using Prism.Navigation;

namespace MasterDetailNavigation.ViewModels
{
	public class ChildPageViewModel : ViewModelBase
    {
        public ChildPageViewModel(INavigationService navigationService, IEventAggregator eventAggregator) : base (navigationService)
        {
            Title = "Child Page";
            NavigateToMainCommand = new DelegateCommand(() => eventAggregator.GetEvent<NavigateEvent>().Publish());
        }

        public DelegateCommand NavigateToMainCommand { get; set; }
	}
}
